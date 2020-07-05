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
            this.dataGrid.AllowUserToAddRows = false;

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

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGrid.Columns[e.ColumnIndex].Name == "update")
            {
                int id = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value);
                Order _order = Program.getApp().getOrderById(id);
                this.Visible = false;
                FormOrderResponse formOrder = new FormOrderResponse(_order);
                formOrder.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void FormOrdersTable_FormClosed(object sender, FormClosedEventArgs e)
        {     
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}
