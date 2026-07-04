using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDocGia1
{
    public partial class FormLapPhieuMuon : Form
    {
        ComboBox cboDocGia, cboSach;
        DateTimePicker dtNgayMuon;
        ListBox lstSachDaChon;

        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public string NgayMuon { get; set; }

        public FormLapPhieuMuon()
        {
            InitializeComponent();
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            this.Text = "Lập phiếu mượn";
            this.Size = new Size(650, 520);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(8, 12, 40);

            Label title = new Label();
            title.Text = "✚ Lập phiếu mượn mới";
            title.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Location = new Point(35, 30);
            title.AutoSize = true;
            this.Controls.Add(title);

            Button btnClose = new Button();
            btnClose.Text = "×";
            btnClose.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            btnClose.Size = new Size(40, 40);
            btnClose.Location = new Point(560, 25);
            btnClose.BackColor = Color.FromArgb(25, 30, 60);
            btnClose.ForeColor = Color.FromArgb(170, 175, 210);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);

            Label line = new Label();
            line.BackColor = Color.FromArgb(45, 55, 85);
            line.Location = new Point(35, 80);
            line.Size = new Size(565, 1);
            this.Controls.Add(line);

            TaoLabel("MÃ PHIẾU", 35, 110);
            TextBox txtMa = TaoTextBox("Tự động tạo", 35, 135, 565);
            txtMa.Enabled = false;

            TaoLabel("CHỌN ĐỘC GIẢ", 35, 190);
            cboDocGia = new ComboBox();
            cboDocGia.Font = new Font("Segoe UI", 11);
            cboDocGia.Location = new Point(35, 215);
            cboDocGia.Size = new Size(260, 32);
            cboDocGia.BackColor = Color.FromArgb(27, 32, 55);
            cboDocGia.ForeColor = Color.White;
            cboDocGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDocGia.Items.Add("-- Chọn độc giả --");
            cboDocGia.Items.Add("DG-001 - Nguyễn Văn An");
            cboDocGia.Items.Add("DG-002 - Trần Thị Bình");
            cboDocGia.Items.Add("DG-003 - Lê Hoàng Cường");
            cboDocGia.SelectedIndex = 0;
            this.Controls.Add(cboDocGia);

            TaoLabel("NGÀY MƯỢN", 330, 190);
            dtNgayMuon = new DateTimePicker();
            dtNgayMuon.Font = new Font("Segoe UI", 11);
            dtNgayMuon.Location = new Point(330, 215);
            dtNgayMuon.Size = new Size(270, 32);
            dtNgayMuon.Format = DateTimePickerFormat.Custom;
            dtNgayMuon.CustomFormat = "yyyy-MM-dd";
            dtNgayMuon.Value = new DateTime(2026, 7, 1);
            this.Controls.Add(dtNgayMuon);

            TaoLabel("CHỌN SÁCH ĐỂ MƯỢN", 35, 270);
            cboSach = new ComboBox();
            cboSach.Font = new Font("Segoe UI", 11);
            cboSach.Location = new Point(35, 295);
            cboSach.Size = new Size(465, 32);
            cboSach.BackColor = Color.FromArgb(27, 32, 55);
            cboSach.ForeColor = Color.White;
            cboSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSach.Items.Add("-- Chọn sách --");
            cboSach.Items.Add("S001 - Dế Mèn Phiêu Lưu Ký");
            cboSach.Items.Add("S002 - Tôi Thấy Hoa Vàng Trên Cỏ Xanh");
            cboSach.Items.Add("S003 - Nhà Giả Kim");
            cboSach.SelectedIndex = 0;
            this.Controls.Add(cboSach);

            Button btnThem = new Button();
            btnThem.Text = "+ Thêm";
            btnThem.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnThem.Size = new Size(80, 36);
            btnThem.Location = new Point(515, 293);
            btnThem.BackColor = Color.FromArgb(45, 160, 75);
            btnThem.ForeColor = Color.White;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.Click += BtnThemSach_Click;
            this.Controls.Add(btnThem);

            TaoLabel("SÁCH ĐÃ CHỌN MƯỢN:", 35, 350);

            lstSachDaChon = new ListBox();
            lstSachDaChon.Location = new Point(35, 375);
            lstSachDaChon.Size = new Size(565, 50);
            lstSachDaChon.BackColor = Color.FromArgb(8, 12, 40);
            lstSachDaChon.ForeColor = Color.FromArgb(130, 140, 210);
            lstSachDaChon.BorderStyle = BorderStyle.None;
            lstSachDaChon.Items.Add("Chưa chọn sách nào");
            this.Controls.Add(lstSachDaChon);

            Button btnHuy = new Button();
            btnHuy.Text = "Hủy";
            btnHuy.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnHuy.Size = new Size(85, 42);
            btnHuy.Location = new Point(405, 435);
            btnHuy.BackColor = Color.FromArgb(10, 15, 40);
            btnHuy.ForeColor = Color.White;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Click += (s, e) => this.Close();
            this.Controls.Add(btnHuy);

            Button btnLapPhieu = new Button();
            btnLapPhieu.Text = "📋 Lập phiếu";
            btnLapPhieu.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLapPhieu.Size = new Size(110, 42);
            btnLapPhieu.Location = new Point(500, 435);
            btnLapPhieu.BackColor = Color.FromArgb(20, 145, 170);
            btnLapPhieu.ForeColor = Color.White;
            btnLapPhieu.FlatStyle = FlatStyle.Flat;
            btnLapPhieu.FlatAppearance.BorderSize = 0;
            btnLapPhieu.Click += BtnLapPhieu_Click;
            this.Controls.Add(btnLapPhieu);
        }

        private void BtnThemSach_Click(object sender, EventArgs e)
        {
            if (cboSach.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn sách!");
                return;
            }

            if (lstSachDaChon.Items.Count == 1 && lstSachDaChon.Items[0].ToString() == "Chưa chọn sách nào")
                lstSachDaChon.Items.Clear();

            lstSachDaChon.Items.Add(cboSach.Text);
        }

        private void BtnLapPhieu_Click(object sender, EventArgs e)
        {
            if (cboDocGia.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn độc giả!");
                return;
            }

            if (lstSachDaChon.Items.Count == 0 || lstSachDaChon.Items[0].ToString() == "Chưa chọn sách nào")
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sách!");
                return;
            }

            string[] tach = cboDocGia.Text.Split('-');

            MaDocGia = tach[0].Trim();
            TenDocGia = tach[1].Trim();
            NgayMuon = dtNgayMuon.Value.ToString("yyyy-MM-dd");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TaoLabel(string text, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(175, 180, 220);
            lbl.Location = new Point(x, y);
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
        }

        private TextBox TaoTextBox(string text, int x, int y, int width)
        {
            TextBox txt = new TextBox();
            txt.Text = text;
            txt.Font = new Font("Segoe UI", 11);
            txt.Size = new Size(width, 32);
            txt.Location = new Point(x, y);
            txt.BackColor = Color.FromArgb(27, 32, 55);
            txt.ForeColor = Color.FromArgb(130, 140, 210);
            txt.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(txt);
            return txt;
        }
    }
}