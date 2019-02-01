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
        private WebAPIHelper reservationsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ReservationsRoutes);


        private Client client;
        List<Client> clients;
        public ClientsIndexForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
           
        }

        private void ClientsIndexForm_Load(object sender, EventArgs e)
        {
            ReservationGridView.AutoGenerateColumns = false;
            GetClients(); 
        }

        private void BindGrid( int id)
        {
            HttpResponseMessage reservationResp = reservationsService.GetActionResponseIdParam("GetReservationByClient", id);

            if (reservationResp.IsSuccessStatusCode)
            {
                List<Reservation_Result> reservations = reservationResp.Content.ReadAsAsync <List<Reservation_Result>>().Result;
                if (reservations.Count != 0)
                {
                    ReservationGridView.DataSource = reservations;
                }
                else
                {
                    ReservationGridView.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Error Code" +
                    reservationResp.StatusCode + " : Message - " + reservationResp.ReasonPhrase);
            }
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
                    comboItems.Add(new ComboItem { ID = item.ClientID, Text = item.FirstName + " " + item.LastName });
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
        private void FillDetails()
        {

            if (client != null)
            {
                FirstNameInput.Text = client.FirstName;
                LastNameInput.Text = client.LastName;

                OrganizationNameInput.Text = client.OrganizationName;
                PhoneInput.Text = client.Phone;

                ActiveCheckBox.Checked = client.Active;

                UsernameInput.Text = client.Username;

                BindGrid(client.ClientID);
            }
        }

        private void ClientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clients.Count() > 0)
            {
               

                client = clients[ClientsComboBox.SelectedIndex];
                FillDetails();
            }

        }


        #region validation
        private void FirstNameInput_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(FirstNameInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(FirstNameInput, Messages.Required_Error);
            }
            else if (FirstNameInput.TextLength > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(FirstNameInput, Messages.overflow_err);
            }
            else if (FirstNameInput.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(FirstNameInput, Messages.number_err);
            }
            else
            {
                errorProvider.SetError(FirstNameInput, "");
            }


        }

        private void LastNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LastNameInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(LastNameInput, Messages.Required_Error);
            }
            else if (LastNameInput.TextLength > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(LastNameInput, Messages.overflow_err);
            }
            else if (LastNameInput.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(LastNameInput, Messages.number_err);
            }
            else
            {
                errorProvider.SetError(LastNameInput, "");
            }
        }
        private void OrganizationNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(OrganizationNameInput.Text))
            {
                errorProvider.SetError(PasswordInput, null); 
            }
            else if (OrganizationNameInput.TextLength > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(OrganizationNameInput, Messages.overflow_err);
            }
            else if (OrganizationNameInput.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(OrganizationNameInput, Messages.number_err);
            }
            else
            {
                errorProvider.SetError(OrganizationNameInput, "");
            }

        }

        private void UsernameInput_Validating(object sender, CancelEventArgs e)
        {
            HttpResponseMessage res = clientsService.GetActionResponse("UsernameExist", UsernameInput.Text);

            if (String.IsNullOrEmpty(UsernameInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(UsernameInput, Messages.Required_Error);
            }
            else if (UsernameInput.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(UsernameInput, Messages.Error);
            }
            else if (UsernameInput.TextLength > 100)
            {
                e.Cancel = true;
                errorProvider.SetError(UsernameInput, Messages.overflow_err);
            }

            else if (res.StatusCode != System.Net.HttpStatusCode.NotFound)
            {
                Client clt = res.Content.ReadAsAsync<Client>().Result;
                if (clt.ClientID == client.ClientID)
                {
                    errorProvider.SetError(UsernameInput, null);
                }
                else
                {
                    e.Cancel = true;
                    errorProvider.SetError(UsernameInput, Messages.username_ex_err);
                }

            }

            else
                errorProvider.SetError(UsernameInput, null);



        }

        private void PasswordInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordInput.Text))
            {
                errorProvider.SetError(PasswordInput, null);
            }
            else
            {
                if (PasswordInput.TextLength < 6 || !PasswordInput.Text.Any(char.IsDigit) || !PasswordInput.Text.Any(char.IsLetter))
                {
                    e.Cancel = true;
                    errorProvider.SetError(PasswordInput, Messages.pass_err);
                }
                else
                    errorProvider.SetError(PasswordInput, null);
            }

        }

        private void PhoneInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PhoneInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(PhoneInput, Messages.Required_Error);
            }
            else
                errorProvider.SetError(PhoneInput, null);
        }

        #endregion

        private void EditClientButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (client != null)
                {
                    client.FirstName = FirstNameInput.Text;
                    client.LastName = LastNameInput.Text;

                    client.OrganizationName = OrganizationNameInput.Text;
                    client.Phone = PhoneInput.Text;

                    client.Active = ActiveCheckBox.Checked;

                    client.Username = UsernameInput.Text;
                    if (PasswordInput.Text != String.Empty)
                    {
                        client.PasswordSalt = UIHelper.GenerateSalt();
                        client.PaswordHash = UIHelper.GenerateHash(client.PasswordSalt, PasswordInput.Text);
                    }


                    HttpResponseMessage httpResponseMessage = clientsService.PutResponse(client.ClientID, client);

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.msg_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDetails();
                    }
                    else
                    {
                        MessageBox.Show("Error Code" +
                        httpResponseMessage.StatusCode + " : Message - " + httpResponseMessage.ReasonPhrase);
                    }

                    
                }


            }
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            ClientAddForm frm = new ClientAddForm();
            frm.ShowDialog();
            GetClients();
        }

        private void ApproveReservationButton_Click(object sender, EventArgs e)
        {
            if (ReservationGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error! You didnt select reservation to edit!");
            }
            else
            {
                HttpResponseMessage resApproveResp = reservationsService.GetActionResponseIdParam("ApprovedReservationExist", Convert.ToInt32(ReservationGridView.SelectedRows[0].Cells[0].Value));

                if (resApproveResp.StatusCode != System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Sorry, but reservation on that date is alerady exist!");
                }
                else
                {
                    MessageBox.Show("Success! Reservation is approved!");
                    BindGrid(client.ClientID);
                }

               

            }
           
        }
    }
}
