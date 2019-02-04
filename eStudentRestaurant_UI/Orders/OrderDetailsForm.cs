using eStudentRestaurant_API.Models;
using eStudentRestaurant_UI.Main;
using eStudentRestaurant_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuItem = eStudentRestaurant_API.Models.MenuItem;

namespace eStudentRestaurant_UI.Orders
{
    public partial class OrderDetailsForm : ChildDialogForm
    {

        private WebAPIHelper ordersService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.OrdersRoutes);
        private WebAPIHelper menusService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.MenusRoutes);
        private WebAPIHelper productsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ProductsRoutes);

        Order_ order;
        List<OrderItem> orderItems;
        List<OrderMenu> orderMenus;
        
        decimal TotalPrice;
        List<OrderDetails_Result> orderDetails;

        public OrderDetailsForm(int OrderID)
        {
            InitializeComponent();
            OrderDetailsDataGrid.AutoGenerateColumns = false;

            HttpResponseMessage responseMessage = ordersService.GetResponse(OrderID.ToString());
            if (responseMessage.IsSuccessStatusCode)
            {
                order = responseMessage.Content.ReadAsAsync<Order_>().Result;
            }
            else
            {
                MessageBox.Show(" Error code: " + responseMessage.StatusCode + " Message: " + responseMessage.ReasonPhrase);
            }
           
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage responseMessage = ordersService.GetActionResponseIdParam("GetOrderDetailsByOrderID", order.OrderID);

            if (responseMessage.IsSuccessStatusCode)
            {
                orderDetails = responseMessage.Content.ReadAsAsync<List<OrderDetails_Result>>().Result;


                OrderDetailsDataGrid.DataSource = orderDetails;
            }
            else
            {
                MessageBox.Show("Error code: " + responseMessage.StatusCode + " Message: " + responseMessage.ReasonPhrase);
            }
        }

        private void ProcessOrderButton_Click(object sender, EventArgs e)
        {
           if( ValidateOrder() == false)
            {
                order.OrderStatusID = 2;
                order.TotalPrice = 0;
                order.EmployeeID = Global.LoggedUser.EmployeeID;
                HttpResponseMessage responseMessageUpdateOrder = ordersService.PutResponse(order.OrderID, order);
                if (responseMessageUpdateOrder.IsSuccessStatusCode)
                {
                    MessageBox.Show("Order is not valid!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error code: " + responseMessageUpdateOrder.StatusCode + " Message: " + responseMessageUpdateOrder.ReasonPhrase);

                }
               
            }
           else
            {
                #region ProcessOrderItems
                if (orderItems.Count() > 0)
                {
                    foreach (var item in orderItems)
                    {
                        HttpResponseMessage respProduct = productsService.GetResponse(item.ProductID.ToString());
                        if (respProduct.IsSuccessStatusCode)
                        {
                            Product product = respProduct.Content.ReadAsAsync<Product>().Result;
                            product.QuantityStock -= item.Quantity;
                            TotalPrice += item.Quantity * item.Product.Price;

                            HttpResponseMessage respUpdateProduct = productsService.PutResponse(product.ProductID, product);
                        }
                        else
                        {
                            MessageBox.Show("Error code: " + respProduct.StatusCode + " Message: " + respProduct.ReasonPhrase);
                        }
                    }
                }

              

                #endregion

                #region ProccesMenuItems
                if (orderMenus.Count() > 0)
                {
                    foreach (var item in orderMenus)
                    {
                        HttpResponseMessage responseMenuItems = menusService.GetActionResponse("GetMenuItems", item.MenuID.ToString());
                        if (responseMenuItems.IsSuccessStatusCode)
                        {
                            List<MenuItem> menuItems = responseMenuItems.Content.ReadAsAsync<List<MenuItem>>().Result;

                            if (menuItems.Count() > 0)
                            {
                                foreach (var menuItem in menuItems)
                                {
                                    HttpResponseMessage respProduct = productsService.GetResponse(menuItem.ProductID.ToString());
                                    if (respProduct.IsSuccessStatusCode)
                                    {
                                        Product product = respProduct.Content.ReadAsAsync<Product>().Result;
                                        product.QuantityStock -= menuItem.Quantity*item.Quantity;

                                        HttpResponseMessage respUpdateProduct = productsService.PutResponse(product.ProductID, product);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error code: " + respProduct.StatusCode + " Message: " + respProduct.ReasonPhrase);
                                    }
                                }
                            }

                            TotalPrice += item.Quantity * item.Menu.Price;


                        }




                    }
                }


                #endregion

                order.TotalPrice = TotalPrice;
                order.OrderStatusID = 3;
                order.EmployeeID = Global.LoggedUser.EmployeeID;
                HttpResponseMessage respUpdateOrder = ordersService.PutResponse(order.OrderID, order);
                if (respUpdateOrder.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.msg_succ);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error code: " + respUpdateOrder.StatusCode + " Message: " + respUpdateOrder.ReasonPhrase);

                }
            }


        }

        private bool ValidateOrder()
        {
            #region GetOrderItems
            HttpResponseMessage responseOrderItems = ordersService.GetActionResponse("GetOrderItems", order.OrderID.ToString());
            if (responseOrderItems.IsSuccessStatusCode)
            {
                orderItems = responseOrderItems.Content.ReadAsAsync<List<OrderItem>>().Result;

            }
            else
            {
                MessageBox.Show("Error code: " + responseOrderItems.StatusCode + " Message: " + responseOrderItems.ReasonPhrase);
            }

            #endregion

            #region GetOrderMenus
            HttpResponseMessage responseOrderMenus = ordersService.GetActionResponse("GetOrderMenus", order.OrderID.ToString());
            if (responseOrderItems.IsSuccessStatusCode)
            {
                orderMenus = responseOrderMenus.Content.ReadAsAsync<List<OrderMenu>>().Result;

            }
            else
            {
                MessageBox.Show("Error code: " + responseOrderItems.StatusCode + " Message: " + responseOrderItems.ReasonPhrase);
            }

            #endregion

            #region ValidateOrderItems
            bool orderItemIsValid = true ;

            if (orderItems.Count()>0)
            {
                foreach (OrderItem item in orderItems)
                {
                    if (item.Quantity > item.Product.QuantityStock)
                    {
                        orderItemIsValid = false;
                        break;
                    }
                }
            }
            #endregion

            #region ValidateOrderMenus
            bool orderMenusValid = true;

            if (orderMenus.Count()>0)
            {
                foreach (OrderMenu item in orderMenus)
                {
                    HttpResponseMessage responseMenuItems = menusService.GetActionResponse("GetMenuItems", item.MenuID.ToString());
                    if (responseMenuItems.IsSuccessStatusCode)
                    {
                        List<MenuItem> menuItems = responseMenuItems.Content.ReadAsAsync<List<MenuItem>>().Result;

                        if (menuItems.Count() > 0)
                        {
                            foreach (var menuItem in menuItems)
                            {
                                if ((menuItem.Quantity * item.Quantity) > menuItem.Product.QuantityStock)
                                {
                                    orderMenusValid = false;
                                    break;
                                }
                            }
                        }

                    }
                }
            }


            #endregion

            if (orderItemIsValid == false || orderMenusValid == false )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
