namespace FormTenant
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.DGMyCases = new System.Windows.Forms.DataGridView();
            this.reportCase = new System.Windows.Forms.TabPage();
            this.btnSendWW = new System.Windows.Forms.Button();
            this.textBoxProblemT = new System.Windows.Forms.TextBox();
            this.lblProblem = new System.Windows.Forms.Label();
            this.checkBoxNoAni = new System.Windows.Forms.CheckBox();
            this.checkBoxYesAni = new System.Windows.Forms.CheckBox();
            this.labelAnimals = new System.Windows.Forms.Label();
            this.checkBoxNo = new System.Windows.Forms.CheckBox();
            this.checkBoxYes = new System.Windows.Forms.CheckBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.CBReportWhat = new System.Windows.Forms.ComboBox();
            this.lblWhatsWrong = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblMyMessage = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMyCases)).BeginInit();
            this.reportCase.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblMyMessage);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.DGMyCases);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 556);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Mina Anmälningar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(340, 509);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(295, 41);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Ladda in";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DGMyCases
            // 
            this.DGMyCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMyCases.Location = new System.Drawing.Point(6, 6);
            this.DGMyCases.Name = "DGMyCases";
            this.DGMyCases.RowTemplate.Height = 24;
            this.DGMyCases.Size = new System.Drawing.Size(966, 497);
            this.DGMyCases.TabIndex = 0;
            // 
            // reportCase
            // 
            this.reportCase.Controls.Add(this.btnSendWW);
            this.reportCase.Controls.Add(this.textBoxProblemT);
            this.reportCase.Controls.Add(this.lblProblem);
            this.reportCase.Controls.Add(this.checkBoxNoAni);
            this.reportCase.Controls.Add(this.checkBoxYesAni);
            this.reportCase.Controls.Add(this.labelAnimals);
            this.reportCase.Controls.Add(this.checkBoxNo);
            this.reportCase.Controls.Add(this.checkBoxYes);
            this.reportCase.Controls.Add(this.lblKey);
            this.reportCase.Controls.Add(this.CBReportWhat);
            this.reportCase.Controls.Add(this.lblWhatsWrong);
            this.reportCase.Location = new System.Drawing.Point(4, 25);
            this.reportCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportCase.Name = "reportCase";
            this.reportCase.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportCase.Size = new System.Drawing.Size(978, 556);
            this.reportCase.TabIndex = 2;
            this.reportCase.Text = "Felanmälan";
            this.reportCase.UseVisualStyleBackColor = true;
            // 
            // btnSendWW
            // 
            this.btnSendWW.Location = new System.Drawing.Point(425, 410);
            this.btnSendWW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendWW.Name = "btnSendWW";
            this.btnSendWW.Size = new System.Drawing.Size(123, 27);
            this.btnSendWW.TabIndex = 12;
            this.btnSendWW.Text = "Skicka in";
            this.btnSendWW.UseVisualStyleBackColor = true;
            this.btnSendWW.Click += new System.EventHandler(this.btnSendWW_Click);
            // 
            // textBoxProblemT
            // 
            this.textBoxProblemT.Location = new System.Drawing.Point(324, 297);
            this.textBoxProblemT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProblemT.MaxLength = 120;
            this.textBoxProblemT.Multiline = true;
            this.textBoxProblemT.Name = "textBoxProblemT";
            this.textBoxProblemT.Size = new System.Drawing.Size(331, 97);
            this.textBoxProblemT.TabIndex = 11;
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.Location = new System.Drawing.Point(321, 263);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(252, 17);
            this.lblProblem.TabIndex = 10;
            this.lblProblem.Text = "Beskriv problemet. Max 120 bokstäver.";
            // 
            // checkBoxNoAni
            // 
            this.checkBoxNoAni.AutoSize = true;
            this.checkBoxNoAni.Location = new System.Drawing.Point(589, 222);
            this.checkBoxNoAni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxNoAni.Name = "checkBoxNoAni";
            this.checkBoxNoAni.Size = new System.Drawing.Size(51, 21);
            this.checkBoxNoAni.TabIndex = 9;
            this.checkBoxNoAni.Text = "Nej";
            this.checkBoxNoAni.UseVisualStyleBackColor = true;
            this.checkBoxNoAni.CheckedChanged += new System.EventHandler(this.checkBoxNoAni_CheckedChanged);
            // 
            // checkBoxYesAni
            // 
            this.checkBoxYesAni.AutoSize = true;
            this.checkBoxYesAni.Checked = true;
            this.checkBoxYesAni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxYesAni.Location = new System.Drawing.Point(483, 222);
            this.checkBoxYesAni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxYesAni.Name = "checkBoxYesAni";
            this.checkBoxYesAni.Size = new System.Drawing.Size(45, 21);
            this.checkBoxYesAni.TabIndex = 8;
            this.checkBoxYesAni.Text = "Ja";
            this.checkBoxYesAni.UseVisualStyleBackColor = true;
            this.checkBoxYesAni.CheckedChanged += new System.EventHandler(this.checkBoxYesAni_CheckedChanged);
            // 
            // labelAnimals
            // 
            this.labelAnimals.AutoSize = true;
            this.labelAnimals.Location = new System.Drawing.Point(262, 222);
            this.labelAnimals.Name = "labelAnimals";
            this.labelAnimals.Size = new System.Drawing.Size(151, 17);
            this.labelAnimals.TabIndex = 7;
            this.labelAnimals.Text = "Har du några husdjur?";
            // 
            // checkBoxNo
            // 
            this.checkBoxNo.AutoSize = true;
            this.checkBoxNo.Location = new System.Drawing.Point(589, 184);
            this.checkBoxNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxNo.Name = "checkBoxNo";
            this.checkBoxNo.Size = new System.Drawing.Size(51, 21);
            this.checkBoxNo.TabIndex = 6;
            this.checkBoxNo.Text = "Nej";
            this.checkBoxNo.UseVisualStyleBackColor = true;
            this.checkBoxNo.CheckedChanged += new System.EventHandler(this.checkBoxNo_CheckedChanged);
            // 
            // checkBoxYes
            // 
            this.checkBoxYes.AutoSize = true;
            this.checkBoxYes.Checked = true;
            this.checkBoxYes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxYes.Location = new System.Drawing.Point(483, 185);
            this.checkBoxYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxYes.Name = "checkBoxYes";
            this.checkBoxYes.Size = new System.Drawing.Size(45, 21);
            this.checkBoxYes.TabIndex = 5;
            this.checkBoxYes.Text = "Ja";
            this.checkBoxYes.UseVisualStyleBackColor = true;
            this.checkBoxYes.CheckedChanged += new System.EventHandler(this.checkBoxYes_CheckedChanged);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(186, 185);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(229, 17);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "Kan jag använda min egna nyckel?";
            // 
            // CBReportWhat
            // 
            this.CBReportWhat.FormattingEnabled = true;
            this.CBReportWhat.Items.AddRange(new object[] {
            "Vatten",
            "Avlopp",
            "Värme",
            "El",
            "Övrig skada",
            "Övrigt"});
            this.CBReportWhat.Location = new System.Drawing.Point(483, 142);
            this.CBReportWhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBReportWhat.Name = "CBReportWhat";
            this.CBReportWhat.Size = new System.Drawing.Size(173, 24);
            this.CBReportWhat.TabIndex = 3;
            // 
            // lblWhatsWrong
            // 
            this.lblWhatsWrong.AutoSize = true;
            this.lblWhatsWrong.Location = new System.Drawing.Point(334, 149);
            this.lblWhatsWrong.Name = "lblWhatsWrong";
            this.lblWhatsWrong.Size = new System.Drawing.Size(77, 17);
            this.lblWhatsWrong.TabIndex = 2;
            this.lblWhatsWrong.Text = "Vad är fel?";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.reportCase);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(11, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 585);
            this.tabControl1.TabIndex = 0;
            // 
            // lblMyMessage
            // 
            this.lblMyMessage.AutoSize = true;
            this.lblMyMessage.Location = new System.Drawing.Point(6, 533);
            this.lblMyMessage.Name = "lblMyMessage";
            this.lblMyMessage.Size = new System.Drawing.Size(78, 17);
            this.lblMyMessage.TabIndex = 2;
            this.lblMyMessage.Text = "Status: Kör";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 604);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HouseIt - Tenant";
            this.Text = "HouseIt - Tenant";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMyCases)).EndInit();
            this.reportCase.ResumeLayout(false);
            this.reportCase.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage reportCase;
        private System.Windows.Forms.Button btnSendWW;
        private System.Windows.Forms.TextBox textBoxProblemT;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.CheckBox checkBoxNoAni;
        private System.Windows.Forms.CheckBox checkBoxYesAni;
        private System.Windows.Forms.Label labelAnimals;
        private System.Windows.Forms.CheckBox checkBoxNo;
        private System.Windows.Forms.CheckBox checkBoxYes;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.ComboBox CBReportWhat;
        private System.Windows.Forms.Label lblWhatsWrong;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView DGMyCases;
        private System.Windows.Forms.Label lblMyMessage;
    }
}

