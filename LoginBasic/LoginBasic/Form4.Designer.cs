namespace LoginBasic
{
    partial class Form4
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
            this.usernameDashBoard = new System.Windows.Forms.Label();
            this.userPicBox = new System.Windows.Forms.PictureBox();
            this.userNameDB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.editNameBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.userNameDB);
            this.panel1.Controls.Add(this.usernameDashBoard);
            this.panel1.Controls.Add(this.userPicBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 164);
            this.panel1.TabIndex = 0;
            // 
            // usernameDashBoard
            // 
            this.usernameDashBoard.AutoSize = true;
            this.usernameDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameDashBoard.ForeColor = System.Drawing.Color.Snow;
            this.usernameDashBoard.Location = new System.Drawing.Point(36, 331);
            this.usernameDashBoard.Name = "usernameDashBoard";
            this.usernameDashBoard.Size = new System.Drawing.Size(0, 52);
            this.usernameDashBoard.TabIndex = 1;
            // 
            // userPicBox
            // 
            this.userPicBox.BackColor = System.Drawing.Color.Coral;
            this.userPicBox.Location = new System.Drawing.Point(68, 62);
            this.userPicBox.Name = "userPicBox";
            this.userPicBox.Size = new System.Drawing.Size(262, 291);
            this.userPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicBox.TabIndex = 0;
            this.userPicBox.TabStop = false;
            // 
            // userNameDB
            // 
            this.userNameDB.AutoSize = true;
            this.userNameDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameDB.ForeColor = System.Drawing.Color.Snow;
            this.userNameDB.Location = new System.Drawing.Point(319, 62);
            this.userNameDB.Name = "userNameDB";
            this.userNameDB.Size = new System.Drawing.Size(0, 108);
            this.userNameDB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(131, 251);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(279, 26);
            this.nameBox.TabIndex = 3;
            // 
            // editNameBtn
            // 
            this.editNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editNameBtn.Location = new System.Drawing.Point(422, 247);
            this.editNameBtn.Name = "editNameBtn";
            this.editNameBtn.Size = new System.Drawing.Size(93, 33);
            this.editNameBtn.TabIndex = 4;
            this.editNameBtn.Text = "Edit";
            this.editNameBtn.UseVisualStyleBackColor = true;
            this.editNameBtn.Click += new System.EventHandler(this.editNameBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Coral;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Snow;
            this.saveBtn.Location = new System.Drawing.Point(704, 515);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(420, 145);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 684);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.editNameBtn);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "User Dashboard";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameDashBoard;
        private System.Windows.Forms.PictureBox userPicBox;
        private System.Windows.Forms.Label userNameDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button editNameBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}