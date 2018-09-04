namespace ThiTracNghiemWindows
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
            this.loginControls1 = new ThiTracNghiemWindows.LoginControls();
            this.SuspendLayout();
            // 
            // loginControls1
            // 
            this.loginControls1.Id = null;
            this.loginControls1.Location = new System.Drawing.Point(12, 19);
            this.loginControls1.Name = "loginControls1";
            this.loginControls1.Pass = null;
            this.loginControls1.Pic = null;
            this.loginControls1.Size = new System.Drawing.Size(500, 250);
            this.loginControls1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 281);
            //this.Controls.Add(this.loginControls1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LoginControls loginControls1;


    }
}

