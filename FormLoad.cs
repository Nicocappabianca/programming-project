using System;
using System.Collections;
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
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            var products = new List<string>() { "Celular", "Televisor", "Computadora", "Tablet", "Monitor" };
            
            orderId.Text = (OrdersRepository.listCount() + 1).ToString();
            entryDate.Text = (DateTime.Now).ToString("dd/MM/yyyy");
   
            foreach (string product in products)
            {
                productType.Items.Add(product);   
            }
            productType.SelectedIndex = 0; 
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(description.Text.Length > 1)
            {
                var id = int.Parse(orderId.Text);
                OrdersRepository.addOrder(id, entryDate.Text, productType.Text, description.Text);

                this.Visible = false;
                FormMain formMain = new FormMain();
                formMain.Show();
            }
        }

        private void FormLoad_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}
