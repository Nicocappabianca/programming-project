namespace proyecto
{
    partial class FormOrderResponse
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
            this.label1 = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.TextBox();
            this.entryDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pedido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // orderId
            // 
            this.orderId.Location = new System.Drawing.Point(33, 45);
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            this.orderId.Size = new System.Drawing.Size(187, 20);
            this.orderId.TabIndex = 1;
            // 
            // entryDate
            // 
            this.entryDate.Location = new System.Drawing.Point(33, 96);
            this.entryDate.Name = "entryDate";
            this.entryDate.ReadOnly = true;
            this.entryDate.Size = new System.Drawing.Size(187, 20);
            this.entryDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de ingreso";
            // 
            // productType
            // 
            this.productType.Location = new System.Drawing.Point(33, 144);
            this.productType.Name = "productType";
            this.productType.ReadOnly = true;
            this.productType.Size = new System.Drawing.Size(187, 20);
            this.productType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de producto";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(33, 192);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(288, 102);
            this.description.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción de problema";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado del pedido";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(78, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Volver al inicio";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar cambios";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(183, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 40);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Volver al inicio";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(33, 323);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(187, 20);
            this.status.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // FormOrderResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.description);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entryDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.label1);
            this.Name = "FormOrderResponse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrderResponse";
            this.Load += new System.EventHandler(this.FormOrderResponse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.TextBox entryDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button button1;
    }
}