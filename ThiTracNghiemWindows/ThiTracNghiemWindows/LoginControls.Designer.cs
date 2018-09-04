namespace ThiTracNghiemWindows
{
    partial class LoginControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.pic_login = new System.Windows.Forms.PictureBox();
            this.lb_tqt = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_exit.Location = new System.Drawing.Point(336, 138);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(106, 40);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_login.Location = new System.Drawing.Point(188, 138);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(106, 40);
            this.btn_login.TabIndex = 19;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // pic_login
            // 
            this.pic_login.Location = new System.Drawing.Point(26, 28);
            this.pic_login.Name = "pic_login";
            this.pic_login.Size = new System.Drawing.Size(150, 150);
            this.pic_login.TabIndex = 18;
            this.pic_login.TabStop = false;
            // 
            // lb_tqt
            // 
            this.lb_tqt.AutoSize = true;
            this.lb_tqt.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tqt.Location = new System.Drawing.Point(349, 198);
            this.lb_tqt.Name = "lb_tqt";
            this.lb_tqt.Size = new System.Drawing.Size(126, 25);
            this.lb_tqt.TabIndex = 17;
            this.lb_tqt.Text = "Design by TQT";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(254, 80);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(188, 20);
            this.txt_pass.TabIndex = 16;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(254, 28);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(188, 20);
            this.txt_id.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(182, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(182, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // LoginControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pic_login);
            this.Controls.Add(this.lb_tqt);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginControls";
            this.Size = new System.Drawing.Size(500, 250);
            this.Load += new System.EventHandler(this.LoginControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pic_login;
        private System.Windows.Forms.Label lb_tqt;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
