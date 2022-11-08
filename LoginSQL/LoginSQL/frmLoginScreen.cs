using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace LoginSQL
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            ActiveControl = txtUser;
        }
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAccept_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data source = Negocio.db; Version = 3");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM tblUser WHERE txtUsername = @user AND txtPassword = @pass", conn);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show($"Welcome {txtUser.Text}, you are logged in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Clear();
                    txtPassword.Clear();
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Wrong user name or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Clear();
                    txtPassword.Clear();
                    txtUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegisterScreen frmRegisterScreen = new frmRegisterScreen();
            this.Hide();
            frmRegisterScreen.Show();
        }
    }
}