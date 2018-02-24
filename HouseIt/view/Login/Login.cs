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
            ControllerLog controller = new ControllerLog();
            string username = txtUser.ToString();
            string pw = txtPassword.ToString();
            controller.ControllerLogin(username, pw);
        }
    }
}
