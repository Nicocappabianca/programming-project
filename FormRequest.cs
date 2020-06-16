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
                Order soughtOrder = OrdersRepository.getOrderById(id);
                
                if(soughtOrder != null)
                {
                    this.Visible = false;
                    FormOrderResponse formOrder = new FormOrderResponse(soughtOrder);
                    formOrder.Show();
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
            FormOrdersTable tabla = new FormOrdersTable();
            tabla.Show();

        }
    }
}
