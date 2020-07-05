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
    public partial class FormOrderResponse : Form
    {
        public FormOrderResponse()
        {
            InitializeComponent(); 
        }

        public FormOrderResponse(Order order)
        {
            InitializeComponent();
            orderId.Text = (order.id).ToString();
            entryDate.Text = (order.date).ToString();
            productType.Text = (order.product).ToString();
            description.Text = (order.description).ToString();
            status.Text = (order.status).ToString(); 
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Visible = false;
                FormRequest formReq = new FormRequest();
                formReq.Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FormOrderResponse_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void FormOrderResponse_Load(object sender, EventArgs e)
        {
            if (User.isLogged())
            {
                btnBack.Visible = true;
                btnSave.Visible = true;
                btnExit.Visible = false;
                status.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.getApp().updateOrder(status.Text, Int32.Parse(orderId.Text));
            MessageBox.Show(string.Format("Se modifico el estado. \nPedido #{0} a {1}", orderId.Text, status.Text), "Cambio de estado", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
