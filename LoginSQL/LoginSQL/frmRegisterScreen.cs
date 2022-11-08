using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSQL
{
    public partial class frmRegisterScreen : Form
    {
        public frmRegisterScreen()
        {
            InitializeComponent();
        }
        private void frmRegisterScreen_Load(object sender, EventArgs e)
        {
            ActiveControl = txtUser;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!(txtUser.Text.Length < 3) && !(txtPassword.Text.Length < 3))
            {
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data source = Negocio.db; Version = 3"))
                    {
                        SQLiteCommand cmd = new SQLiteCommand();
                        conn.Open();

                        int count = 0;
                        string query = $@"SELECT * FROM tblUser WHERE txtUsername = '{txtUser.Text}'";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            count++;
                        }

                        if (count == 1)
                        {
                            MessageBox.Show("The account already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUser.Focus();
                            return;
                        }
                        else if (count == 0)
                        {
                            insertData(txtUser.Text, txtPassword.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                    txtUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("The user name and password must have more than three characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
            }
        }
        private void insertData(string username, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data source = Negocio.db; Version = 3"))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(conn);
                try
                {
                    cmd.CommandText = "INSERT INTO tblUser(txtUsername, txtPassword) VALUES(@username, @password)";

                    cmd.Parameters.Add(new SQLiteParameter("@username", txtUser.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@password", txtPassword.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User created correctly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    frmLoginScreen frmLoginScreen = new frmLoginScreen();
                    frmLoginScreen.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Focus();
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLoginScreen loginscreen = new frmLoginScreen();
            loginscreen.Show();
            this.Hide();
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
                btnRegister_Click(sender, e);
            }
        }
    }
}
