﻿namespace proyecto
{
    partial class FormRequest
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
            this.inputId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.btnOrderRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(77, 31);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(127, 20);
            this.inputId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID pedido";
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.Location = new System.Drawing.Point(77, 113);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(127, 23);
            this.btnAllOrders.TabIndex = 2;
            this.btnAllOrders.Text = "Ver todos";
            this.btnAllOrders.UseVisualStyleBackColor = true;
            this.btnAllOrders.Visible = false;
            // 
            // btnOrderRequest
            // 
            this.btnOrderRequest.Location = new System.Drawing.Point(77, 73);
            this.btnOrderRequest.Name = "btnOrderRequest";
            this.btnOrderRequest.Size = new System.Drawing.Size(127, 34);
            this.btnOrderRequest.TabIndex = 2;
            this.btnOrderRequest.Text = "Consultar";
            this.btnOrderRequest.UseVisualStyleBackColor = true;
            this.btnOrderRequest.Click += new System.EventHandler(this.btnOrderRequest_Click);
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 148);
            this.Controls.Add(this.btnAllOrders);
            this.Controls.Add(this.btnOrderRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputId);
            this.Name = "FormRequest";
            this.Text = "FormConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllOrders;
        private System.Windows.Forms.Button btnOrderRequest;
    }
}