namespace Vehicle_Rental_System
{
    partial class Login
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtboxUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtboxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 111);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(104, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "User Name";
            // 
            // txtboxUserName
            // 
            this.txtboxUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxUserName.Depth = 0;
            this.txtboxUserName.Hint = "";
            this.txtboxUserName.Location = new System.Drawing.Point(181, 111);
            this.txtboxUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxUserName.Name = "txtboxUserName";
            this.txtboxUserName.PasswordChar = '\0';
            this.txtboxUserName.SelectedText = "";
            this.txtboxUserName.SelectionLength = 0;
            this.txtboxUserName.SelectionStart = 0;
            this.txtboxUserName.Size = new System.Drawing.Size(139, 28);
            this.txtboxUserName.TabIndex = 1;
            this.txtboxUserName.UseSystemPasswordChar = false;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Depth = 0;
            this.txtboxPassword.Hint = "";
            this.txtboxPassword.Location = new System.Drawing.Point(181, 173);
            this.txtboxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.SelectedText = "";
            this.txtboxPassword.SelectionLength = 0;
            this.txtboxPassword.SelectionStart = 0;
            this.txtboxPassword.Size = new System.Drawing.Size(139, 28);
            this.txtboxPassword.TabIndex = 2;
            this.txtboxPassword.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(181, 243);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(122, 32);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Login";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 173);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 24);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 444);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUserName);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxPassword;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}