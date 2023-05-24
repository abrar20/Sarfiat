namespace Sarfiat.Gui.GuiProjects
{
    partial class AddProjectsForm
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
            panel1 = new Panel();
            buttonSave = new Button();
            buttonSaveAndClose = new Button();
            groupBox1 = new GroupBox();
            dateTimePickerEndDate = new DateTimePicker();
            dateTimePickerStartDate = new DateTimePicker();
            comboBoxCustomer = new ComboBox();
            label9 = new Label();
            label6 = new Label();
            textBoxCompany = new TextBox();
            label8 = new Label();
            textBoxAddress = new TextBox();
            label7 = new Label();
            label5 = new Label();
            richTextBoxDetails = new RichTextBox();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBoxRevenue = new TextBox();
            label4 = new Label();
            textBoxOutcome = new TextBox();
            textBoxIncome = new TextBox();
            label15 = new Label();
            label16 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 786);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 76);
            panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Image = Properties.Resources.icons8_save_32px_9;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(14, 7);
            buttonSave.Margin = new Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(249, 55);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "حفظ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_32px_7;
            buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new Point(871, 7);
            buttonSaveAndClose.Margin = new Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new Size(249, 55);
            buttonSaveAndClose.TabIndex = 4;
            buttonSaveAndClose.Text = "حفظ وغلق";
            buttonSaveAndClose.UseVisualStyleBackColor = true;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePickerEndDate);
            groupBox1.Controls.Add(dateTimePickerStartDate);
            groupBox1.Controls.Add(comboBoxCustomer);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxCompany);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxAddress);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(602, 724);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المشروع";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(16, 518);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(400, 45);
            dateTimePickerEndDate.TabIndex = 16;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(16, 445);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(400, 45);
            dateTimePickerStartDate.TabIndex = 15;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(16, 161);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(394, 45);
            comboBoxCustomer.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(458, 518);
            label9.Name = "label9";
            label9.Size = new Size(132, 37);
            label9.TabIndex = 12;
            label9.Text = "نهاية المشروع";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 451);
            label6.Name = "label6";
            label6.Size = new Size(129, 37);
            label6.TabIndex = 10;
            label6.Text = "بداية المشروع";
            // 
            // textBoxCompany
            // 
            textBoxCompany.Location = new Point(16, 361);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(396, 45);
            textBoxCompany.TabIndex = 9;
            textBoxCompany.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(443, 361);
            label8.Name = "label8";
            label8.Size = new Size(147, 37);
            label8.TabIndex = 8;
            label8.Text = "الشركة المنفذة";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(16, 260);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(396, 45);
            textBoxAddress.TabIndex = 7;
            textBoxAddress.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(513, 263);
            label7.Name = "label7";
            label7.Size = new Size(77, 37);
            label7.TabIndex = 6;
            label7.Text = "العنوان";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(443, 64);
            label5.Name = "label5";
            label5.Size = new Size(25, 37);
            label5.TabIndex = 4;
            label5.Text = "*";
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new Point(20, 600);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new Size(396, 101);
            richTextBoxDetails.TabIndex = 3;
            richTextBoxDetails.Text = "";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(16, 61);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(396, 45);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 627);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 0;
            label3.Text = "التفاصيل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(515, 164);
            label2.Name = "label2";
            label2.Size = new Size(75, 37);
            label2.TabIndex = 0;
            label2.Text = "العميل";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(459, 64);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 0;
            label1.Text = "اسم االمشروع";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxRevenue);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxOutcome);
            groupBox2.Controls.Add(textBoxIncome);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Location = new Point(658, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 580);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "ملخص الأموال";
            // 
            // textBoxRevenue
            // 
            textBoxRevenue.Enabled = false;
            textBoxRevenue.Location = new Point(35, 360);
            textBoxRevenue.Name = "textBoxRevenue";
            textBoxRevenue.Size = new Size(396, 45);
            textBoxRevenue.TabIndex = 7;
            textBoxRevenue.Text = "0";
            textBoxRevenue.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 307);
            label4.Name = "label4";
            label4.Size = new Size(63, 37);
            label4.TabIndex = 6;
            label4.Text = "الأرباح";
            // 
            // textBoxOutcome
            // 
            textBoxOutcome.Enabled = false;
            textBoxOutcome.Location = new Point(35, 238);
            textBoxOutcome.Name = "textBoxOutcome";
            textBoxOutcome.Size = new Size(396, 45);
            textBoxOutcome.TabIndex = 5;
            textBoxOutcome.Text = "0";
            textBoxOutcome.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxIncome
            // 
            textBoxIncome.Enabled = false;
            textBoxIncome.Location = new Point(35, 119);
            textBoxIncome.Name = "textBoxIncome";
            textBoxIncome.Size = new Size(396, 45);
            textBoxIncome.TabIndex = 1;
            textBoxIncome.Text = "0";
            textBoxIncome.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(186, 184);
            label15.Name = "label15";
            label15.Size = new Size(109, 37);
            label15.TabIndex = 0;
            label15.Text = "المصروفات";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(186, 63);
            label16.Name = "label16";
            label16.Size = new Size(111, 37);
            label16.TabIndex = 0;
            label16.Text = "المقبوضات";
            // 
            // AddProjectsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 862);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProjectsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إضافة / تعديل مشروع";
            TopMost = true;
            Load += AddCategoryForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxDetails;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonSave;
        private Button buttonSaveAndClose;
        private Label label5;
        private TextBox textBoxCompany;
        private Label label8;
        private TextBox textBoxAddress;
        private Label label7;
        private Label label9;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox textBoxRevenue;
        private Label label4;
        private TextBox textBoxOutcome;
        private TextBox textBoxIncome;
        private Label label15;
        private Label label16;
        private DateTimePicker dateTimePickerEndDate;
        private DateTimePicker dateTimePickerStartDate;
        private ComboBox comboBoxCustomer;
    }
}