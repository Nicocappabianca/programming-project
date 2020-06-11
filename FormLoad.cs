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
    }
}
