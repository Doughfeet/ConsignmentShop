namespace ConsignmentShop
{
    partial class ConsignmentShopUI
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
            this.headerText = new System.Windows.Forms.Label();
            this.ListBoxItem = new System.Windows.Forms.ListBox();
            this.ItemListBoxItems = new System.Windows.Forms.Label();
            this.BtnAddToCart = new System.Windows.Forms.Button();
            this.ListboxShoppingCart = new System.Windows.Forms.ListBox();
            this.LabelShoppingCart = new System.Windows.Forms.Label();
            this.BtnMakePurchase = new System.Windows.Forms.Button();
            this.ListBoxVendor = new System.Windows.Forms.ListBox();
            this.VendorListBoxLabel = new System.Windows.Forms.Label();
            this.StoreProfitLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(37, 36);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(825, 73);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignement Shop Demo";
            // 
            // ListBoxItem
            // 
            this.ListBoxItem.FormattingEnabled = true;
            this.ListBoxItem.ItemHeight = 37;
            this.ListBoxItem.Location = new System.Drawing.Point(50, 202);
            this.ListBoxItem.Name = "ListBoxItem";
            this.ListBoxItem.Size = new System.Drawing.Size(310, 263);
            this.ListBoxItem.TabIndex = 1;
            // 
            // ItemListBoxItems
            // 
            this.ItemListBoxItems.AutoSize = true;
            this.ItemListBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListBoxItems.Location = new System.Drawing.Point(50, 162);
            this.ItemListBoxItems.Name = "ItemListBoxItems";
            this.ItemListBoxItems.Size = new System.Drawing.Size(190, 37);
            this.ItemListBoxItems.TabIndex = 2;
            this.ItemListBoxItems.Text = "Store Items";
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.Location = new System.Drawing.Point(378, 284);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(250, 90);
            this.BtnAddToCart.TabIndex = 3;
            this.BtnAddToCart.Text = "Add To Chart";
            this.BtnAddToCart.UseVisualStyleBackColor = true;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // ListboxShoppingCart
            // 
            this.ListboxShoppingCart.FormattingEnabled = true;
            this.ListboxShoppingCart.ItemHeight = 37;
            this.ListboxShoppingCart.Location = new System.Drawing.Point(648, 202);
            this.ListboxShoppingCart.Name = "ListboxShoppingCart";
            this.ListboxShoppingCart.Size = new System.Drawing.Size(315, 263);
            this.ListboxShoppingCart.TabIndex = 1;
            // 
            // LabelShoppingCart
            // 
            this.LabelShoppingCart.AutoSize = true;
            this.LabelShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShoppingCart.Location = new System.Drawing.Point(641, 162);
            this.LabelShoppingCart.Name = "LabelShoppingCart";
            this.LabelShoppingCart.Size = new System.Drawing.Size(236, 37);
            this.LabelShoppingCart.TabIndex = 2;
            this.LabelShoppingCart.Text = "Shopping Cart";
            // 
            // BtnMakePurchase
            // 
            this.BtnMakePurchase.Location = new System.Drawing.Point(713, 494);
            this.BtnMakePurchase.Name = "BtnMakePurchase";
            this.BtnMakePurchase.Size = new System.Drawing.Size(250, 90);
            this.BtnMakePurchase.TabIndex = 3;
            this.BtnMakePurchase.Text = "Purchase";
            this.BtnMakePurchase.UseVisualStyleBackColor = true;
            this.BtnMakePurchase.Click += new System.EventHandler(this.BtnMakePurchase_Click);
            // 
            // ListBoxVendor
            // 
            this.ListBoxVendor.FormattingEnabled = true;
            this.ListBoxVendor.ItemHeight = 37;
            this.ListBoxVendor.Location = new System.Drawing.Point(50, 688);
            this.ListBoxVendor.Name = "ListBoxVendor";
            this.ListBoxVendor.Size = new System.Drawing.Size(310, 263);
            this.ListBoxVendor.TabIndex = 1;
            // 
            // VendorListBoxLabel
            // 
            this.VendorListBoxLabel.AutoSize = true;
            this.VendorListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorListBoxLabel.Location = new System.Drawing.Point(50, 648);
            this.VendorListBoxLabel.Name = "VendorListBoxLabel";
            this.VendorListBoxLabel.Size = new System.Drawing.Size(144, 37);
            this.VendorListBoxLabel.TabIndex = 2;
            this.VendorListBoxLabel.Text = "Vendors";
            // 
            // StoreProfitLabel
            // 
            this.StoreProfitLabel.AutoSize = true;
            this.StoreProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreProfitLabel.Location = new System.Drawing.Point(863, 671);
            this.StoreProfitLabel.Name = "StoreProfitLabel";
            this.StoreProfitLabel.Size = new System.Drawing.Size(103, 37);
            this.StoreProfitLabel.TabIndex = 2;
            this.StoreProfitLabel.Text = "$0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 671);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Store profit";
            // 
            // ConsignmentShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 1164);
            this.Controls.Add(this.BtnMakePurchase);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.LabelShoppingCart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StoreProfitLabel);
            this.Controls.Add(this.VendorListBoxLabel);
            this.Controls.Add(this.ItemListBoxItems);
            this.Controls.Add(this.ListboxShoppingCart);
            this.Controls.Add(this.ListBoxVendor);
            this.Controls.Add(this.ListBoxItem);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConsignmentShopUI";
            this.Text = "Consignment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox ListBoxItem;
        private System.Windows.Forms.Label ItemListBoxItems;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.ListBox ListboxShoppingCart;
        private System.Windows.Forms.Label LabelShoppingCart;
        private System.Windows.Forms.Button BtnMakePurchase;
        private System.Windows.Forms.ListBox ListBoxVendor;
        private System.Windows.Forms.Label VendorListBoxLabel;
        private System.Windows.Forms.Label StoreProfitLabel;
        private System.Windows.Forms.Label label2;
    }
}

