using System;
using System.Windows.Forms;
using ThemSach;

namespace QuanLySach
{
    public partial class qls : Form
    {
        public qls()
        {
            InitializeComponent();   // <-- THÊM DÒNG NÀY
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ptnMain.Rows.Clear();

            ptnMain.Rows.Add("S2026-001", "Dế Mèn Phiêu Lưu Ký", "Tô Hoài", "Văn học", "NXB Kim Đồng", "2020", "10", "8", "Sửa | Xóa");
            ptnMain.Rows.Add("S2026-002", "Lược Sử Thời Gian", "Stephen Hawking", "Khoa học", "NXB Trẻ", "2021", "8", "7", "Sửa | Xóa");
            ptnMain.Rows.Add("S2026-003", "Clean Code", "Robert C. Martin", "Công nghệ", "NXB Lao Động", "2022", "12", "10", "Sửa | Xóa");
            ptnMain.Rows.Add("S2026-004", "Đắc Nhân Tâm", "Dale Carnegie", "Kỹ năng", "NXB Tổng Hợp", "2023", "15", "13", "Sửa | Xóa");
            ptnMain.Rows.Add("S2026-005", "Nhà Giả Kim", "Paulo Coelho", "Văn học", "NXB Hội Nhà Văn", "2020", "9", "9", "Sửa | Xóa");
            ptnMain.Rows.Add("S2026-006", "Sapiens", "Yuval Noah Harari", "Lịch sử", "NXB Tri Thức", "2021", "7", "6", "Sửa | Xóa");
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            FrmThemSach formThemSach = new FrmThemSach();
            formThemSach.ShowDialog();
        }
    }
}