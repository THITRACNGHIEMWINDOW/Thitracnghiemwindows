using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Gametrucxanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int n;
        private void btn_start_Click(object sender, EventArgs e)
        {
            
            n= Int32.Parse( txt_sohinh.Text.ToString());
            ArrayList hinh = new ArrayList();
            int k = 0, j = 0;
            for (int i = 0; i < n*2; i++)
            {
                Button btnhinh = new Button();
                btnhinh.Name = "btn" + i.ToString();
                btnhinh.Width = 150;
                btnhinh.Height = 150;
                btnhinh.Top = 10 + j * 150;
                btnhinh.Left = 10 + k * 150;
                btnhinh.Image = Image.FromFile("Anh/anhnen.png");
                btnhinh.Click += btnhinh_Click;
                if (i < n)
                {
                    int stt = r.Next(0,n);
                    btnhinh.Tag = stt;
                    hinh.Add(stt);
                }
                else
                {
                    int stt = r.Next(0, hinh.Count - 1); // Lấy ngẫu nhiên 1 index trong list.
                    btnhinh.Tag = hinh[stt];//random phần tử có index x trong list.
                    hinh.RemoveAt(stt);
                }
                gbox_trucxanh.Controls.Add(btnhinh);
                k++;
                if (k == 6)
                {
                    k = 0; j++;
                }
            }
        }
        int solanbam = 0;
        string a, b, nut1, nut2;
        void btnhinh_Click(object sender, EventArgs e)
        {
            solanbam++;
            int id = (int)((Button)sender).Tag;
            //MessageBox.Show("Nút số \t" + id.ToString() +((Button)sender).Name.ToString() );
            ((Button)sender).Image = Image.FromFile(id.ToString() + ".jpg");
            ((Button)sender).Enabled = false;
            if (solanbam % 2 != 0)
            {
                a = ((Button)sender).Name.ToString();
                nut1 = ((Button)sender).Tag.ToString();
            }
            else
            {
                b = ((Button)sender).Name.ToString();
                nut2 = ((Button)sender).Tag.ToString();
            }
            if (solanbam % 2 == 0)
            {
                ktrahinh(a,b,nut1,nut2);
            }
        }
        void ktrahinh(string name1, string name2,string tag1,string tag2)
        {
            if (solanbam %2==0)
            {
                foreach (Button btn in gbox_trucxanh.Controls)
                {
                    if (btn.Enabled == false)
                    {
                        System.Threading.Thread.Sleep(500);
                        if (String.Compare(b, a) != 0 && String.Compare(tag1,tag2) == 0)
                        {
                           
                            btn.Visible = false;
                        }
                        else
                        {
                             btn.Image = Image.FromFile("Anh/anhnen.png");
                             btn.Enabled = true;
                           
                        }
                    }
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_design.Text = "Trò chơi được tạo bởi nhóm Windows Nâng cao \n Trần Quang Thoại \n Trịnh Thị Anh \n Đặng Minh Dương";
        }

      
    }
}
