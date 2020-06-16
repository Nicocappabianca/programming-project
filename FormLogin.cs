using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (User.login(userName.Text, password.Text))
            {
                this.Visible = false;
                FormMain formMain = new FormMain();
                formMain.Show();
            }
            else
            {
                password.Text = "";
                MessageBox.Show("Usuario o contraseña inválido.", "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEnter; 
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}
