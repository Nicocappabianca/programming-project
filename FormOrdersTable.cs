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
    public partial class FormOrdersTable : Form
    {
        public FormOrdersTable()
        {
            InitializeComponent();
        }

        private void FormOrdersTable_Load(object sender, EventArgs e)
        {
            // Carga los elementos de cada Order en una fila del dataGrid.
            for (int i = 1; i <= Program.getApp().listCount(); i++)
            {
                Order orderTemp = Program.getApp().getOrderById(i);

                string[] arr = new string[] { orderTemp.id.ToString(), orderTemp.date, orderTemp.product, orderTemp.status, orderTemp.description };

                dataGrid.Rows.Add(arr);
            }
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
    }
}
