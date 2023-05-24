
namespace Sarfiat.Gui.GuiSuppliers
{
    partial class SuppliersUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonExport = new Button();
            panel1 = new Panel();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            dataGridView1 = new DataGridView();
            comboBoxPageNo = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.Controls.Add(buttonAdd);
            flowLayoutPanel1.Controls.Add(buttonEdit);
            flowLayoutPanel1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Controls.Add(buttonUpdate);
            flowLayoutPanel1.Controls.Add(buttonExport);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(1262, 77);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Image = Properties.Resources.icons8_add_32px;
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(1112, 10);
            buttonAdd.Margin = new Padding(5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(135, 55);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "اضافة";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Image = Properties.Resources.icons8_edit_32px;
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(967, 10);
            buttonEdit.Margin = new Padding(5);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(135, 55);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "تعديل";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = Properties.Resources.icons8_delete_file_32px_2;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(822, 10);
            buttonDelete.Margin = new Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(135, 55);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "حذف";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Image = Properties.Resources.icons8_refresh_32px;
            buttonUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdate.Location = new Point(677, 10);
            buttonUpdate.Margin = new Padding(5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(135, 55);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "تحديث";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonExport
            // 
            buttonExport.Image = Properties.Resources.icons8_export_csv_32px_7;
            buttonExport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExport.Location = new Point(532, 10);
            buttonExport.Margin = new Padding(5);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(135, 55);
            buttonExport.TabIndex = 4;
            buttonExport.Text = "تصدير";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(buttonSearch);
            panel1.Location = new Point(30, 8);
            panel1.Margin = new Padding(3, 3, 5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 57);
            panel1.TabIndex = 5;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Font = new Font("Cairo", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(97, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(395, 57);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextAlign = HorizontalAlignment.Center;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(56, 96, 128);
            buttonSearch.Dock = DockStyle.Left;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Image = Properties.Resources.icons8_search_32px_2;
            buttonSearch.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearch.Location = new Point(0, 0);
            buttonSearch.Margin = new Padding(5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(97, 55);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "   بحث";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1262, 523);
            dataGridView1.TabIndex = 1;
            // 
            // comboBoxPageNo
            // 
            comboBoxPageNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxPageNo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPageNo.FormattingEnabled = true;
            comboBoxPageNo.Location = new Point(6, 548);
            comboBoxPageNo.Name = "comboBoxPageNo";
            comboBoxPageNo.Size = new Size(121, 45);
            comboBoxPageNo.TabIndex = 3;
            comboBoxPageNo.SelectedIndexChanged += comboBoxPageNo_SelectedIndexChanged;
            // 
            // SuppliersUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(comboBoxPageNo);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "SuppliersUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1262, 600);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxPageNo;
    }
}