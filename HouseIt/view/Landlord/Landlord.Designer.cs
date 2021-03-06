﻿using System.Windows.Forms;

namespace FormLandlord
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.lblToDoMessage = new System.Windows.Forms.Label();
            this.DGToDo = new System.Windows.Forms.DataGridView();
            this.btnToDoSetFixDate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblToDoFixDate = new System.Windows.Forms.Label();
            this.btnToDoDelete = new System.Windows.Forms.Button();
            this.btnToDoDone = new System.Windows.Forms.Button();
            this.btnToDoRefresh = new System.Windows.Forms.Button();
            this.cCaseNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFixDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.CBAdmin = new System.Windows.Forms.CheckBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblGerericInfo = new System.Windows.Forms.Label();
            this.lblApt = new System.Windows.Forms.Label();
            this.lblHouse = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.btnUserRefresh = new System.Windows.Forms.Button();
            this.dGWNewUser = new System.Windows.Forms.DataGridView();
            this.Användarnamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserAppartment = new System.Windows.Forms.Label();
            this.lblUserHouse = new System.Windows.Forms.Label();
            this.CBUserApt = new System.Windows.Forms.ComboBox();
            this.CBUserHouse = new System.Windows.Forms.ComboBox();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserCreate = new System.Windows.Forms.Button();
            this.txtUserAptLL = new System.Windows.Forms.TextBox();
            this.txtUserEmailLL = new System.Windows.Forms.TextBox();
            this.txtUserPasswordLL = new System.Windows.Forms.TextBox();
            this.txtUserUsernameLL = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserUsername = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuildBuildingsRefresh = new System.Windows.Forms.Button();
            this.lblBuildMessage = new System.Windows.Forms.Label();
            this.btnBuildBuildingDelete = new System.Windows.Forms.Button();
            this.btnBuildBuildingEdit = new System.Windows.Forms.Button();
            this.btnBuildBuildingCreate = new System.Windows.Forms.Button();
            this.txtBuildAdress = new System.Windows.Forms.TextBox();
            this.DGBuildBuildings = new System.Windows.Forms.DataGridView();
            this.cBuildingNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuildBuildingTop = new System.Windows.Forms.Label();
            this.lblBuildApartmentTop = new System.Windows.Forms.Label();
            this.lblBuildFloor = new System.Windows.Forms.Label();
            this.lblBuildSize = new System.Windows.Forms.Label();
            this.lblApartmentNo = new System.Windows.Forms.Label();
            this.lblBuildApartment = new System.Windows.Forms.Label();
            this.btnBuildApartmentRefresh = new System.Windows.Forms.Button();
            this.DGBuildApartments = new System.Windows.Forms.DataGridView();
            this.cAptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuildAptDelete = new System.Windows.Forms.Button();
            this.btnBuildAptEdit = new System.Windows.Forms.Button();
            this.btnBuildAptAdd = new System.Windows.Forms.Button();
            this.NumBuildAptFloor = new System.Windows.Forms.NumericUpDown();
            this.NumBuildAptSize = new System.Windows.Forms.NumericUpDown();
            this.NumBuildAptNo = new System.Windows.Forms.NumericUpDown();
            this.CBBuildBuilding = new System.Windows.Forms.ComboBox();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGToDo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWNewUser)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBuildBuildings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGBuildApartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBuildAptFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBuildAptSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBuildAptNo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CBType);
            this.tabPage2.Controls.Add(this.lblToDoMessage);
            this.tabPage2.Controls.Add(this.DGToDo);
            this.tabPage2.Controls.Add(this.btnToDoSetFixDate);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.lblToDoFixDate);
            this.tabPage2.Controls.Add(this.btnToDoDelete);
            this.tabPage2.Controls.Add(this.btnToDoDone);
            this.tabPage2.Controls.Add(this.btnToDoRefresh);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1161, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Att göra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CBType
            // 
            this.CBType.FormattingEnabled = true;
            this.CBType.Items.AddRange(new object[] {
            "Alla Ärenden",
            "Vatten",
            "Avlopp",
            "Värme",
            "El",
            "Övrig skada",
            "Övrigt"});
            this.CBType.Location = new System.Drawing.Point(27, 18);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(249, 24);
            this.CBType.TabIndex = 10;
            this.CBType.Text = "Välj ärenden att läsa in";
            // 
            // lblToDoMessage
            // 
            this.lblToDoMessage.AutoSize = true;
            this.lblToDoMessage.Location = new System.Drawing.Point(24, 520);
            this.lblToDoMessage.Name = "lblToDoMessage";
            this.lblToDoMessage.Size = new System.Drawing.Size(78, 17);
            this.lblToDoMessage.TabIndex = 9;
            this.lblToDoMessage.Text = "Status: Kör";
            // 
            // DGToDo
            // 
            this.DGToDo.AllowUserToAddRows = false;
            this.DGToDo.AllowUserToDeleteRows = false;
            this.DGToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGToDo.Location = new System.Drawing.Point(308, 18);
            this.DGToDo.Name = "DGToDo";
            this.DGToDo.ReadOnly = true;
            this.DGToDo.RowTemplate.Height = 24;
            this.DGToDo.Size = new System.Drawing.Size(824, 520);
            this.DGToDo.TabIndex = 8;
            // 
            // btnToDoSetFixDate
            // 
            this.btnToDoSetFixDate.Location = new System.Drawing.Point(24, 325);
            this.btnToDoSetFixDate.Name = "btnToDoSetFixDate";
            this.btnToDoSetFixDate.Size = new System.Drawing.Size(252, 23);
            this.btnToDoSetFixDate.TabIndex = 7;
            this.btnToDoSetFixDate.Text = "Ange datum för åtgärdandet";
            this.btnToDoSetFixDate.UseVisualStyleBackColor = true;
            this.btnToDoSetFixDate.Click += new System.EventHandler(this.btnToDoSetFixDate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 296);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lblToDoFixDate
            // 
            this.lblToDoFixDate.AutoSize = true;
            this.lblToDoFixDate.Location = new System.Drawing.Point(21, 272);
            this.lblToDoFixDate.Name = "lblToDoFixDate";
            this.lblToDoFixDate.Size = new System.Drawing.Size(147, 17);
            this.lblToDoFixDate.TabIndex = 5;
            this.lblToDoFixDate.Text = "Datum för åtgärdande";
            // 
            // btnToDoDelete
            // 
            this.btnToDoDelete.Location = new System.Drawing.Point(24, 150);
            this.btnToDoDelete.Name = "btnToDoDelete";
            this.btnToDoDelete.Size = new System.Drawing.Size(252, 23);
            this.btnToDoDelete.TabIndex = 3;
            this.btnToDoDelete.Text = "Ta bort";
            this.btnToDoDelete.UseVisualStyleBackColor = true;
            this.btnToDoDelete.Click += new System.EventHandler(this.btnToDoDelete_Click);
            // 
            // btnToDoDone
            // 
            this.btnToDoDone.Location = new System.Drawing.Point(24, 105);
            this.btnToDoDone.Name = "btnToDoDone";
            this.btnToDoDone.Size = new System.Drawing.Size(252, 23);
            this.btnToDoDone.TabIndex = 2;
            this.btnToDoDone.Text = "Markera som färdig";
            this.btnToDoDone.UseVisualStyleBackColor = true;
            this.btnToDoDone.Click += new System.EventHandler(this.btnToDoDone_Click);
            // 
            // btnToDoRefresh
            // 
            this.btnToDoRefresh.Location = new System.Drawing.Point(24, 61);
            this.btnToDoRefresh.Name = "btnToDoRefresh";
            this.btnToDoRefresh.Size = new System.Drawing.Size(252, 23);
            this.btnToDoRefresh.TabIndex = 1;
            this.btnToDoRefresh.Text = "Läs in";
            this.btnToDoRefresh.UseVisualStyleBackColor = true;
            this.btnToDoRefresh.Click += new System.EventHandler(this.btnToDoRefresh_Click);
            // 
            // cCaseNr
            // 
            this.cCaseNr.Name = "cCaseNr";
            // 
            // cDate
            // 
            this.cDate.Name = "cDate";
            // 
            // cFixDate
            // 
            this.cFixDate.Name = "cFixDate";
            // 
            // cStatus
            // 
            this.cStatus.Name = "cStatus";
            // 
            // cProblem
            // 
            this.cProblem.Name = "cProblem";
            // 
            // cApt
            // 
            this.cApt.Name = "cApt";
            // 
            // cHouse
            // 
            this.cHouse.Name = "cHouse";
            // 
            // cText
            // 
            this.cText.Name = "cText";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(11, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.CBAdmin);
            this.tabPage5.Controls.Add(this.lblAdmin);
            this.tabPage5.Controls.Add(this.lblGerericInfo);
            this.tabPage5.Controls.Add(this.lblApt);
            this.tabPage5.Controls.Add(this.lblHouse);
            this.tabPage5.Controls.Add(this.lblLastName);
            this.tabPage5.Controls.Add(this.lblName);
            this.tabPage5.Controls.Add(this.lblPassword);
            this.tabPage5.Controls.Add(this.lblUsername);
            this.tabPage5.Controls.Add(this.lblUserMessage);
            this.tabPage5.Controls.Add(this.btnUserRefresh);
            this.tabPage5.Controls.Add(this.dGWNewUser);
            this.tabPage5.Controls.Add(this.lblUserAppartment);
            this.tabPage5.Controls.Add(this.lblUserHouse);
            this.tabPage5.Controls.Add(this.CBUserApt);
            this.tabPage5.Controls.Add(this.CBUserHouse);
            this.tabPage5.Controls.Add(this.btnUserDelete);
            this.tabPage5.Controls.Add(this.btnUserEdit);
            this.tabPage5.Controls.Add(this.btnUserCreate);
            this.tabPage5.Controls.Add(this.txtUserAptLL);
            this.tabPage5.Controls.Add(this.txtUserEmailLL);
            this.tabPage5.Controls.Add(this.txtUserPasswordLL);
            this.tabPage5.Controls.Add(this.txtUserUsernameLL);
            this.tabPage5.Controls.Add(this.lblUserPassword);
            this.tabPage5.Controls.Add(this.lblUserUsername);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(1161, 558);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Användare";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Hyresgästspecifika uppgifter:";
            // 
            // CBAdmin
            // 
            this.CBAdmin.AutoSize = true;
            this.CBAdmin.Location = new System.Drawing.Point(222, 180);
            this.CBAdmin.Name = "CBAdmin";
            this.CBAdmin.Size = new System.Drawing.Size(107, 21);
            this.CBAdmin.TabIndex = 29;
            this.CBAdmin.Text = "Adminstatus";
            this.CBAdmin.UseVisualStyleBackColor = true;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(101, 185);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(51, 17);
            this.lblAdmin.TabIndex = 28;
            this.lblAdmin.Text = "Admin:";
            // 
            // lblGerericInfo
            // 
            this.lblGerericInfo.AutoSize = true;
            this.lblGerericInfo.Location = new System.Drawing.Point(101, 29);
            this.lblGerericInfo.Name = "lblGerericInfo";
            this.lblGerericInfo.Size = new System.Drawing.Size(187, 17);
            this.lblGerericInfo.TabIndex = 27;
            this.lblGerericInfo.Text = "Almänna användaruppgifter:";
            // 
            // lblApt
            // 
            this.lblApt.AutoSize = true;
            this.lblApt.Location = new System.Drawing.Point(98, 260);
            this.lblApt.Name = "lblApt";
            this.lblApt.Size = new System.Drawing.Size(72, 17);
            this.lblApt.TabIndex = 26;
            this.lblApt.Text = "Lägenhet:";
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Location = new System.Drawing.Point(98, 153);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(37, 17);
            this.lblHouse.TabIndex = 25;
            this.lblHouse.Text = "Hus:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(98, 325);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 17);
            this.lblLastName.TabIndex = 24;
            this.lblLastName.Text = "Efternamn:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(98, 294);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Namn:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(101, 105);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 17);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Lösenord:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(101, 72);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(108, 17);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Användarnamn:";
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Location = new System.Drawing.Point(44, 517);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(78, 17);
            this.lblUserMessage.TabIndex = 20;
            this.lblUserMessage.Text = "Status: Kör";
            // 
            // btnUserRefresh
            // 
            this.btnUserRefresh.Location = new System.Drawing.Point(855, 525);
            this.btnUserRefresh.Name = "btnUserRefresh";
            this.btnUserRefresh.Size = new System.Drawing.Size(205, 23);
            this.btnUserRefresh.TabIndex = 19;
            this.btnUserRefresh.Text = "Uppdatera";
            this.btnUserRefresh.UseVisualStyleBackColor = true;
            this.btnUserRefresh.Click += new System.EventHandler(this.btnUserRefresh_Click);
            // 
            // dGWNewUser
            // 
            this.dGWNewUser.AllowUserToAddRows = false;
            this.dGWNewUser.AllowUserToDeleteRows = false;
            this.dGWNewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWNewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Användarnamn,
            this.cPass});
            this.dGWNewUser.Location = new System.Drawing.Point(665, 69);
            this.dGWNewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGWNewUser.Name = "dGWNewUser";
            this.dGWNewUser.ReadOnly = true;
            this.dGWNewUser.RowTemplate.Height = 28;
            this.dGWNewUser.Size = new System.Drawing.Size(395, 444);
            this.dGWNewUser.TabIndex = 18;
            // 
            // Användarnamn
            // 
            this.Användarnamn.HeaderText = "cUsername";
            this.Användarnamn.Name = "Användarnamn";
            this.Användarnamn.Width = 251;
            // 
            // cPass
            // 
            this.cPass.HeaderText = "Lösenord";
            this.cPass.Name = "cPass";
            // 
            // lblUserAppartment
            // 
            this.lblUserAppartment.AutoSize = true;
            this.lblUserAppartment.Location = new System.Drawing.Point(345, 262);
            this.lblUserAppartment.Name = "lblUserAppartment";
            this.lblUserAppartment.Size = new System.Drawing.Size(0, 17);
            this.lblUserAppartment.TabIndex = 15;
            // 
            // lblUserHouse
            // 
            this.lblUserHouse.AutoSize = true;
            this.lblUserHouse.Location = new System.Drawing.Point(345, 248);
            this.lblUserHouse.Name = "lblUserHouse";
            this.lblUserHouse.Size = new System.Drawing.Size(0, 17);
            this.lblUserHouse.TabIndex = 14;
            // 
            // CBUserApt
            // 
            this.CBUserApt.FormattingEnabled = true;
            this.CBUserApt.Location = new System.Drawing.Point(222, 257);
            this.CBUserApt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBUserApt.Name = "CBUserApt";
            this.CBUserApt.Size = new System.Drawing.Size(181, 24);
            this.CBUserApt.TabIndex = 13;
            this.CBUserApt.SelectedIndexChanged += new System.EventHandler(this.CBUserApt_SelectedIndexChanged);
            // 
            // CBUserHouse
            // 
            this.CBUserHouse.FormattingEnabled = true;
            this.CBUserHouse.Location = new System.Drawing.Point(222, 146);
            this.CBUserHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBUserHouse.Name = "CBUserHouse";
            this.CBUserHouse.Size = new System.Drawing.Size(181, 24);
            this.CBUserHouse.TabIndex = 12;
            this.CBUserHouse.SelectedIndexChanged += new System.EventHandler(this.CBUserHouse_SelectedIndexChanged);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(101, 455);
            this.btnUserDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(302, 26);
            this.btnUserDelete.TabIndex = 10;
            this.btnUserDelete.Text = "Ta bort";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click_1);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Location = new System.Drawing.Point(101, 414);
            this.btnUserEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(302, 26);
            this.btnUserEdit.TabIndex = 9;
            this.btnUserEdit.Text = "Ändra";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
            // 
            // btnUserCreate
            // 
            this.btnUserCreate.Location = new System.Drawing.Point(101, 369);
            this.btnUserCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserCreate.Name = "btnUserCreate";
            this.btnUserCreate.Size = new System.Drawing.Size(302, 26);
            this.btnUserCreate.TabIndex = 8;
            this.btnUserCreate.Text = "Skapa";
            this.btnUserCreate.UseVisualStyleBackColor = true;
            this.btnUserCreate.Click += new System.EventHandler(this.btnUserCreate_Click);
            // 
            // txtUserAptLL
            // 
            this.txtUserAptLL.Location = new System.Drawing.Point(222, 325);
            this.txtUserAptLL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserAptLL.Name = "txtUserAptLL";
            this.txtUserAptLL.Size = new System.Drawing.Size(181, 22);
            this.txtUserAptLL.TabIndex = 7;
            // 
            // txtUserEmailLL
            // 
            this.txtUserEmailLL.Location = new System.Drawing.Point(222, 294);
            this.txtUserEmailLL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserEmailLL.Name = "txtUserEmailLL";
            this.txtUserEmailLL.Size = new System.Drawing.Size(181, 22);
            this.txtUserEmailLL.TabIndex = 6;
            // 
            // txtUserPasswordLL
            // 
            this.txtUserPasswordLL.Location = new System.Drawing.Point(222, 105);
            this.txtUserPasswordLL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserPasswordLL.Name = "txtUserPasswordLL";
            this.txtUserPasswordLL.Size = new System.Drawing.Size(181, 22);
            this.txtUserPasswordLL.TabIndex = 5;
            // 
            // txtUserUsernameLL
            // 
            this.txtUserUsernameLL.Location = new System.Drawing.Point(222, 69);
            this.txtUserUsernameLL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserUsernameLL.Name = "txtUserUsernameLL";
            this.txtUserUsernameLL.Size = new System.Drawing.Size(181, 22);
            this.txtUserUsernameLL.TabIndex = 4;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(98, 105);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(0, 17);
            this.lblUserPassword.TabIndex = 1;
            // 
            // lblUserUsername
            // 
            this.lblUserUsername.AutoSize = true;
            this.lblUserUsername.Location = new System.Drawing.Point(98, 69);
            this.lblUserUsername.Name = "lblUserUsername";
            this.lblUserUsername.Size = new System.Drawing.Size(0, 17);
            this.lblUserUsername.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuildBuildingsRefresh);
            this.tabPage1.Controls.Add(this.lblBuildMessage);
            this.tabPage1.Controls.Add(this.btnBuildBuildingDelete);
            this.tabPage1.Controls.Add(this.btnBuildBuildingEdit);
            this.tabPage1.Controls.Add(this.btnBuildBuildingCreate);
            this.tabPage1.Controls.Add(this.txtBuildAdress);
            this.tabPage1.Controls.Add(this.DGBuildBuildings);
            this.tabPage1.Controls.Add(this.lblBuildBuildingTop);
            this.tabPage1.Controls.Add(this.lblBuildApartmentTop);
            this.tabPage1.Controls.Add(this.lblBuildFloor);
            this.tabPage1.Controls.Add(this.lblBuildSize);
            this.tabPage1.Controls.Add(this.lblApartmentNo);
            this.tabPage1.Controls.Add(this.lblBuildApartment);
            this.tabPage1.Controls.Add(this.btnBuildApartmentRefresh);
            this.tabPage1.Controls.Add(this.DGBuildApartments);
            this.tabPage1.Controls.Add(this.btnBuildAptDelete);
            this.tabPage1.Controls.Add(this.btnBuildAptEdit);
            this.tabPage1.Controls.Add(this.btnBuildAptAdd);
            this.tabPage1.Controls.Add(this.NumBuildAptFloor);
            this.tabPage1.Controls.Add(this.NumBuildAptSize);
            this.tabPage1.Controls.Add(this.NumBuildAptNo);
            this.tabPage1.Controls.Add(this.CBBuildBuilding);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1161, 558);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Byggnader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuildBuildingsRefresh
            // 
            this.btnBuildBuildingsRefresh.Location = new System.Drawing.Point(21, 456);
            this.btnBuildBuildingsRefresh.Name = "btnBuildBuildingsRefresh";
            this.btnBuildBuildingsRefresh.Size = new System.Drawing.Size(204, 54);
            this.btnBuildBuildingsRefresh.TabIndex = 22;
            this.btnBuildBuildingsRefresh.Text = "Läs in Byggnader";
            this.btnBuildBuildingsRefresh.UseVisualStyleBackColor = true;
            this.btnBuildBuildingsRefresh.Click += new System.EventHandler(this.btnBuildBuildingsRefresh_Click);
            // 
            // lblBuildMessage
            // 
            this.lblBuildMessage.AutoSize = true;
            this.lblBuildMessage.Location = new System.Drawing.Point(21, 518);
            this.lblBuildMessage.Name = "lblBuildMessage";
            this.lblBuildMessage.Size = new System.Drawing.Size(78, 17);
            this.lblBuildMessage.TabIndex = 21;
            this.lblBuildMessage.Text = "Status: Kör";
            // 
            // btnBuildBuildingDelete
            // 
            this.btnBuildBuildingDelete.Location = new System.Drawing.Point(21, 208);
            this.btnBuildBuildingDelete.Name = "btnBuildBuildingDelete";
            this.btnBuildBuildingDelete.Size = new System.Drawing.Size(204, 23);
            this.btnBuildBuildingDelete.TabIndex = 20;
            this.btnBuildBuildingDelete.Text = "Ta Bort";
            this.btnBuildBuildingDelete.UseVisualStyleBackColor = true;
            this.btnBuildBuildingDelete.Click += new System.EventHandler(this.btnBuildBuildingDelete_Click);
            // 
            // btnBuildBuildingEdit
            // 
            this.btnBuildBuildingEdit.Location = new System.Drawing.Point(21, 164);
            this.btnBuildBuildingEdit.Name = "btnBuildBuildingEdit";
            this.btnBuildBuildingEdit.Size = new System.Drawing.Size(204, 23);
            this.btnBuildBuildingEdit.TabIndex = 19;
            this.btnBuildBuildingEdit.Text = "Ändra";
            this.btnBuildBuildingEdit.UseVisualStyleBackColor = true;
            this.btnBuildBuildingEdit.Click += new System.EventHandler(this.btnBuildBuildingEdit_Click);
            // 
            // btnBuildBuildingCreate
            // 
            this.btnBuildBuildingCreate.Location = new System.Drawing.Point(21, 118);
            this.btnBuildBuildingCreate.Name = "btnBuildBuildingCreate";
            this.btnBuildBuildingCreate.Size = new System.Drawing.Size(204, 23);
            this.btnBuildBuildingCreate.TabIndex = 18;
            this.btnBuildBuildingCreate.Text = "Lägg Till";
            this.btnBuildBuildingCreate.UseVisualStyleBackColor = true;
            this.btnBuildBuildingCreate.Click += new System.EventHandler(this.btnBuildBuildingCreate_Click);
            // 
            // txtBuildAdress
            // 
            this.txtBuildAdress.Location = new System.Drawing.Point(21, 67);
            this.txtBuildAdress.Name = "txtBuildAdress";
            this.txtBuildAdress.Size = new System.Drawing.Size(204, 22);
            this.txtBuildAdress.TabIndex = 17;
            this.txtBuildAdress.Text = "Adress";
            // 
            // DGBuildBuildings
            // 
            this.DGBuildBuildings.AllowUserToAddRows = false;
            this.DGBuildBuildings.AllowUserToDeleteRows = false;
            this.DGBuildBuildings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBuildBuildings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cBuildingNo,
            this.cAddress});
            this.DGBuildBuildings.Location = new System.Drawing.Point(243, 67);
            this.DGBuildBuildings.Name = "DGBuildBuildings";
            this.DGBuildBuildings.ReadOnly = true;
            this.DGBuildBuildings.RowTemplate.Height = 24;
            this.DGBuildBuildings.Size = new System.Drawing.Size(279, 443);
            this.DGBuildBuildings.TabIndex = 16;
            // 
            // cBuildingNo
            // 
            this.cBuildingNo.HeaderText = "ID";
            this.cBuildingNo.Name = "cBuildingNo";
            this.cBuildingNo.Width = 50;
            // 
            // cAddress
            // 
            this.cAddress.HeaderText = "Adress";
            this.cAddress.Name = "cAddress";
            this.cAddress.Width = 200;
            // 
            // lblBuildBuildingTop
            // 
            this.lblBuildBuildingTop.AutoSize = true;
            this.lblBuildBuildingTop.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildBuildingTop.Location = new System.Drawing.Point(15, 13);
            this.lblBuildBuildingTop.Name = "lblBuildBuildingTop";
            this.lblBuildBuildingTop.Size = new System.Drawing.Size(163, 34);
            this.lblBuildBuildingTop.TabIndex = 15;
            this.lblBuildBuildingTop.Text = "Byggnader";
            // 
            // lblBuildApartmentTop
            // 
            this.lblBuildApartmentTop.AutoSize = true;
            this.lblBuildApartmentTop.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildApartmentTop.Location = new System.Drawing.Point(558, 13);
            this.lblBuildApartmentTop.Name = "lblBuildApartmentTop";
            this.lblBuildApartmentTop.Size = new System.Drawing.Size(168, 34);
            this.lblBuildApartmentTop.TabIndex = 14;
            this.lblBuildApartmentTop.Text = "Lägenheter";
            // 
            // lblBuildFloor
            // 
            this.lblBuildFloor.AutoSize = true;
            this.lblBuildFloor.Location = new System.Drawing.Point(564, 210);
            this.lblBuildFloor.Name = "lblBuildFloor";
            this.lblBuildFloor.Size = new System.Drawing.Size(56, 17);
            this.lblBuildFloor.TabIndex = 13;
            this.lblBuildFloor.Text = "Våning:";
            // 
            // lblBuildSize
            // 
            this.lblBuildSize.AutoSize = true;
            this.lblBuildSize.Location = new System.Drawing.Point(561, 168);
            this.lblBuildSize.Name = "lblBuildSize";
            this.lblBuildSize.Size = new System.Drawing.Size(56, 17);
            this.lblBuildSize.TabIndex = 12;
            this.lblBuildSize.Text = "Storlek:";
            // 
            // lblApartmentNo
            // 
            this.lblApartmentNo.AutoSize = true;
            this.lblApartmentNo.Location = new System.Drawing.Point(558, 118);
            this.lblApartmentNo.Name = "lblApartmentNo";
            this.lblApartmentNo.Size = new System.Drawing.Size(98, 17);
            this.lblApartmentNo.TabIndex = 11;
            this.lblApartmentNo.Text = "Lägenhets Nr:";
            // 
            // lblBuildApartment
            // 
            this.lblBuildApartment.AutoSize = true;
            this.lblBuildApartment.Location = new System.Drawing.Point(558, 69);
            this.lblBuildApartment.Name = "lblBuildApartment";
            this.lblBuildApartment.Size = new System.Drawing.Size(68, 17);
            this.lblBuildApartment.TabIndex = 10;
            this.lblBuildApartment.Text = "Byggnad:";
            // 
            // btnBuildApartmentRefresh
            // 
            this.btnBuildApartmentRefresh.Location = new System.Drawing.Point(665, 456);
            this.btnBuildApartmentRefresh.Name = "btnBuildApartmentRefresh";
            this.btnBuildApartmentRefresh.Size = new System.Drawing.Size(162, 54);
            this.btnBuildApartmentRefresh.TabIndex = 9;
            this.btnBuildApartmentRefresh.Text = "Läs in Lägenheter";
            this.btnBuildApartmentRefresh.UseVisualStyleBackColor = true;
            this.btnBuildApartmentRefresh.Click += new System.EventHandler(this.btnBuildApartmentRefresh_Click);
            // 
            // DGBuildApartments
            // 
            this.DGBuildApartments.AllowUserToAddRows = false;
            this.DGBuildApartments.AllowUserToDeleteRows = false;
            this.DGBuildApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBuildApartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAptNo,
            this.cSize,
            this.cFloor});
            this.DGBuildApartments.Location = new System.Drawing.Point(845, 66);
            this.DGBuildApartments.Name = "DGBuildApartments";
            this.DGBuildApartments.ReadOnly = true;
            this.DGBuildApartments.RowTemplate.Height = 24;
            this.DGBuildApartments.Size = new System.Drawing.Size(299, 444);
            this.DGBuildApartments.TabIndex = 8;
            // 
            // cAptNo
            // 
            this.cAptNo.HeaderText = "Lägenhet";
            this.cAptNo.Name = "cAptNo";
            this.cAptNo.ReadOnly = true;
            // 
            // cSize
            // 
            this.cSize.HeaderText = "Storlek";
            this.cSize.Name = "cSize";
            this.cSize.ReadOnly = true;
            this.cSize.Width = 80;
            // 
            // cFloor
            // 
            this.cFloor.HeaderText = "Våning";
            this.cFloor.Name = "cFloor";
            this.cFloor.ReadOnly = true;
            this.cFloor.Width = 80;
            // 
            // btnBuildAptDelete
            // 
            this.btnBuildAptDelete.Location = new System.Drawing.Point(665, 336);
            this.btnBuildAptDelete.Name = "btnBuildAptDelete";
            this.btnBuildAptDelete.Size = new System.Drawing.Size(162, 23);
            this.btnBuildAptDelete.TabIndex = 7;
            this.btnBuildAptDelete.Text = "Ta Bort";
            this.btnBuildAptDelete.UseVisualStyleBackColor = true;
            this.btnBuildAptDelete.Click += new System.EventHandler(this.btnBuildAptDelete_Click);
            // 
            // btnBuildAptEdit
            // 
            this.btnBuildAptEdit.Location = new System.Drawing.Point(665, 297);
            this.btnBuildAptEdit.Name = "btnBuildAptEdit";
            this.btnBuildAptEdit.Size = new System.Drawing.Size(162, 23);
            this.btnBuildAptEdit.TabIndex = 6;
            this.btnBuildAptEdit.Text = "Ändra";
            this.btnBuildAptEdit.UseVisualStyleBackColor = true;
            this.btnBuildAptEdit.Click += new System.EventHandler(this.btnBuildAptEdit_Click);
            // 
            // btnBuildAptAdd
            // 
            this.btnBuildAptAdd.Location = new System.Drawing.Point(665, 257);
            this.btnBuildAptAdd.Name = "btnBuildAptAdd";
            this.btnBuildAptAdd.Size = new System.Drawing.Size(162, 23);
            this.btnBuildAptAdd.TabIndex = 5;
            this.btnBuildAptAdd.Text = "Lägg till";
            this.btnBuildAptAdd.UseVisualStyleBackColor = true;
            this.btnBuildAptAdd.Click += new System.EventHandler(this.btnBuildAptAdd_Click);
            // 
            // NumBuildAptFloor
            // 
            this.NumBuildAptFloor.Location = new System.Drawing.Point(665, 210);
            this.NumBuildAptFloor.Name = "NumBuildAptFloor";
            this.NumBuildAptFloor.Size = new System.Drawing.Size(162, 22);
            this.NumBuildAptFloor.TabIndex = 4;
            // 
            // NumBuildAptSize
            // 
            this.NumBuildAptSize.Location = new System.Drawing.Point(665, 166);
            this.NumBuildAptSize.Name = "NumBuildAptSize";
            this.NumBuildAptSize.Size = new System.Drawing.Size(162, 22);
            this.NumBuildAptSize.TabIndex = 3;
            // 
            // NumBuildAptNo
            // 
            this.NumBuildAptNo.Location = new System.Drawing.Point(665, 118);
            this.NumBuildAptNo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumBuildAptNo.Name = "NumBuildAptNo";
            this.NumBuildAptNo.Size = new System.Drawing.Size(162, 22);
            this.NumBuildAptNo.TabIndex = 2;
            // 
            // CBBuildBuilding
            // 
            this.CBBuildBuilding.FormattingEnabled = true;
            this.CBBuildBuilding.Location = new System.Drawing.Point(665, 66);
            this.CBBuildBuilding.Name = "CBBuildBuilding";
            this.CBBuildBuilding.Size = new System.Drawing.Size(162, 24);
            this.CBBuildBuilding.TabIndex = 0;
            this.CBBuildBuilding.SelectedIndexChanged += new System.EventHandler(this.CBBuildBuilding_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 606);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "HouseIt - Landlord";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGToDo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWNewUser)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBuildBuildings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGBuildApartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBuildAptFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBuildAptSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBuildAptNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabPage2;
        private Button btnToDoDone;
        private Button btnToDoRefresh;
        private TabControl tabControl1;
        private Button btnToDoDelete;
        private DateTimePicker dateTimePicker1;
        private Label lblToDoFixDate;
        private Button btnToDoSetFixDate;
        private DataGridView DGToDo;
        private Label lblToDoMessage;
        private TabPage tabPage5;
        private Button btnUserRefresh;
        private DataGridView dGWNewUser;
        private Label lblUserAppartment;
        private Label lblUserHouse;
        private ComboBox CBUserApt;
        private ComboBox CBUserHouse;
        private Button btnUserDelete;
        private Button btnUserEdit;
        private Button btnUserCreate;
        private TextBox txtUserAptLL;
        private TextBox txtUserEmailLL;
        private TextBox txtUserPasswordLL;
        private TextBox txtUserUsernameLL;
        private Label lblUserPassword;
        private Label lblUserUsername;
        private Label lblLastName;
        private Label lblName;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblUserMessage;
        private Label lblApt;
        private Label lblHouse;
        private Label lblGerericInfo;
        private Label label1;
        private CheckBox CBAdmin;
        private Label lblAdmin;
        private ComboBox CBType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCaseNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFixDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cText;
        private TabPage tabPage1;
        private NumericUpDown NumBuildAptNo;
        private ComboBox CBBuildBuilding;
        private Button btnBuildAptDelete;
        private Button btnBuildAptEdit;
        private Button btnBuildAptAdd;
        private NumericUpDown NumBuildAptFloor;
        private NumericUpDown NumBuildAptSize;
        private Button btnBuildBuildingDelete;
        private Button btnBuildBuildingEdit;
        private Button btnBuildBuildingCreate;
        private TextBox txtBuildAdress;
        private DataGridView DGBuildBuildings;
        private Label lblBuildBuildingTop;
        private Label lblBuildApartmentTop;
        private Label lblBuildFloor;
        private Label lblBuildSize;
        private Label lblApartmentNo;
        private Label lblBuildApartment;
        private Button btnBuildApartmentRefresh;
        private DataGridView DGBuildApartments;
        private Label lblBuildMessage;
        private DataGridViewTextBoxColumn cBuildingNo;
        private DataGridViewTextBoxColumn cAddress;
        private DataGridViewTextBoxColumn cAptNo;
        private DataGridViewTextBoxColumn cSize;
        private DataGridViewTextBoxColumn cFloor;
        private Button btnBuildBuildingsRefresh;
        private DataGridViewTextBoxColumn Användarnamn;
        private DataGridViewTextBoxColumn cPass;
    }
}

