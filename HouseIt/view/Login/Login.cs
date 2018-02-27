using HouseIt.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseIt.view
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Loggar in....";
            ControllerLog controller = new ControllerLog();
            string username = txtUser.Text;
            string pw = txtPassword.Text;
            int login = controller.ControllerLogin(username, pw);


            switch (login)
            {
                case 1:
                    this.Hide();
                    var formManager = new FormLandlord.Form1();
                    formManager.Closed += (s, args) => this.Close();
                    formManager.Show();
                    break;
                case 2:
                    this.Hide();
                    var formTenant = new FormTenant.Form1();
                    formTenant.Closed += (s, args) => this.Close();
                    formTenant.Show();
                    break;
                default:
                    lblMessage.Text = "Felaktigt användarnamn eller lösenord!";
                    break;
            }



        }
    }
}
