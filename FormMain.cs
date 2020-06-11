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
            lblUser.Text = User.estado();
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
    }
}




