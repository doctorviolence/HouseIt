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
            BuildingRefresh();
            ApartmentRefresh();
            BuildingComboBoxRefresh();
            ToDoRefresh();
        }


        //---------------------TO DO------------------------------------------------------------
        private void btnToDoRefresh_Click(object sender, EventArgs e)
        {
            ToDoRefresh();
            lblToDoMessage.Text = "Ärenden inlästa.";
        }

        private void btnToDoDone_Click(object sender, EventArgs e)
        {
            if (DGToDo.CurrentRow.Cells[0].Value != null)
            {
                Case selectedCase = (Case)DGToDo.CurrentRow.DataBoundItem;
                int id = selectedCase.CaseNo;
                controller.ControllerMarkCaseAsResolved(id);
                lblToDoMessage.Text = "Markerad som färdig";
                ToDoRefresh();
            }
            else
            {
                lblToDoMessage.Text = "Välj ett ärende att markera som färdigt!";
            }
        }

        private void btnToDoDelete_Click(object sender, EventArgs e)//DAL problem
        {
            if (DGToDo.CurrentRow.Cells[0].Value != null)
            {
                int id = Int32.Parse(DGToDo.CurrentRow.Cells[0].Value.ToString());
                controller.ControllerDelete(id);
                ToDoRefresh();
                lblToDoMessage.Text = "Borttagen!";
            }
            else
            {
                lblToDoMessage.Text = "Välj ett ärende att ta bort!";
            }
        }

        private void btnToDoSetFixDate_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString();
            if (DGToDo.CurrentRow.Cells[0].Value != null)
            {
                Case selectedCase = (Case)DGToDo.CurrentRow.DataBoundItem;
                int id = selectedCase.CaseNo;
                controller.ControllerSetFixDate(id, date);
                ToDoRefresh();
                lblToDoMessage.Text = "Åtgärdsdatum satt";
            }
            else
            {
                lblToDoMessage.Text = "Välj ett ärende att sätta datumet för!";
            }
        }

        //-------------------User-------------------------------

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
                UserClearFields();
                UserRefresh();
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
                if (!txtUserPasswordLL.Text.Equals("") && CBUserHouse.SelectedItem != null)
                {
                    controller.ControllerEditUser(user, password);
                    //controller.ControllerEditManager(user, CBUserHouse.SelectedItem.ToString());
                    lblUserMessage.Text = "Administratör uppdaterad!";
                    UserClearFields();
                    UserRefresh();
                }
                else
                {
                    lblUserMessage.Text = "Admin, Vänligen kontrollera att användarnamn, lösenord och byggnad har valts korrekt!";
                }
            }
            else
            {
                if (!txtUserUsernameLL.Text.Equals("") && !txtUserPasswordLL.Equals("") && !CBUserHouse.SelectedText.Equals("") && !CBUserApt.SelectedText.Equals("") && !txtUserAptLL.Equals("") && !txtUserEmailLL.Equals(""))
                {
                    //controller.ControllerEditUser(user, password);
                    //controller.ControllerEditTenant(user, name, last, CBUserApt.SelectedText.Substring(0, 4));
                    lblUserMessage.Text = "Hyresgäst uppdaterad!";
                    UserClearFields();
                    UserRefresh();
                }
                else
                {
                    lblUserMessage.Text = "Hyresgäst, Vänligen kontrollera att användarnamn, lösenord, namn, efternamn och lägenhet har valts korrekt!";
                }
            }
        }
        private void btnUserDelete_Click_1(object sender, EventArgs e)
        {
            User selectedUser = (User)dGWNewUser.CurrentRow.DataBoundItem;
            String userId;
            if (dGWNewUser.CurrentRow.Cells[0].Value != null)
            {
                userId = dGWNewUser.CurrentRow.Cells[0].Value.ToString();
            }
            else if (txtUserUsernameLL.Text != null || txtUserUsernameLL.Text.Equals(""))
            {
                userId = txtUserUsernameLL.Text;
            }
            else
            {
                lblUserMessage.Text = "Ange Användare!";
                userId = "0";
            }


            if (CBAdmin.Checked == true)
            {
                controller.ControllerDeleteUser(userId);
                //controller.ControllerDeleteManager(userId);
                lblUserMessage.Text = "Borttagen! A";
                UserRefresh();
            }
            else
            {
                controller.ControllerDeleteUser(userId);
                //controller.ControllerDeleteTenant(userId);
                lblUserMessage.Text = "Borttagen! T";
                UserRefresh();
            }
            UserClearFields();
        }

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
                {
                    string[] row = { t.FirstName, t.LastName };
                    DGToDo.Rows.Add(row);
                }
            }
            lblUserMessage.Text = "Användare inlästa.";
        }



        public void UserClearFields()
        {
            txtUserUsernameLL.Clear();
            txtUserPasswordLL.Clear();
            txtUserEmailLL.Clear();
            txtUserAptLL.Clear();
        }

        //Buildings---------------Apartments

        private void btnBuildApartmentRefresh_Click(object sender, EventArgs e)
        {
            ApartmentRefresh();
            lblBuildMessage.Text = "Lägenheter inlästa.";
        }

        private void btnBuildAptAdd_Click(object sender, EventArgs e)
        {
            int aptNo = (int)NumBuildAptNo.Value;
            int size = (int)NumBuildAptSize.Value;
            int floor = (int)NumBuildAptFloor.Value;
            int buildingNo = Int32.Parse(CBBuildBuilding.Text);//Null exec

            controller.ControllerCreateApartment(aptNo, size, floor, buildingNo);
            lblBuildMessage.Text = "Lägenhet tillagd.";
            ApartmentRefresh();
        }

        private void btnBuildAptEdit_Click(object sender, EventArgs e)
        {
            //int aptNo = Int32.Parse(DGBuildApartments.CurrentRow.Cells[0].Value.ToString());
            int size = (int)NumBuildAptSize.Value;
            int floor = (int)NumBuildAptFloor.Value;
            int buildingNo = Int32.Parse(CBBuildBuilding.Text);//Null exec

            controller.ControllerEditApartment(size, floor, buildingNo);
            lblBuildMessage.Text = "Lägenhet ändrad.";
            ApartmentRefresh();
        }
        private void btnBuildAptDelete_Click(object sender, EventArgs e)
        {
            int aptNo = Int32.Parse(DGBuildApartments.CurrentRow.Cells[0].Value.ToString());
            controller.ControllerDeleteApartment(aptNo);
            lblBuildMessage.Text = "Lägenhet borttagen.";
            ApartmentRefresh();
        }

        private void CBBuildBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGBuildApartments.Rows.Clear();
            int id = Int32.Parse(CBBuildBuilding.Text);
            IEnumerable<Apartment> apartments = controller.ControllerLoadApartments(id);
            foreach (Apartment a in apartments)
            {
                string[] row = { a.ApartmentNo.ToString(), a.Size.ToString(), a.Size.ToString() };
                DGBuildApartments.Rows.Add(row);
            }
        }

        //Buildings------------------Buildings

        private void btnBuildBuildingsRefresh_Click(object sender, EventArgs e)
        {
            BuildingRefresh();
            lblBuildMessage.Text = "Byggnader inlästa.";
        }


        private void btnBuildBuildingCreate_Click(object sender, EventArgs e)
        {
            controller.ControllerCreateBuilding(txtBuildAdress.Text);
            BuildingRefresh();
            lblBuildMessage.Text = "Byggnad tillagd.";
            BuildingComboBoxRefresh();
        }
        private void btnBuildBuildingEdit_Click(object sender, EventArgs e)
        {
            string buildId;
            string address;

            if (DGBuildBuildings.CurrentRow.Cells[0].Value != null && txtBuildAdress.Text != "")
            {
                buildId = DGBuildBuildings.CurrentRow.Cells[0].Value.ToString();
                address = txtBuildAdress.Text;
                controller.ControllerEditBuilding(buildId, address);
                BuildingRefresh();
                lblBuildMessage.Text = "Byggnad ändrad.";
            }
            else
            {
                lblBuildMessage.Text = "Vänligen välj en byggnad ur listan!";
            }

        }

        private void btnBuildBuildingDelete_Click(object sender, EventArgs e)
        {
            string buildId;
            if (DGBuildBuildings.CurrentRow.Cells[0].Value != null)
            {
                buildId = DGBuildBuildings.CurrentRow.Cells[0].Value.ToString();
                controller.ControllerDeleteBuilding(buildId);
                BuildingRefresh();
                lblBuildMessage.Text = "Byggnad borttagen.";
            }
            else
            {
                lblBuildMessage.Text = "Vänligen välj en byggnad ur listan!";
            }
        }


        //------------REFRESH----------------------
        private void ToDoRefresh()
        {        // I removed the filtering action here because it's insta recipe for SQL Injection

            string selectedText = CBType.SelectedText.ToString();

            var source = new BindingSource();
            List<Case> listOfCases = controller.ControllerRefresh();
            source.DataSource = listOfCases;
            DGToDo.DataSource = source;
            DGToDo.AutoGenerateColumns = true;
        }

        public void UserRefresh()
        {
            dGWNewUser.Rows.Clear();
            IEnumerable<User> users = controller.ControllerLoadUsers();
            foreach (User u in users)
            {
                string[] row = { u.Username, u.Password };
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

        private void BuildingRefresh()
        {
            DGBuildBuildings.Rows.Clear();
            IEnumerable<Building> buildings = controller.ControllerLoadBuildings();
            foreach (Building b in buildings)
            {
                string[] row = { b.BuildingId.ToString(), b.Address };
                DGBuildBuildings.Rows.Add(row);
            }
        }

        private void ApartmentRefresh()
        {
            DGBuildApartments.Rows.Clear();
            IEnumerable<Apartment> apartments = controller.ControllerLoadApartments();
            foreach (Apartment a in apartments)
            {
                string[] row = { a.ApartmentNo.ToString(), a.Size.ToString(), a.Size.ToString() };
                DGBuildApartments.Rows.Add(row);
            }
        }

        private void BuildingComboBoxRefresh()
        {
            CBBuildBuilding.Items.Clear();
            IEnumerable<Building> buildings = controller.ControllerLoadBuildings();
            foreach (Building b in buildings)
            {
                string row = b.BuildingId.ToString();
                CBBuildBuilding.Items.Add(row);
            }
        }
    }

}


