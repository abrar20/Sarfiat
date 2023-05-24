namespace Sarfiat.Gui.GuiSettings
{
    partial class SettingsForm
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
            groupBox1 = new GroupBox();
            buttonSaveGeneralSettings = new Button();
            linkLabelImportImg = new LinkLabel();
            pictureBoxLogo = new PictureBox();
            label4 = new Label();
            numericUpDownDataRow = new NumericUpDown();
            numericUpDownNotification = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            textBoxCompany = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            buttonSaveConString = new Button();
            textBoxPassword = new TextBox();
            label9 = new Label();
            textBoxUserName = new TextBox();
            label8 = new Label();
            numericUpDownTimeout = new NumericUpDown();
            label7 = new Label();
            textBoxDatabase = new TextBox();
            label6 = new Label();
            textBoxServer = new TextBox();
            label5 = new Label();
            radioButtonNetworkCon = new RadioButton();
            radioButtonLocalCon = new RadioButton();
            groupBox3 = new GroupBox();
            buttonRestore = new Button();
            buttonBackUp = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDataRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNotification).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeout).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSaveGeneralSettings);
            groupBox1.Controls.Add(linkLabelImportImg);
            groupBox1.Controls.Add(pictureBoxLogo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDownDataRow);
            groupBox1.Controls.Add(numericUpDownNotification);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxCompany);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 651);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "الإعدادات العامة";
            // 
            // buttonSaveGeneralSettings
            // 
            buttonSaveGeneralSettings.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveGeneralSettings.Image = Properties.Resources.icons8_save_32px_9;
            buttonSaveGeneralSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveGeneralSettings.Location = new Point(22, 565);
            buttonSaveGeneralSettings.Margin = new Padding(5);
            buttonSaveGeneralSettings.Name = "buttonSaveGeneralSettings";
            buttonSaveGeneralSettings.Size = new Size(488, 55);
            buttonSaveGeneralSettings.TabIndex = 10;
            buttonSaveGeneralSettings.Text = "حفظ";
            buttonSaveGeneralSettings.UseVisualStyleBackColor = true;
            buttonSaveGeneralSettings.Click += buttonSaveGeneralSettings_Click;
            // 
            // linkLabelImportImg
            // 
            linkLabelImportImg.AutoSize = true;
            linkLabelImportImg.Location = new Point(246, 439);
            linkLabelImportImg.Name = "linkLabelImportImg";
            linkLabelImportImg.Size = new Size(68, 37);
            linkLabelImportImg.TabIndex = 9;
            linkLabelImportImg.TabStop = true;
            linkLabelImportImg.Text = "تحميل";
            linkLabelImportImg.LinkClicked += linkLabelImportImg_LinkClicked;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.icons8_smart_32px;
            pictureBoxLogo.Location = new Point(196, 297);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(172, 139);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 8;
            pictureBoxLogo.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(229, 253);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 7;
            label4.Text = "شعار المؤسسة";
            // 
            // numericUpDownDataRow
            // 
            numericUpDownDataRow.Location = new Point(22, 188);
            numericUpDownDataRow.Margin = new Padding(8, 20, 8, 20);
            numericUpDownDataRow.Name = "numericUpDownDataRow";
            numericUpDownDataRow.Size = new Size(272, 45);
            numericUpDownDataRow.TabIndex = 6;
            numericUpDownDataRow.TextAlign = HorizontalAlignment.Center;
            numericUpDownDataRow.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // numericUpDownNotification
            // 
            numericUpDownNotification.Location = new Point(22, 125);
            numericUpDownNotification.Margin = new Padding(6, 11, 6, 11);
            numericUpDownNotification.Name = "numericUpDownNotification";
            numericUpDownNotification.Size = new Size(272, 45);
            numericUpDownNotification.TabIndex = 5;
            numericUpDownNotification.TextAlign = HorizontalAlignment.Center;
            numericUpDownNotification.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(361, 201);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 4;
            label3.Text = "عدد البيانات المعروضة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(325, 131);
            label2.Name = "label2";
            label2.Size = new Size(209, 32);
            label2.TabIndex = 2;
            label2.Text = "فترة عرض الإشعارات (ثواني)";
            // 
            // textBoxCompany
            // 
            textBoxCompany.Location = new Point(22, 64);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(272, 45);
            textBoxCompany.TabIndex = 1;
            textBoxCompany.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(410, 64);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 0;
            label1.Text = "اسم المؤسسة";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(568, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(590, 651);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "قواعد البيانات";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonSaveConString);
            groupBox4.Controls.Add(textBoxPassword);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(textBoxUserName);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(numericUpDownTimeout);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(textBoxDatabase);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(textBoxServer);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(radioButtonNetworkCon);
            groupBox4.Controls.Add(radioButtonLocalCon);
            groupBox4.Location = new Point(22, 45);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(544, 461);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "نص الاتصال";
            // 
            // buttonSaveConString
            // 
            buttonSaveConString.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveConString.Image = Properties.Resources.icons8_save_32px_9;
            buttonSaveConString.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveConString.Location = new Point(54, 385);
            buttonSaveConString.Margin = new Padding(5);
            buttonSaveConString.Name = "buttonSaveConString";
            buttonSaveConString.Size = new Size(272, 55);
            buttonSaveConString.TabIndex = 11;
            buttonSaveConString.Text = "حفظ";
            buttonSaveConString.UseVisualStyleBackColor = true;
            buttonSaveConString.Click += buttonSaveConString_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Enabled = false;
            textBoxPassword.Location = new Point(23, 327);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(354, 39);
            textBoxPassword.TabIndex = 18;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(437, 323);
            label9.Name = "label9";
            label9.Size = new Size(84, 32);
            label9.TabIndex = 17;
            label9.Text = "كلمة السر";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Enabled = false;
            textBoxUserName.Location = new Point(23, 269);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(354, 39);
            textBoxUserName.TabIndex = 16;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(411, 272);
            label8.Name = "label8";
            label8.Size = new Size(119, 32);
            label8.TabIndex = 15;
            label8.Text = "اسم المستخدم";
            // 
            // numericUpDownTimeout
            // 
            numericUpDownTimeout.Enabled = false;
            numericUpDownTimeout.Location = new Point(23, 205);
            numericUpDownTimeout.Margin = new Padding(11, 37, 11, 37);
            numericUpDownTimeout.Name = "numericUpDownTimeout";
            numericUpDownTimeout.Size = new Size(354, 39);
            numericUpDownTimeout.TabIndex = 12;
            numericUpDownTimeout.TextAlign = HorizontalAlignment.Center;
            numericUpDownTimeout.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(422, 208);
            label7.Name = "label7";
            label7.Size = new Size(99, 32);
            label7.TabIndex = 11;
            label7.Text = "فترة الإتصال";
            // 
            // textBoxDatabase
            // 
            textBoxDatabase.Location = new Point(23, 142);
            textBoxDatabase.Name = "textBoxDatabase";
            textBoxDatabase.Size = new Size(354, 39);
            textBoxDatabase.TabIndex = 14;
            textBoxDatabase.Text = "Sarfiat";
            textBoxDatabase.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(411, 142);
            label6.Name = "label6";
            label6.Size = new Size(110, 32);
            label6.TabIndex = 13;
            label6.Text = "قاعدة البيانات";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(23, 80);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(354, 39);
            textBoxServer.TabIndex = 12;
            textBoxServer.Text = "(localdb)\\MSSQLLocalDB";
            textBoxServer.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(462, 83);
            label5.Name = "label5";
            label5.Size = new Size(64, 32);
            label5.TabIndex = 11;
            label5.Text = "السيرفر";
            // 
            // radioButtonNetworkCon
            // 
            radioButtonNetworkCon.AutoSize = true;
            radioButtonNetworkCon.Location = new Point(8, 28);
            radioButtonNetworkCon.Name = "radioButtonNetworkCon";
            radioButtonNetworkCon.Size = new Size(80, 36);
            radioButtonNetworkCon.TabIndex = 1;
            radioButtonNetworkCon.Text = "شبكي";
            radioButtonNetworkCon.UseVisualStyleBackColor = true;
            radioButtonNetworkCon.CheckedChanged += radioButtonNetworkCon_CheckedChanged;
            // 
            // radioButtonLocalCon
            // 
            radioButtonLocalCon.AutoSize = true;
            radioButtonLocalCon.Checked = true;
            radioButtonLocalCon.Location = new Point(120, 28);
            radioButtonLocalCon.Name = "radioButtonLocalCon";
            radioButtonLocalCon.Size = new Size(74, 36);
            radioButtonLocalCon.TabIndex = 0;
            radioButtonLocalCon.TabStop = true;
            radioButtonLocalCon.Text = "محلي";
            radioButtonLocalCon.UseVisualStyleBackColor = true;
            radioButtonLocalCon.CheckedChanged += radioButtonLocalCon_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonRestore);
            groupBox3.Controls.Add(buttonBackUp);
            groupBox3.Location = new Point(22, 525);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(562, 111);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "النسخ الإحتياطي والتعيين";
            // 
            // buttonRestore
            // 
            buttonRestore.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRestore.Image = Properties.Resources.icons8_save_32px_9;
            buttonRestore.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRestore.Location = new Point(8, 40);
            buttonRestore.Margin = new Padding(5);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new Size(287, 55);
            buttonRestore.TabIndex = 12;
            buttonRestore.Text = "استعادة النسخة الإحتياطية";
            buttonRestore.UseVisualStyleBackColor = true;
            buttonRestore.Click += buttonRestore_Click;
            // 
            // buttonBackUp
            // 
            buttonBackUp.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBackUp.Image = Properties.Resources.icons8_save_32px_9;
            buttonBackUp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBackUp.Location = new Point(321, 40);
            buttonBackUp.Margin = new Padding(5);
            buttonBackUp.Name = "buttonBackUp";
            buttonBackUp.Size = new Size(223, 55);
            buttonBackUp.TabIndex = 11;
            buttonBackUp.Text = "النسخ الإحتياطي";
            buttonBackUp.UseVisualStyleBackColor = true;
            buttonBackUp.Click += buttonBackUp_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 687);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إعدادات النظام";
            Activated += SettingsForm_Activated;
            FormClosing += SettingsForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDataRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNotification).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeout).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxCompany;
        private Label label1;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDownDataRow;
        private NumericUpDown numericUpDownNotification;
        private LinkLabel linkLabelImportImg;
        private PictureBox pictureBoxLogo;
        private Label label4;
        private Button buttonSaveGeneralSettings;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private RadioButton radioButtonLocalCon;
        private Button buttonRestore;
        private Button buttonBackUp;
        private RadioButton radioButtonNetworkCon;
        private TextBox textBoxDatabase;
        private Label label6;
        private TextBox textBoxServer;
        private Label label5;
        private Button buttonSaveConString;
        private TextBox textBoxPassword;
        private Label label9;
        private TextBox textBoxUserName;
        private Label label8;
        private NumericUpDown numericUpDownTimeout;
        private Label label7;
    }
}