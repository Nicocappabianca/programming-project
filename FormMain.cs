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
        }
    }
}
