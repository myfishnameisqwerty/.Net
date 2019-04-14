namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    partial class LoginPage
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
            this.pictureFacebookLogin = new System.Windows.Forms.PictureBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFacebookLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureFacebookLogin
            // 
            this.pictureFacebookLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureFacebookLogin.Location = new System.Drawing.Point(28, 22);
            this.pictureFacebookLogin.Name = "pictureFacebookLogin";
            this.pictureFacebookLogin.Size = new System.Drawing.Size(200, 41);
            this.pictureFacebookLogin.TabIndex = 2;
            this.pictureFacebookLogin.TabStop = false;
            this.pictureFacebookLogin.Click += new System.EventHandler(this.pictureBoxFacebookLogin_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Checked = true;
            this.checkBoxRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRememberMe.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(27, 69);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRememberMe.TabIndex = 3;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(255, 95);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.pictureFacebookLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.Text = "my gorgeous work";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFacebookLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureFacebookLogin;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
    }
}