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
            this.ListBoxItem.Size = new System.Drawing.Size(310, 300);
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
            this.BtnAddToCart.Location = new System.Drawing.Point(392, 282);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(250, 90);
            this.BtnAddToCart.TabIndex = 3;
            this.BtnAddToCart.Text = "Add To Chart";
            this.BtnAddToCart.UseVisualStyleBackColor = true;
            // 
            // ListboxShoppingCart
            // 
            this.ListboxShoppingCart.FormattingEnabled = true;
            this.ListboxShoppingCart.ItemHeight = 37;
            this.ListboxShoppingCart.Location = new System.Drawing.Point(648, 202);
            this.ListboxShoppingCart.Name = "ListboxShoppingCart";
            this.ListboxShoppingCart.Size = new System.Drawing.Size(315, 337);
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
            this.BtnMakePurchase.Location = new System.Drawing.Point(713, 563);
            this.BtnMakePurchase.Name = "BtnMakePurchase";
            this.BtnMakePurchase.Size = new System.Drawing.Size(250, 90);
            this.BtnMakePurchase.TabIndex = 3;
            this.BtnMakePurchase.Text = "Purchase";
            this.BtnMakePurchase.UseVisualStyleBackColor = true;
            // 
            // ConsignmentShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.BtnMakePurchase);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.LabelShoppingCart);
            this.Controls.Add(this.ItemListBoxItems);
            this.Controls.Add(this.ListboxShoppingCart);
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
    }
}

