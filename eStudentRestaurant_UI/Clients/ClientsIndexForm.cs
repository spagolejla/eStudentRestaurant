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

namespace eStudentRestaurant_UI.Clients
{
    public partial class ClientsIndexForm : ChildForm
    {
        private WebAPIHelper clientsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ClientsRoutes);
        private Client client;
        List<Client> clients;
        public ClientsIndexForm()
        {
            InitializeComponent();
        }

        private void ClientsIndexForm_Load(object sender, EventArgs e)
        {
            GetClients();
        }

       private void GetClients()


        {
            HttpResponseMessage response = clientsService.GetResponse();
            
            if (response.IsSuccessStatusCode)
            {
                 clients = response.Content.ReadAsAsync<List<Client>>().Result;

                List<ComboItem> comboItems = new List<ComboItem>();

                foreach (Client item in clients)
                {
                    comboItems.Add(new ComboItem { ID = item.ClientID, Text = item.FirstName +" "+ item.LastName });
                }

                ClientsComboBox.DataSource = comboItems;
                client = clients[0];
                FillDetails();
            }
            else
            {
                MessageBox.Show("Error Code" +
               response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
        private void FillDetails() {

            if (client != null)
            {
                FirstNameInput.Text = client.FirstName;
                LastNameInput.Text = client.LastName;
           
                OrganizationNameInput.Text = client.OrganizationName;
                PhoneInput.Text = client.Phone;

                ActiveCheckBox.Checked = client.Active;

                UsernameInput.Text = client.Username;

            }
        }

        private void ClientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clients.Count()>0)
            {
              //  int id = (int)ClientsComboBox.SelectedValue;

                client = clients[ClientsComboBox.SelectedIndex];
                FillDetails();
            }
            
        }
    }
}
