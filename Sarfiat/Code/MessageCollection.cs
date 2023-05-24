using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Sarfiat.Properties;

namespace Sarfiat.Code
{
    public static class MessageCollection
    {
        //Messages
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption,
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public static void ShowErrorServer()
        {
            MessageBox.Show(Resources.ServerErrorText, Resources.ServerErrorCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowFieldsRequird()
        {
            MessageBox.Show(Resources.FieldReqText, Resources.FieldReqCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowRequirdDeleteRow()
        {
            MessageBox.Show(Resources.ShowReqDeleteText, Resources.ShowReqDeleteCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //dialog
        public static bool ShowDeleteDialog()
        {
            var result = MessageBox.Show(Resources.DeleteDialogText, Resources.DeleteDialogCaption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Notifications
        public static void ShowAddNotification()
        {
            Gui.GuiNotification.NotificationForm notificationForm = new Gui.GuiNotification.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية الإضافة بنجاح";
            notificationForm.Show();
        }
        public static void ShowUpdateNotification()
        {
            Gui.GuiNotification.NotificationForm notificationForm = new Gui.GuiNotification.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية التعديل بنجاح";
            notificationForm.Show();
        }
        public static void ShowDeleteNotification()
        {
            Gui.GuiNotification.NotificationForm notificationForm = new Gui.GuiNotification.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية الحذف بنجاح";
            notificationForm.Show();
        }
    }
}
