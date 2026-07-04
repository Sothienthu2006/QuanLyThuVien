using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDocGia1
{
    public partial class FormThemDocGia : Form
    {
 

        TextBox txtHoTen, txtCCCD, txtSDT, txtEmail;

        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public FormThemDocGia()
        {
            InitializeComponent();
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            this.Text = "Thêm độc giả";
            this.Size = new Size(900, 650);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(5, 10, 35);

            Label title = new Label();
            title.Text = "✚ Thêm độc giả";
            title.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Location = new Point(55, 45);
            title.AutoSize = true;
            this.Controls.Add(title);

            TaoLabel("MÃ ĐỘC GIẢ", 60, 140);
            TextBox txtMa = TaoTextBox("Tự động tạo", 60, 175, 760);
            txtMa.Enabled = false;

            TaoLabel("HỌ VÀ TÊN", 60, 255);
            txtHoTen = TaoTextBox("", 60, 290, 360);

            TaoLabel("CĂN CƯỚC CÔNG DÂN", 460, 255);
            txtCCCD = TaoTextBox("", 460, 290, 360);

            TaoLabel("SỐ ĐIỆN THOẠI", 60, 370);
            txtSDT = TaoTextBox("", 60, 405, 360);

            TaoLabel("EMAIL", 460, 370);
            txtEmail = TaoTextBox("", 460, 405, 360);

            Button btnHuy = new Button();
            btnHuy.Text = "Hủy";
            btnHuy.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnHuy.Size = new Size(120, 55);
            btnHuy.Location = new Point(540, 520);
            btnHuy.BackColor = Color.FromArgb(10, 15, 40);
            btnHuy.ForeColor = Color.White;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Click += (s, e) => this.Close();
            this.Controls.Add(btnHuy);

            Button btnLuu = new Button();
            btnLuu.Text = "💾 Lưu";
            btnLuu.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnLuu.Size = new Size(150, 55);
            btnLuu.Location = new Point(670, 520);
            btnLuu.BackColor = Color.FromArgb(20, 145, 170);
            btnLuu.ForeColor = Color.White;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.Click += BtnLuu_Click;
            this.Controls.Add(btnLuu);
        }

        private void FormThemDocGia_Load(object sender, EventArgs e)
        {

        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            HoTen = txtHoTen.Text;
            CCCD = txtCCCD.Text;
            SDT = txtSDT.Text;
            Email = txtEmail.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TaoLabel(string text, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(175, 180, 220);
            lbl.Location = new Point(x, y);
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
        }

        private TextBox TaoTextBox(string text, int x, int y, int width)
        {
            TextBox txt = new TextBox();
            txt.Text = text;
            txt.Font = new Font("Segoe UI", 15);
            txt.Size = new Size(width, 45);
            txt.Location = new Point(x, y);
            txt.BackColor = Color.FromArgb(27, 32, 55);
            txt.ForeColor = Color.White;
            txt.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(txt);
            return txt;
        }
    }
}