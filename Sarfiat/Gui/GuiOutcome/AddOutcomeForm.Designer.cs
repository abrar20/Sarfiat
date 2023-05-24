namespace Sarfiat.Gui.GuiOutcome
{
    partial class AddOutcomeForm
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
            linkLabelNewSupplier = new LinkLabel();
            linkLabelNewCategory = new LinkLabel();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            comboBoxCategory = new ComboBox();
            label8 = new Label();
            textBoxAmount = new TextBox();
            label7 = new Label();
            textBoxRecNo = new TextBox();
            dateTimePickerDate = new DateTimePicker();
            comboBoxSupplier = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            richTextBoxDetails = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 638);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 76);
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
            buttonSave.TabIndex = 7;
            buttonSave.Text = "حفظ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_32px_7;
            buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new Point(383, 7);
            buttonSaveAndClose.Margin = new Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new Size(249, 55);
            buttonSaveAndClose.TabIndex = 6;
            buttonSaveAndClose.Text = "حفظ وغلق";
            buttonSaveAndClose.UseVisualStyleBackColor = true;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabelNewSupplier);
            groupBox1.Controls.Add(linkLabelNewCategory);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxCategory);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxAmount);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBoxRecNo);
            groupBox1.Controls.Add(dateTimePickerDate);
            groupBox1.Controls.Add(comboBoxSupplier);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(602, 583);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الصرف";
            // 
            // linkLabelNewSupplier
            // 
            linkLabelNewSupplier.AutoSize = true;
            linkLabelNewSupplier.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelNewSupplier.Location = new Point(439, 155);
            linkLabelNewSupplier.Name = "linkLabelNewSupplier";
            linkLabelNewSupplier.Size = new Size(46, 32);
            linkLabelNewSupplier.TabIndex = 25;
            linkLabelNewSupplier.TabStop = true;
            linkLabelNewSupplier.Text = "جديد";
            linkLabelNewSupplier.LinkClicked += linkLabelNewSupplier_LinkClicked;
            // 
            // linkLabelNewCategory
            // 
            linkLabelNewCategory.AutoSize = true;
            linkLabelNewCategory.Font = new Font("Cairo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelNewCategory.Location = new Point(439, 68);
            linkLabelNewCategory.Name = "linkLabelNewCategory";
            linkLabelNewCategory.Size = new Size(46, 32);
            linkLabelNewCategory.TabIndex = 24;
            linkLabelNewCategory.TabStop = true;
            linkLabelNewCategory.Text = "جديد";
            linkLabelNewCategory.LinkClicked += linkLabelNewCategory_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(491, 376);
            label10.Name = "label10";
            label10.Size = new Size(25, 37);
            label10.TabIndex = 22;
            label10.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(450, 222);
            label9.Name = "label9";
            label9.Size = new Size(25, 37);
            label9.TabIndex = 21;
            label9.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(491, 147);
            label4.Name = "label4";
            label4.Size = new Size(25, 37);
            label4.TabIndex = 20;
            label4.Text = "*";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(16, 64);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(394, 45);
            comboBoxCategory.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(513, 385);
            label8.Name = "label8";
            label8.Size = new Size(67, 37);
            label8.TabIndex = 18;
            label8.Text = "المبلغ";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(20, 385);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(396, 45);
            textBoxAmount.TabIndex = 4;
            textBoxAmount.Text = "0";
            textBoxAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(476, 307);
            label7.Name = "label7";
            label7.Size = new Size(104, 37);
            label7.TabIndex = 16;
            label7.Text = "رقم الوصل";
            // 
            // textBoxRecNo
            // 
            textBoxRecNo.Location = new Point(20, 307);
            textBoxRecNo.Name = "textBoxRecNo";
            textBoxRecNo.Size = new Size(396, 45);
            textBoxRecNo.TabIndex = 3;
            textBoxRecNo.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(16, 233);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(400, 45);
            dateTimePickerDate.TabIndex = 2;
            // 
            // comboBoxSupplier
            // 
            comboBoxSupplier.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxSupplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Location = new Point(16, 147);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new Size(394, 45);
            comboBoxSupplier.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 233);
            label6.Name = "label6";
            label6.Size = new Size(111, 37);
            label6.TabIndex = 10;
            label6.Text = "تاريخ الصرف";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(502, 55);
            label5.Name = "label5";
            label5.Size = new Size(25, 37);
            label5.TabIndex = 4;
            label5.Text = "*";
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new Point(20, 472);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new Size(396, 101);
            richTextBoxDetails.TabIndex = 5;
            richTextBoxDetails.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 504);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 0;
            label3.Text = "التفاصيل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 150);
            label2.Name = "label2";
            label2.Size = new Size(73, 37);
            label2.TabIndex = 0;
            label2.Text = "المورد ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(520, 64);
            label1.Name = "label1";
            label1.Size = new Size(60, 37);
            label1.TabIndex = 0;
            label1.Text = "صنف";
            // 
            // AddOutcomeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 714);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddOutcomeForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إضافة / تعديل صرف";
            TopMost = true;
            Load += AddCategoryForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxDetails;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonSave;
        private Button buttonSaveAndClose;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePickerDate;
        private ComboBox comboBoxSupplier;
        private ComboBox comboBoxCategory;
        private Label label8;
        private TextBox textBoxAmount;
        private Label label7;
        private TextBox textBoxRecNo;
        private Label label10;
        private Label label9;
        private Label label4;
        private LinkLabel linkLabelNewSupplier;
        private LinkLabel linkLabelNewCategory;
    }
}