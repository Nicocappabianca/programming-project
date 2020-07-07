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
    public partial class FormRequest : Form
    {
        public FormRequest()
        {
            InitializeComponent();
        }

        private void btnOrderRequest_Click(object sender, EventArgs e)
        {

            int a = 0;
            int.TryParse((inputId.Text),out a);
      
            if ((inputId.Text != "") && (a>0) )
            {
                var id = int.Parse(inputId.Text); 
                Order soughtOrder = Program.getApp().getOrderById(id);
                
                if(soughtOrder != null)
                {
                    this.Visible = false;
                    FormOrderResponse formOrder = new FormOrderResponse(soughtOrder);
                    formOrder.Show();
                }
                else
                {
                    MessageBox.Show(string.Format("Parece que la orden que buscas no existe."), "¡Vaya!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    inputId.Text = "";
                }
            }
       
        }

        private void FormRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
                FormMain formMain = new FormMain();
                formMain.Show();
        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            if (User.isLogged())
                btnAllOrders.Visible = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormOrdersTable tabla = new FormOrdersTable();
            tabla.Show();
        }
    }
}
