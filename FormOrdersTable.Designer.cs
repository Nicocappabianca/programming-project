﻿namespace proyecto
{
    partial class FormOrdersTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.date,
            this.prodType,
            this.status,
            this.description,
            this.update});
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(776, 248);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(316, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Volver al inicio";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // orderId
            // 
            this.orderId.DataPropertyName = "orderidname";
            this.orderId.HeaderText = "ID";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            this.orderId.Width = 50;
            // 
            // date
            // 
            this.date.HeaderText = "Fecha";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 80;
            // 
            // prodType
            // 
            this.prodType.HeaderText = "Producto";
            this.prodType.Name = "prodType";
            this.prodType.ReadOnly = true;
            this.prodType.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 150;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Descripción";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // update
            // 
            this.update.HeaderText = "Actualizar";
            this.update.Name = "update";
            this.update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.update.Text = "Actualizar ";
            this.update.UseColumnTextForButtonValue = true;
            // 
            // FormOrdersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGrid);
            this.Name = "FormOrdersTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrdersTable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrdersTable_FormClosed);
            this.Load += new System.EventHandler(this.FormOrdersTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewButtonColumn update;
    }
}