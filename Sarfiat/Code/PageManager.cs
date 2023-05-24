using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarfiat.Code
{
    public class PageManager
    {
        private readonly Main main;

        public PageManager(Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageUserControl)
        {
            // load old page
            var oldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            // if the page not when start the program
            if (oldPage != null)
            {
                main.panelContainer.Controls.Remove(oldPage);// remove old page
                oldPage.Dispose();
            }
            //load new page
            PageUserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(PageUserControl);
        }
    }
}
