using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDocGia1
{
    public partial class FormMuonTra : Form
    {
        DataGridView dgvPhieuMuon;
        int soPhieu = 3;

        public FormMuonTra()
        {
            InitializeComponent();
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            this.Text = "Quản lý Mượn / Trả sách";
            this.Size = new Size(1200, 760);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(5, 10, 35);

            Label icon = new Label();
            icon.Text = "🔄";
            icon.Font = new Font("Segoe UI Emoji", 20);
            icon.Location = new Point(32, 28);
            icon.AutoSize = true;
            this.Controls.Add(icon);

            Label title = new Label();
            title.Text = "Quản lý Mượn / Trả sách";
            title.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Location = new Point(70, 28);
            title.AutoSize = true;
            this.Controls.Add(title);

            Label subtitle = new Label();
            subtitle.Text = "Lập phiếu mượn và xử lý trả sách";
            subtitle.Font = new Font("Segoe UI", 10);
            subtitle.ForeColor = Color.FromArgb(170, 175, 210);
            subtitle.Location = new Point(32, 72);
            subtitle.AutoSize = true;
            this.Controls.Add(subtitle);

            Button btnLapPhieu = new Button();
            btnLapPhieu.Text = "+ Lập phiếu mượn";
            btnLapPhieu.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLapPhieu.ForeColor = Color.White;
            btnLapPhieu.BackColor = Color.FromArgb(20, 145, 170);
            btnLapPhieu.FlatStyle = FlatStyle.Flat;
            btnLapPhieu.FlatAppearance.BorderSize = 0;
            btnLapPhieu.Size = new Size(190, 48);
            btnLapPhieu.Location = new Point(960, 35);
            btnLapPhieu.Click += BtnLapPhieu_Click;
            this.Controls.Add(btnLapPhieu);

            Panel khung = new Panel();
            khung.BackColor = Color.FromArgb(22, 33, 60);
            khung.Location = new Point(32, 125);
            khung.Size = new Size(1120, 300);
            this.Controls.Add(khung);

            Label ds = new Label();
            ds.Text = "📋 Danh sách Phiếu mượn";
            ds.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            ds.ForeColor = Color.White;
            ds.Location = new Point(30, 25);
            ds.AutoSize = true;
            khung.Controls.Add(ds);

            Label line = new Label();
            line.BackColor = Color.FromArgb(45, 55, 85);
            line.Location = new Point(25, 70);
            line.Size = new Size(1070, 1);
            khung.Controls.Add(line);

            dgvPhieuMuon = new DataGridView();
            dgvPhieuMuon.Location = new Point(25, 95);
            dgvPhieuMuon.Size = new Size(1070, 170);
            dgvPhieuMuon.BackgroundColor = Color.FromArgb(22, 33, 60);
            dgvPhieuMuon.BorderStyle = BorderStyle.None;
            dgvPhieuMuon.RowHeadersVisible = false;
            dgvPhieuMuon.AllowUserToAddRows = false;
            dgvPhieuMuon.AllowUserToResizeRows = false;
            dgvPhieuMuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuon.EnableHeadersVisualStyles = false;
            dgvPhieuMuon.GridColor = Color.FromArgb(35, 45, 80);

            dgvPhieuMuon.ColumnHeadersHeight = 50;
            dgvPhieuMuon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 42, 95);
            dgvPhieuMuon.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(180, 185, 220);
            dgvPhieuMuon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            dgvPhieuMuon.DefaultCellStyle.BackColor = Color.FromArgb(31, 40, 75);
            dgvPhieuMuon.DefaultCellStyle.ForeColor = Color.White;
            dgvPhieuMuon.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPhieuMuon.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 60, 115);
            dgvPhieuMuon.RowTemplate.Height = 55;

            dgvPhieuMuon.Columns.Add("MaPhieu", "MÃ PHIẾU");
            dgvPhieuMuon.Columns.Add("MaDG", "MÃ ĐG");
            dgvPhieuMuon.Columns.Add("TenDocGia", "TÊN ĐỘC GIẢ");
            dgvPhieuMuon.Columns.Add("NgayMuon", "NGÀY MƯỢN");
            dgvPhieuMuon.Columns.Add("TrangThai", "TRẠNG THÁI");
            dgvPhieuMuon.Columns.Add("ThaoTac", "THAO TÁC");

            dgvPhieuMuon.Rows.Add("PM-002", "DG-002", "Trần Thị Bình", "2026-05-25", "Đang mượn", "👁 Chi tiết");
            dgvPhieuMuon.Rows.Add("PM-001", "DG-001", "Nguyễn Văn An", "2026-05-20", "Đang mượn", "👁 Chi tiết");

            dgvPhieuMuon.CellFormatting += DgvPhieuMuon_CellFormatting;
            khung.Controls.Add(dgvPhieuMuon);
        }

        private void BtnLapPhieu_Click(object sender, EventArgs e)
        {
            FormLapPhieuMuon form = new FormLapPhieuMuon();

            if (form.ShowDialog() == DialogResult.OK)
            {
                string maPhieu = "PM-" + soPhieu.ToString("000");
                soPhieu++;

                dgvPhieuMuon.Rows.Insert(0,
                    maPhieu,
                    form.MaDocGia,
                    form.TenDocGia,
                    form.NgayMuon,
                    "Đang mượn",
                    "👁 Chi tiết"
                );
            }
        }

        private void DgvPhieuMuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPhieuMuon.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                e.CellStyle.ForeColor = Color.Orange;
            }

            if (dgvPhieuMuon.Columns[e.ColumnIndex].Name == "ThaoTac")
            {
                e.CellStyle.ForeColor = Color.White;
            }
        }

    
        

        private void FormMuonTra_Load(object sender, EventArgs e)
        {

        }
    }
}