using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemWindows
{
    public partial class LoginControls : UserControl
    {
        string pic, id, pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Pic
        {
            get { return pic; }
            set { pic = value; }
        }
        public LoginControls ()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin! \n Please check your ID agian");
                this.txt_id.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_pass.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin! \n Please check your PASSWORD agian");
                this.txt_pass.Focus();
                return;
            }
            if (txt_id.Text == "abc")       //Chỉ những tài khoản đặc biệt mới thay đổi
            {
                if (conn.check_connec() == 0)
                {
                    ChangeCauHinh ch = new ChangeCauHinh();  //Chỉnh lại 
                    ch.Show();
                }
                else
                {
                    ChangeCauHinh ch = new ChangeCauHinh();
                    ch.Show();
                }
            }
            else                        //Áp dụng cho sinh viên
            {
                if (conn.check_connec() == 0)
                {
                    MessageBox.Show("Thanh cong");
                }
                else
                {
                    MessageBox.Show("Vui lòng liên hệ với giám thị hoặc người có chức quyền để được hỗ trợ");
                }
            }
        }

        private void LoginControls_Load(object sender, EventArgs e)
        {
            pic_login.Image = Image.FromFile("Anh/user.png");
            btn_login.Click += btn_login_Click;
        }
    }
}
