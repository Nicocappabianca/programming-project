using System.Windows.Forms;

namespace proyecto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            if (User.isLogged())
            {
                lblUser.Visible = true;
                btnLogin.Visible = false;
                btnLogout.Visible = true; 
            }
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            lblUser.Text = User.getUser();
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            User.logout();
            lblUser.Visible = false;
            btnLogout.Visible = false;
            btnLogin.Visible = true;
        }

        private void btnLoad_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            FormLoad formLoad = new FormLoad();
            formLoad.Show();
        }

        private void btnRequest_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            FormRequest formRequest = new FormRequest();
            formRequest.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicacion?", "CoronApp",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}






