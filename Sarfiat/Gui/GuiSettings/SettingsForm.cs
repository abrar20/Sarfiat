using Sarfiat.Data.SqlServer;
using Sarfiat.Gui.GuiLoading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarfiat.Gui.GuiSettings
{
    public partial class SettingsForm : Form
    {
        private LoadingForm loading;
        private readonly bool firstStart;

        public SettingsForm(bool FirstStart)
        {
            InitializeComponent();
            SetGeneralSettings();
            loading = new LoadingForm();
            firstStart = FirstStart;
        }

        private void buttonSaveGeneralSettings_Click(object sender, EventArgs e)
        {
            SaveGeneralSettings();
        }
        private void SaveGeneralSettings()
        {
            Properties.Settings.Default.CompanyName = textBoxCompany.Text;
            Properties.Settings.Default.HideNotification = Convert.ToInt32(numericUpDownNotification.Value);
            Properties.Settings.Default.DataGridViewRowNo = Convert.ToInt32(numericUpDownDataRow.Value);
            //Save picture
            using (MemoryStream ma = new MemoryStream())
            {
                pictureBoxLogo.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.CompanyLogo = Convert.ToBase64String(ma.ToArray());
            }
            // save settings
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الإعدادات بنجاح");
        }
        private void SetGeneralSettings()
        {
            textBoxCompany.Text = Properties.Settings.Default.CompanyName;
            numericUpDownNotification.Value = Convert.ToInt32(Properties.Settings.Default.HideNotification / 1000);
            numericUpDownDataRow.Value = Properties.Settings.Default.DataGridViewRowNo;
            //get picture

            if (Properties.Settings.Default.CompanyLogo != string.Empty)
            {
                var ImageAsByte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);
                using (MemoryStream ma = new MemoryStream(ImageAsByte))
                {
                    pictureBoxLogo.Image = Image.FromStream(ma);
                }

            }
        }

        private void buttonSaveConString_Click(object sender, EventArgs e)
        {
            var server = textBoxServer.Text;
            var Database = textBoxDatabase.Text;
            var timeout = numericUpDownTimeout.Value;
            var UserName = textBoxUserName.Text;
            var Password = textBoxPassword.Text;
            if (radioButtonLocalCon.Checked == true)
            {
                //local connection
                SetLocalCon(server, Database);
            }
            else
            {
                //network connection
                SetNetworkCon(server, Database, UserName, Password, timeout);
            }
            MessageBox.Show("تم حفظ نص الإتصال بنجاح، أعد تشغيل البرنامج.");
            Application.Exit();
        }

        private void SetNetworkCon(string server, string database, string userName, string password, decimal timeout)
        {
            var ConString = @"Server=" + server + ";Database=" + database + ";User Id=" + userName + ";Password=" + password + ";Timeout=" + timeout + "";
            Properties.Settings.Default.SqlServerConnection = ConString;
            // save settings
            Properties.Settings.Default.Save();
        }

        private void SetLocalCon(string server, string database)
        {
            var ConString = @"Server=" + server + ";Database=" + database + ";Trusted_Connection=True";
            Properties.Settings.Default.SqlServerConnection = ConString;
            // save settings
            Properties.Settings.Default.Save();
        }

        private void SettingsForm_Activated(object sender, EventArgs e)
        {
            //did not work 
            /*if (radioButtonNetworkCon.Checked == true)
            {
                textBoxUserName.Enabled = true;
                textBoxPassword.Enabled = true;
                numericUpDownTimeout.Enabled = true;
            }
            else
            {
                textBoxUserName.Enabled = false;
                textBoxPassword.Enabled = false;
                numericUpDownTimeout.Enabled = false;
            }*/
        }

        private void radioButtonLocalCon_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUserName.Enabled = false;
            textBoxPassword.Enabled = false;
            numericUpDownTimeout.Enabled = false;
        }

        private void radioButtonNetworkCon_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUserName.Enabled = true;
            textBoxPassword.Enabled = true;
            numericUpDownTimeout.Enabled = true;
        }

        private void linkLabelImportImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "اختر شعار المؤسسة";
            openFileDialog.RestoreDirectory = true;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxLogo.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private async void buttonBackUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "اختر مسار حفظ النسخة الإحتياطية وتجنب اختيار قرص النظام";
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackUpRestoreHelper backUpRestoreHelper = new BackUpRestoreHelper();
                loading.Show();
                string proccessRsult = await Task.Run(() => backUpRestoreHelper.BackUp(folderBrowserDialog.SelectedPath));
                if (proccessRsult == "1")
                {
                    loading.Hide();
                    MessageBox.Show("تم إنشاء النسخ الإحتياطي بنجاح");
                }
                else
                {
                    loading.Hide();
                    MessageBox.Show(proccessRsult + "لم نتمكن من إجراء عملية النسخ الإحتياطي بسبب");
                }
            }

        }

        private async void buttonRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "اختر ملف النسخة الإحتياطية";
            //save last path
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Bak File|*.bak";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackUpRestoreHelper backUpRestoreHelper = new BackUpRestoreHelper();
                loading.Show();
                string proccessRsult = await Task.Run(() => backUpRestoreHelper.Restore(openFileDialog.FileName));
                if (proccessRsult == "1")
                {
                    loading.Hide();
                    MessageBox.Show("تم إستعادة النسخة الإحتياطية بنجاح");
                }
                else
                {
                    loading.Hide();
                    MessageBox.Show(proccessRsult + "لم نتمكن من إجراء عملية إعادة النسخ الإحتياطي بسبب");
                }
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (firstStart == true)
            {
                MessageBox.Show("أعد تشغيل البرنامج من فضلك");
                Application.Exit();
            }
        }
    }
}
