using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            FormRequest formRequest = new FormRequest();
            formRequest.Show();
        }

        private void FormOrdersTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormRequest formRequest = new FormRequest();
            formRequest.Show();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            var fbdialog = new FolderBrowserDialog();
            DialogResult result = fbdialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string dir = fbdialog.SelectedPath + "\\Ordenes.xls";

                int fileNumber = 1; 
                while(File.Exists(dir))
                {
                    dir = fbdialog.SelectedPath + "\\Ordenes"+fileNumber+".xls";
                    fileNumber++; 
                } 

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = false;
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Ordenes";
                for (int i = 1; i < dataGrid.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGrid.Rows.Count ; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count -1; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
                
                workbook.SaveAs(dir, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                
                MessageBox.Show("¡Guardado correctamente!");
                app.Quit();
            }
        }
    }
}
