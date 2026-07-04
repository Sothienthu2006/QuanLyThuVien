using QuanLyDocGia1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FormMuonTra f = new FormMuonTra();
            f.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            QuanLySach.qls f = new QuanLySach.qls();
            f.Show();
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            QuanLyDocGia1.FormDocGia f = new QuanLyDocGia1.FormDocGia();
            f.Show();
        }

        private void btnTag_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // 1. Hiện một bảng thông báo xác nhận cho chắc chắn
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Khởi tạo lại Form Đăng nhập (Thay 'Form1' bằng tên Form đăng nhập thật của bạn)
                Form1 loginForm = new Form1();
                loginForm.Show();

                // 3. Đóng Form hiện tại (Form chính)
                this.Close();
            }
        }
    }
}





