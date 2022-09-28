using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class frmWebBrowser : Form
    {

        public frmWebBrowser()
        {
            InitializeComponent();
            wbPrincipal.Navigate("http://www.google.com");
            txtUrl.Text = "http://www.google.com";
            wbPrincipal.ScriptErrorsSuppressed = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            wbPrincipal.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            wbPrincipal.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            wbPrincipal.Navigate(txtUrl.Text);
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                wbPrincipal.Navigate(txtUrl.Text);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
            {
                wbPrincipal.Refresh();
            }
        }
    }
}
