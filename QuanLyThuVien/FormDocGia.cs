using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDocGia1
{
    public partial class FormDocGia : Form
    {
        DataGridView dgvDocGia;
        int soThuTu = 6;

        public FormDocGia()
        {
            InitializeComponent();
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            this.Text = "Quản lý Độc giả";
            this.Size = new Size(1200, 760);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(5, 10, 35);

            Label icon = new Label();
            icon.Text = "👤";
            icon.Font = new Font("Segoe UI Emoji", 22);
            icon.ForeColor = Color.MediumPurple;
            icon.Location = new Point(30, 25);
            icon.AutoSize = true;
            this.Controls.Add(icon);

            Label title = new Label();
            title.Text = "Quản lý Độc giả";
            title.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Location = new Point(70, 28);
            title.AutoSize = true;
            this.Controls.Add(title);

            Label subtitle = new Label();
            subtitle.Text = "Quản lý thông tin và thẻ thành viên độc giả";
            subtitle.Font = new Font("Segoe UI", 10);
            subtitle.ForeColor = Color.FromArgb(170, 175, 210);
            subtitle.Location = new Point(32, 72);
            subtitle.AutoSize = true;
            this.Controls.Add(subtitle);

            Button btnThem = new Button();
            btnThem.Text = "+ Thêm độc giả";
            btnThem.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.BackColor = Color.FromArgb(20, 145, 170);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.Size = new Size(180, 48);
            btnThem.Location = new Point(970, 35);
            btnThem.Click += BtnThem_Click;
            this.Controls.Add(btnThem);

            Panel khung = new Panel();
            khung.BackColor = Color.FromArgb(22, 33, 60);
            khung.Location = new Point(30, 120);
            khung.Size = new Size(1120, 540);
            this.Controls.Add(khung);

            dgvDocGia = new DataGridView();
            dgvDocGia.Location = new Point(25, 25);
            dgvDocGia.Size = new Size(1070, 480);
            dgvDocGia.BackgroundColor = Color.FromArgb(22, 33, 60);
            dgvDocGia.BorderStyle = BorderStyle.None;
            dgvDocGia.RowHeadersVisible = false;
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.AllowUserToResizeRows = false;
            dgvDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.EnableHeadersVisualStyles = false;
            dgvDocGia.GridColor = Color.FromArgb(35, 45, 80);

            dgvDocGia.ColumnHeadersHeight = 55;
            dgvDocGia.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 42, 95);
            dgvDocGia.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(180, 185, 220);
            dgvDocGia.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            dgvDocGia.DefaultCellStyle.BackColor = Color.FromArgb(31, 40, 75);
            dgvDocGia.DefaultCellStyle.ForeColor = Color.White;
            dgvDocGia.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDocGia.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 60, 115);
            dgvDocGia.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvDocGia.RowTemplate.Height = 65;

            dgvDocGia.Columns.Add("MaDG", "MÃ ĐG");
            dgvDocGia.Columns.Add("HoTen", "HỌ TÊN");
            dgvDocGia.Columns.Add("CCCD", "CCCD");
            dgvDocGia.Columns.Add("SDT", "SĐT");
            dgvDocGia.Columns.Add("Email", "EMAIL");
            dgvDocGia.Columns.Add("NgayDK", "NGÀY ĐK");
            dgvDocGia.Columns.Add("HetHan", "HẾT HẠN");
            dgvDocGia.Columns.Add("TrangThai", "TRẠNG THÁI");
            dgvDocGia.Columns.Add("ThaoTac", "THAO TÁC");

            dgvDocGia.Rows.Add("DG-001", "Nguyễn Văn An", "079201001234", "0912345678", "an.nguyen@email.com", "2025-09-01", "2026-09-01", "Hoạt động", "✏️    🗑");
            dgvDocGia.Rows.Add("DG-002", "Trần Thị Bình", "079201005678", "0923456789", "binh.tran@email.com", "2025-10-15", "2026-10-15", "Hoạt động", "✏️    🗑");
            dgvDocGia.Rows.Add("DG-003", "Lê Hoàng Cường", "079201009012", "0934567890", "cuong.le@email.com", "2026-01-20", "2027-01-20", "Hoạt động", "✏️    🗑");
            dgvDocGia.Rows.Add("DG-004", "Phạm Minh Dương", "079201003456", "0945678901", "duong.pham@email.com", "2025-06-10", "2026-06-10", "Hoạt động", "✏️    🗑");
            dgvDocGia.Rows.Add("DG-005", "Hoàng Thị Em", "079201007890", "0956789012", "em.hoang@email.com", "2025-03-05", "2026-03-05", "Hết hạn", "✏️    🗑");

            dgvDocGia.CellFormatting += DgvDocGia_CellFormatting;
            khung.Controls.Add(dgvDocGia);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            FormThemDocGia form = new FormThemDocGia();

            if (form.ShowDialog() == DialogResult.OK)
            {
                string ma = "DG-" + soThuTu.ToString("000");
                soThuTu++;

                dgvDocGia.Rows.Add(
                    ma,
                    form.HoTen,
                    form.CCCD,
                    form.SDT,
                    form.Email,
                    DateTime.Now.ToString("yyyy-MM-dd"),
                    DateTime.Now.AddYears(1).ToString("yyyy-MM-dd"),
                    "Hoạt động",
                    "✏️    🗑"
                );
            }
        }

        private void DgvDocGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDocGia.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                if (e.Value != null && e.Value.ToString().Contains("Hoạt"))
                    e.CellStyle.ForeColor = Color.SpringGreen;
                else
                    e.CellStyle.ForeColor = Color.Orange;
            }

            if (dgvDocGia.Columns[e.ColumnIndex].Name == "ThaoTac")
            {
                e.CellStyle.ForeColor = Color.OrangeRed;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}