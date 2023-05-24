namespace Sarfiat.Gui.GuiCategories
{
    partial class AddCategoryForm
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
            label6 = new Label();
            label5 = new Label();
            richTextBoxDetails = new RichTextBox();
            comboBoxType = new ComboBox();
            textBoxBalance = new TextBox();
            textBoxName = new TextBox();
            label4 = new Label();
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
            panel1.Location = new Point(0, 585);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 76);
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
            buttonSaveAndClose.Location = new Point(460, 7);
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
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(textBoxBalance);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 515);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الصنف";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(281, 159);
            label6.Name = "label6";
            label6.Size = new Size(25, 37);
            label6.TabIndex = 4;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(281, 58);
            label5.Name = "label5";
            label5.Size = new Size(25, 37);
            label5.TabIndex = 4;
            label5.Text = "*";
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new Point(21, 301);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new Size(610, 101);
            richTextBoxDetails.TabIndex = 3;
            richTextBoxDetails.Text = "";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "صرف", "قبض" });
            comboBoxType.Location = new Point(21, 199);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(610, 45);
            comboBoxType.TabIndex = 2;
            // 
            // textBoxBalance
            // 
            textBoxBalance.Enabled = false;
            textBoxBalance.Location = new Point(21, 446);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(610, 45);
            textBoxBalance.TabIndex = 1;
            textBoxBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(21, 99);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(610, 45);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 405);
            label4.Name = "label4";
            label4.Size = new Size(67, 37);
            label4.TabIndex = 0;
            label4.Text = "الرصيد";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 261);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 0;
            label3.Text = "التفاصيل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 159);
            label2.Name = "label2";
            label2.Size = new Size(104, 37);
            label2.TabIndex = 0;
            label2.Text = "نوع الصنف";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 58);
            label1.Name = "label1";
            label1.Size = new Size(111, 37);
            label1.TabIndex = 0;
            label1.Text = "اسم الصنف";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 661);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategoryForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إضافة / تعديل صنف";
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
        private ComboBox comboBoxType;
        private TextBox textBoxBalance;
        private TextBox textBoxName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonSave;
        private Button buttonSaveAndClose;
        private Label label5;
        private Label label6;
    }
}