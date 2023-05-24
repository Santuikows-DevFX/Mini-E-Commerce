namespace LoginBasic
{
    partial class UserInterface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.productPicBox = new System.Windows.Forms.PictureBox();
            this.addCartBtn = new System.Windows.Forms.Button();
            this.productName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewCart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.viewCart);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 100);
            this.panel1.TabIndex = 0;
            // 
            // productPicBox
            // 
            this.productPicBox.Location = new System.Drawing.Point(29, 125);
            this.productPicBox.Name = "productPicBox";
            this.productPicBox.Size = new System.Drawing.Size(430, 629);
            this.productPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.productPicBox.TabIndex = 1;
            this.productPicBox.TabStop = false;
            // 
            // addCartBtn
            // 
            this.addCartBtn.BackColor = System.Drawing.Color.Tomato;
            this.addCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCartBtn.ForeColor = System.Drawing.Color.Snow;
            this.addCartBtn.Location = new System.Drawing.Point(563, 660);
            this.addCartBtn.Name = "addCartBtn";
            this.addCartBtn.Size = new System.Drawing.Size(484, 78);
            this.addCartBtn.TabIndex = 2;
            this.addCartBtn.Text = "Add to Cart";
            this.addCartBtn.UseVisualStyleBackColor = false;
            this.addCartBtn.Click += new System.EventHandler(this.addCartBtn_Click);
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(465, 137);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(290, 46);
            this.productName.TabIndex = 3;
            this.productName.Text = "AGOY PANTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "This is an item description";
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSize = true;
            this.unitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.unitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.unitPrice.Location = new System.Drawing.Point(526, 197);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(89, 46);
            this.unitPrice.TabIndex = 5;
            this.unitPrice.Text = "450";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(484, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "P";
            // 
            // viewCart
            // 
            this.viewCart.BackColor = System.Drawing.Color.Tomato;
            this.viewCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCart.ForeColor = System.Drawing.Color.Snow;
            this.viewCart.Location = new System.Drawing.Point(946, 22);
            this.viewCart.Name = "viewCart";
            this.viewCart.Size = new System.Drawing.Size(185, 62);
            this.viewCart.TabIndex = 7;
            this.viewCart.Text = "View Cart";
            this.viewCart.UseVisualStyleBackColor = false;
            this.viewCart.Click += new System.EventHandler(this.viewCart_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1153, 809);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.addCartBtn);
            this.Controls.Add(this.productPicBox);
            this.Controls.Add(this.panel1);
            this.Name = "UserInterface";
            this.Text = "WANIFY";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox productPicBox;
        private System.Windows.Forms.Button addCartBtn;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label unitPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewCart;
    }
}