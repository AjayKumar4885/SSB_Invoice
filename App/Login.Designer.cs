namespace App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblErrorNote = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxUserName = new System.Windows.Forms.TextBox();
            this.jbtnLogin = new FlatButton.JFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrorNote
            // 
            this.lblErrorNote.AutoSize = true;
            this.lblErrorNote.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNote.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblErrorNote.Location = new System.Drawing.Point(31, 219);
            this.lblErrorNote.Name = "lblErrorNote";
            this.lblErrorNote.Size = new System.Drawing.Size(28, 18);
            this.lblErrorNote.TabIndex = 7;
            this.lblErrorNote.Text = "lbl";
            this.lblErrorNote.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 59);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(363, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "SIGN IN";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(19, 94);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(111, 18);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(32, 136);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 18);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password :";
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPassword.Location = new System.Drawing.Point(132, 134);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(229, 27);
            this.txtBxPassword.TabIndex = 4;
            // 
            // txtBxUserName
            // 
            this.txtBxUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUserName.Location = new System.Drawing.Point(132, 92);
            this.txtBxUserName.Name = "txtBxUserName";
            this.txtBxUserName.Size = new System.Drawing.Size(229, 27);
            this.txtBxUserName.TabIndex = 3;
            // 
            // jbtnLogin
            // 
            this.jbtnLogin.BackColor = System.Drawing.Color.Blue;
            this.jbtnLogin.BackgroundColor = System.Drawing.Color.Blue;
            this.jbtnLogin.ButtonText = "Login";
            this.jbtnLogin.CausesValidation = false;
            this.jbtnLogin.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("jbtnLogin.ErrorImageLeft")));
            this.jbtnLogin.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("jbtnLogin.ErrorImageRight")));
            this.jbtnLogin.FocusBackground = System.Drawing.Color.Empty;
            this.jbtnLogin.FocusFontColor = System.Drawing.Color.Empty;
            this.jbtnLogin.ForeColors = System.Drawing.Color.White;
            this.jbtnLogin.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.jbtnLogin.HoverFontColor = System.Drawing.Color.Empty;
            this.jbtnLogin.ImageLeft = ((System.Drawing.Image)(resources.GetObject("jbtnLogin.ImageLeft")));
            this.jbtnLogin.ImageRight = null;
            this.jbtnLogin.LeftPictureColor = System.Drawing.Color.Transparent;
            this.jbtnLogin.Location = new System.Drawing.Point(201, 181);
            this.jbtnLogin.Name = "jbtnLogin";
            this.jbtnLogin.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jbtnLogin.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jbtnLogin.RightPictureColor = System.Drawing.Color.Transparent;
            this.jbtnLogin.Size = new System.Drawing.Size(128, 29);
            this.jbtnLogin.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jbtnLogin.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.jbtnLogin.TabIndex = 9;
            this.jbtnLogin.Click += new System.EventHandler(this.jbtnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 268);
            this.Controls.Add(this.jbtnLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblErrorNote);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblErrorNote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxUserName;
        private FlatButton.JFlatButton jbtnLogin;
    }
}