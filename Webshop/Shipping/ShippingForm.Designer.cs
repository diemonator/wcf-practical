namespace Shipping
{
    partial class ShippingForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnShowOrder = new System.Windows.Forms.Button();
            this.lbDateTime = new System.Windows.Forms.ListBox();
            this.lbOrderId = new System.Windows.Forms.ListBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(21, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 70);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Shipping Log";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ProductId - Time Bought";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 58);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(303, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 58);
            this.panel2.TabIndex = 12;
            // 
            // BtnShowOrder
            // 
            this.BtnShowOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowOrder.Location = new System.Drawing.Point(21, 505);
            this.BtnShowOrder.Name = "BtnShowOrder";
            this.BtnShowOrder.Size = new System.Drawing.Size(555, 61);
            this.BtnShowOrder.TabIndex = 10;
            this.BtnShowOrder.Text = "Show Orders";
            this.BtnShowOrder.UseVisualStyleBackColor = true;
            this.BtnShowOrder.Click += new System.EventHandler(this.BtnShowOrder_Click);
            // 
            // lbDateTime
            // 
            this.lbDateTime.FormattingEnabled = true;
            this.lbDateTime.Location = new System.Drawing.Point(303, 157);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(273, 342);
            this.lbDateTime.TabIndex = 9;
            // 
            // lbOrderId
            // 
            this.lbOrderId.FormattingEnabled = true;
            this.lbOrderId.Location = new System.Drawing.Point(21, 157);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(273, 342);
            this.lbOrderId.TabIndex = 8;
            // 
            // ShippingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 590);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnShowOrder);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.lbOrderId);
            this.Name = "ShippingForm";
            this.Text = "Shipping Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShippingForm_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnShowOrder;
        private System.Windows.Forms.ListBox lbDateTime;
        private System.Windows.Forms.ListBox lbOrderId;
    }
}

