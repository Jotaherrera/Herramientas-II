using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Reader
{
    public partial class frmPDF : Form
    {
        public frmPDF()
        {
            InitializeComponent();
        }

        private void tsrOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF|*.PDF|All files|*.*";
            openFileDialog.DefaultExt = "PDF";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                apdf1.LoadFile(openFileDialog.FileName);
            }
        }
    }
}
