using HouseIt.controllers;
using HouseIt.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLandlord
{
    public partial class Form1 : Form
    {
        ControllerLL controller = new ControllerLL();
        public Form1()
        {
            InitializeComponent();
            UserRefresh();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // DONE
        private void btnToDoDone_Click(object sender, EventArgs e)
        {
            if (DGToDo.CurrentCell is null)
            {
                lblToDoMessage.Text = "Välj ett ärende att markera som färdigt!";
            }
            else
            {
                Case selectedCase = (Case)DGToDo.CurrentRow.DataBoundItem;
                int id = selectedCase.CaseNo;
                controller.ControllerMarkCaseAsResolved(id);
                lblToDoMessage.Text = "Markerad som färdig";
            }
        }

        // I removed the filtering action here because it's insta recipe for SQL Injection
        private void btnToDoRefresh_Click(object sender, EventArgs e)
        {
            string selectedText = CBType.SelectedText.ToString();

            var source = new BindingSource();
            List<Case> listOfCases = controller.ControllerRefresh();
            source.DataSource = listOfCases;
            DGToDo.DataSource = source;
            DGToDo.AutoGenerateColumns = true;
            lblToDoMessage.Text = "Ärenden inlästa.";
        }

        // DONE
        private void btnToDoDelete_Click(object sender, EventArgs e)
        {
            if ((DGToDo.CurrentCell is null))
            {
                lblToDoMessage.Text = "Välj ett ärende att ta bort!";
            }
            else
            {
                Case selectedCase = (Case)DGToDo.CurrentRow.DataBoundItem;
                int id = selectedCase.CaseNo;
                controller.ControllerDelete(id);
                lblToDoMessage.Text = "Borttagen!";
            }
        }

        // DONE
        private void btnToDoSetFixDate_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString();
            if (DGToDo.CurrentCell is null)
            {
                lblToDoMessage.Text = "Välj ett ärende att sätta datumet för!";
            }
            else
            {
                Case selectedCase = (Case)DGToDo.CurrentRow.DataBoundItem;
                int id = selectedCase.CaseNo;
                controller.ControllerSetFixDate(id, date);
                lblToDoMessage.Text = "Åtgärdsdatum satt";
            }
        }

        private void btnUserCreate_Click(object sender, EventArgs e)
        {
            string user = txtUserUsernameLL.Text;
            string password = txtUserPasswordLL.Text;
            string firstName = txtUserEmailLL.Text;
            string lastName = txtUserAptLL.Text;
            bool admin = CBAdmin.Checked;
            // Fix here
            int aptNo = 0;

            if (CBUserApt.SelectedItem == null)
            {
                lblUserMessage.Text = "Kontrollera att uppgifterna matats in korrekt!";
            }
            else
            {
                aptNo = Int32.Parse(CBUserApt.SelectedItem.ToString().Substring(0, 4));
            }
            if (CBUserHouse.SelectedItem == null)
            {
                lblUserMessage.Text = "Kontrollera att uppgifterna matats in korrekt!";
            }
            else
            {
                int house = Int32.Parse(CBUserHouse.SelectedItem.ToString().Substring(0, 1));
                lblUserMessage.Text = controller.ControllerCreateAccount(user, password, firstName, lastName, aptNo, house, admin);
            }
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            string user = txtUserUsernameLL.Text;
            string password = txtUserPasswordLL.Text;
            string name = txtUserEmailLL.Text;
            string last = txtUserAptLL.Text;
            if (CBAdmin.Checked == true)
            {
                if (!txtUserUsernameLL.Text.Equals("") && !txtUserPasswordLL.Equals("") && !CBUserHouse.SelectedText.Equals(""))
                {
                    //controller.ControllerEditUser(user, password);
                    //controller.ControllerEditManager(user, CBUserHouse.SelectedText.Substring(0, 3));
                    lblUserMessage.Text = "Administratör uppdaterad!";
                }
                else
                {
                    lblUserMessage.Text = "Vänligen kontrollera att användarnamn, lösenord och byggnad har valts korrekt!";
                }
            }
            else
            {
                if (!txtUserUsernameLL.Text.Equals("") && !txtUserPasswordLL.Equals("") && !CBUserHouse.SelectedText.Equals("") && !CBUserApt.SelectedText.Equals("") && !txtUserAptLL.Equals("") && !txtUserEmailLL.Equals(""))
                {
                    //controller.ControllerEditUser(user, password);
                    //controller.ControllerEditTenant(user, name, last, CBUserApt.SelectedText.Substring(0, 4));
                    lblUserMessage.Text = "Hyresgäst uppdaterad!";
                }
                else
                {
                    lblUserMessage.Text = "Vänligen kontrollera att användarnamn, lösenord, namn, efternamn och lägenhet har valts korrekt!";
                }
            }
        }

        // Metoden funkar inte. Nonrespons när man klickar på delete knapp, kollat om det är rätt path?
        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)dGWNewUser.CurrentRow.DataBoundItem;
            string userId = selectedUser.Username.ToString();
            controller.ControllerDeleteUser(userId);
            lblUserMessage.Text = "Borttagen!";
        }

        /* Done
        private void btnUserRefresh_Click(object sender, EventArgs e)
        {
            var source = new BindingSource();
            List<User> listOfUsers = controller.ControllerLoadUsers();
            source.DataSource = listOfUsers;
            dGWNewUser.DataSource = source;
            dGWNewUser.AutoGenerateColumns = true;
            lblUserMessage.Text = "Användare inlästa.";

        }*/

        private void btnUserRefresh_Click(object sender, EventArgs e)
        {
            UserRefresh();
        }

        private void CBUserHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBUserApt.Items.Clear();
            //string house = CBUserHouse.SelectedItem.ToString().Substring(0, 1);
            int BuildingId = Int32.Parse(CBUserHouse.SelectedItem.ToString());
            IEnumerable<Apartment> apartments = controller.ControllerLoadApartments(BuildingId);
            //int inthouse = Int32.Parse(house);
            foreach (Apartment a in apartments)
            {
                string row = a.ApartmentNo.ToString() + ", Våning: " + a.FloorNo;
                CBUserApt.Items.Add(row);
            }
        }

        private void CBUserApt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intAptNr = Int32.Parse(CBUserApt.Text.Substring(0, 3));
            IEnumerable<Tenant> tenants = controller.ControllerLoadTenants();
            foreach (Tenant t in tenants)
            {
                if (t.Apartment.ApartmentNo == intAptNr)
                { //Ladda in apts via dal också?
                    string[] row = { t.FirstName, t.LastName };
                    DGToDo.Rows.Add(row);
                }
            }
            lblUserMessage.Text = "Användare inlästa.";
        }

        // Done
        public void UserRefresh()
        {
            dGWNewUser.Rows.Clear();
            IEnumerable<User> users = controller.ControllerLoadUsers();
            foreach (User u in users)
            {
                string[] row = { u.Username };
                dGWNewUser.Rows.Add(row);
            }
            lblUserMessage.Text = "Användare inlästa.";
            IEnumerable<Building> houses = controller.ControllerLoadHouses();
            CBUserHouse.Items.Clear();
            foreach (Building h in houses)
            {
                int row = h.BuildingId;
                CBUserHouse.Items.Add(row);
            }
        }



    }

}


