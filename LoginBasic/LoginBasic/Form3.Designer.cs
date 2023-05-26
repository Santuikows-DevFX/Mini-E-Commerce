namespace LoginBasic
{
    partial class UserCart
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
            this.cartDataGrid = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.qntBox = new System.Windows.Forms.TextBox();
            this.decrementQnt = new System.Windows.Forms.Button();
            this.incremenetQnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "CART";
            // 
            // cartDataGrid
            // 
            this.cartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.unitPrice,
            this.Quantity,
            this.TotalPrice});
            this.cartDataGrid.Location = new System.Drawing.Point(31, 64);
            this.cartDataGrid.Name = "cartDataGrid";
            this.cartDataGrid.RowHeadersWidth = 62;
            this.cartDataGrid.RowTemplate.Height = 28;
            this.cartDataGrid.Size = new System.Drawing.Size(1053, 479);
            this.cartDataGrid.TabIndex = 1;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            this.productName.Width = 150;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.MinimumWidth = 8;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = " Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 150;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 8;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 150;
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.BackColor = System.Drawing.Color.Tomato;
            this.checkOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutBtn.ForeColor = System.Drawing.Color.Snow;
            this.checkOutBtn.Location = new System.Drawing.Point(804, 582);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(280, 71);
            this.checkOutBtn.TabIndex = 2;
            this.checkOutBtn.Text = "Proceed to Checkout";
            this.checkOutBtn.UseVisualStyleBackColor = false;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // qntBox
            // 
            this.qntBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qntBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qntBox.Location = new System.Drawing.Point(31, 600);
            this.qntBox.Name = "qntBox";
            this.qntBox.Size = new System.Drawing.Size(218, 35);
            this.qntBox.TabIndex = 3;
            this.qntBox.Text = "1";
            // 
            // decrementQnt
            // 
            this.decrementQnt.BackColor = System.Drawing.Color.Coral;
            this.decrementQnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrementQnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrementQnt.ForeColor = System.Drawing.Color.Snow;
            this.decrementQnt.Location = new System.Drawing.Point(255, 600);
            this.decrementQnt.Name = "decrementQnt";
            this.decrementQnt.Size = new System.Drawing.Size(46, 35);
            this.decrementQnt.TabIndex = 4;
            this.decrementQnt.Text = "-";
            this.decrementQnt.UseVisualStyleBackColor = false;
            this.decrementQnt.Click += new System.EventHandler(this.decrementQnt_Click);
            // 
            // incremenetQnt
            // 
            this.incremenetQnt.BackColor = System.Drawing.Color.Coral;
            this.incremenetQnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incremenetQnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incremenetQnt.ForeColor = System.Drawing.Color.Snow;
            this.incremenetQnt.Location = new System.Drawing.Point(307, 599);
            this.incremenetQnt.Name = "incremenetQnt";
            this.incremenetQnt.Size = new System.Drawing.Size(46, 35);
            this.incremenetQnt.TabIndex = 5;
            this.incremenetQnt.Text = "+";
            this.incremenetQnt.UseVisualStyleBackColor = false;
            this.incremenetQnt.Click += new System.EventHandler(this.incremenetQnt_Click);
            // 
            // UserCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 675);
            this.Controls.Add(this.incremenetQnt);
            this.Controls.Add(this.decrementQnt);
            this.Controls.Add(this.qntBox);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.cartDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "UserCart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.UserCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView cartDataGrid;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.TextBox qntBox;
        private System.Windows.Forms.Button decrementQnt;
        private System.Windows.Forms.Button incremenetQnt;
    }
}