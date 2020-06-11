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
            if(inputId.Text != "")
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
    }
}
