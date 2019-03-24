namespace Webshop
{
    partial class WebshopForm
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
            this.lConnect = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.ListBox();
            this.lbPrice = new System.Windows.Forms.ListBox();
            this.lbId = new System.Windows.Forms.ListBox();
            this.lStock = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lStoreName = new System.Windows.Forms.Label();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.BtnProductInfo = new System.Windows.Forms.Button();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnShopName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lConnect
            // 
            this.lConnect.AutoSize = true;
            this.lConnect.Location = new System.Drawing.Point(29, 34);
            this.lConnect.Name = "lConnect";
            this.lConnect.Size = new System.Drawing.Size(176, 13);
            this.lConnect.TabIndex = 25;
            this.lConnect.Text = "The number of connected clients is:";
            // 
            // lbStock
            // 
            this.lbStock.Enabled = false;
            this.lbStock.FormattingEnabled = true;
            this.lbStock.Location = new System.Drawing.Point(627, 99);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(120, 186);
            this.lbStock.TabIndex = 24;
            // 
            // lbPrice
            // 
            this.lbPrice.Enabled = false;
            this.lbPrice.FormattingEnabled = true;
            this.lbPrice.Location = new System.Drawing.Point(501, 99);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(120, 186);
            this.lbPrice.TabIndex = 23;
            // 
            // lbId
            // 
            this.lbId.FormattingEnabled = true;
            this.lbId.Location = new System.Drawing.Point(310, 99);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(185, 186);
            this.lbId.TabIndex = 22;
            this.lbId.SelectedIndexChanged += new System.EventHandler(this.LbId_SelectedIndexChanged);
            // 
            // lStock
            // 
            this.lStock.AutoSize = true;
            this.lStock.Location = new System.Drawing.Point(624, 77);
            this.lStock.Name = "lStock";
            this.lStock.Size = new System.Drawing.Size(35, 13);
            this.lStock.TabIndex = 21;
            this.lStock.Text = "Stock";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(498, 77);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(31, 13);
            this.lPrice.TabIndex = 20;
            this.lPrice.Text = "Price";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(307, 77);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(18, 13);
            this.lId.TabIndex = 19;
            this.lId.Text = "ID";
            // 
            // lStoreName
            // 
            this.lStoreName.AutoSize = true;
            this.lStoreName.Location = new System.Drawing.Point(484, 34);
            this.lStoreName.Name = "lStoreName";
            this.lStoreName.Size = new System.Drawing.Size(75, 13);
            this.lStoreName.TabIndex = 18;
            this.lStoreName.Text = "Name of Store";
            // 
            // BtnBuy
            // 
            this.BtnBuy.Location = new System.Drawing.Point(29, 247);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(260, 38);
            this.BtnBuy.TabIndex = 17;
            this.BtnBuy.Text = "Buy Product";
            this.BtnBuy.UseVisualStyleBackColor = true;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // BtnProductInfo
            // 
            this.BtnProductInfo.Location = new System.Drawing.Point(32, 194);
            this.BtnProductInfo.Name = "BtnProductInfo";
            this.BtnProductInfo.Size = new System.Drawing.Size(260, 38);
            this.BtnProductInfo.TabIndex = 16;
            this.BtnProductInfo.Text = "Get Product Info";
            this.BtnProductInfo.UseVisualStyleBackColor = true;
            this.BtnProductInfo.Click += new System.EventHandler(this.BtnProductInfo_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.Location = new System.Drawing.Point(32, 133);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(260, 38);
            this.BtnProducts.TabIndex = 15;
            this.BtnProducts.Text = "Get Product List";
            this.BtnProducts.UseVisualStyleBackColor = true;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnShopName
            // 
            this.BtnShopName.Location = new System.Drawing.Point(32, 77);
            this.BtnShopName.Name = "BtnShopName";
            this.BtnShopName.Size = new System.Drawing.Size(260, 38);
            this.BtnShopName.TabIndex = 14;
            this.BtnShopName.Text = "Get WebShop Name";
            this.BtnShopName.UseVisualStyleBackColor = true;
            this.BtnShopName.Click += new System.EventHandler(this.BtnShopName_Click);
            // 
            // WebshopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 350);
            this.Controls.Add(this.lConnect);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lStock);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.lStoreName);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.BtnProductInfo);
            this.Controls.Add(this.BtnProducts);
            this.Controls.Add(this.BtnShopName);
            this.Name = "WebshopForm";
            this.Text = "Webshop Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebshopForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lConnect;
        private System.Windows.Forms.ListBox lbStock;
        private System.Windows.Forms.ListBox lbPrice;
        private System.Windows.Forms.ListBox lbId;
        private System.Windows.Forms.Label lStock;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lStoreName;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.Button BtnProductInfo;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnShopName;
    }
}

