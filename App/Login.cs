using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Login : Form
    {
        Button btnLoginHide = new Button();
        public Login()
        {
            InitializeComponent();
            btnLoginHide.Click += new EventHandler(btnLoginHide_Click);
        }

        private void btnLoginHide_Click(object sender, EventArgs e)
        {
            LoginValidate();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            txtBxUserName.Text = string.Empty;
            txtBxPassword.Text = string.Empty;
        }

        private bool IsAuthenticated()
        {
            try
            {
                DAL.DAL_Login _Login = new DAL.DAL_Login();
                Users _userobj = _Login.GetUsers(new Models.Users() { UserName = txtBxUserName.Text, Password = txtBxPassword.Text });
                if (_userobj != null && _userobj.UserName != null)
                {

                    lblErrorNote.Visible = false;
                    return true;

                }
                else
                {
                    lblErrorNote.Visible = true;
                    lblErrorNote.Text = _userobj.MessageText;
                    return false;
                }
                // return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jbtnLogin_Click(object sender, EventArgs e)
        {
            LoginValidate();
        }
        private void LoginValidate()
        {
            if (IsAuthenticated())
            {
                this.Hide();
                Home home = new Home();
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLoginHide;
        }
    }
}
