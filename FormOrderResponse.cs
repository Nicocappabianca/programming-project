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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormOrderResponse_Load(object sender, EventArgs e)
        {
             
        }
    }
}
