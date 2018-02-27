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

namespace FormTenant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblTenantMessage.Text = "Välkommen, " + Constants.LoggedInUser.Username;
        }

        ControllerT controller = new ControllerT();

        private void checkBoxYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNo.Checked == true) { checkBoxNo.Checked = false; }
            else { checkBoxNo.Checked = true; }
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYes.Checked == true) { checkBoxYes.Checked = false; }
            else { checkBoxYes.Checked = true; }
        }

        private void checkBoxYesAni_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoAni.Checked == true) { checkBoxNoAni.Checked = false; }
            else { checkBoxNoAni.Checked = true; }
        }

        private void checkBoxNoAni_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYesAni.Checked == true) { checkBoxYesAni.Checked = false; }
            else { checkBoxYesAni.Checked = true; }
        }

        private void btnSendWW_Click(object sender, EventArgs e)
        {
            string type = CBReportWhat.Text;
            bool key = checkBoxYes.Checked;
            bool pet = checkBoxYesAni.Checked;
            string text = textBoxProblemT.Text;

            controller.ControllerReportCase(type, key, pet, text);
        }

        // Done for now, goal is to use tenant id from login form...
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            /*
             * NOTE: version 1.0 (demonstration purposes only)
             */
            int tenantId = Constants.LoggedInUser.Tenant.TenantId;

            var source = new BindingSource();
            IEnumerable<Case> listOfCases = controller.ControllerLoadMyCases(tenantId);
            source.DataSource = listOfCases;
            DGMyCases.DataSource = source;
            DGMyCases.AutoGenerateColumns = false;

            lblMyMessage.Text = "Ärenenden inlästa.";
        }
    }
}
