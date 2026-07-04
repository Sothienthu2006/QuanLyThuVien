namespace QuanLySach
{
    partial class qls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qls));
            this.QuanLySach = new System.Windows.Forms.Panel();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.ptnMain = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLHienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThaoTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.QuanLySach.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnMain)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuanLySach
            // 
            this.QuanLySach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.QuanLySach.Controls.Add(this.pnlTable);
            this.QuanLySach.Controls.Add(this.pnlSearch);
            this.QuanLySach.Controls.Add(this.pnlHeader);
            this.QuanLySach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuanLySach.Location = new System.Drawing.Point(0, 0);
            this.QuanLySach.Name = "QuanLySach";
            this.QuanLySach.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.QuanLySach.Size = new System.Drawing.Size(978, 562);
            this.QuanLySach.TabIndex = 0;
            this.QuanLySach.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTable
            // 
            this.pnlTable.Controls.Add(this.ptnMain);
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTable.Location = new System.Drawing.Point(30, 181);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(918, 361);
            this.pnlTable.TabIndex = 2;
            // 
            // ptnMain
            // 
            this.ptnMain.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ptnMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptnMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ptnMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colTacGia,
            this.colTheLoai,
            this.colNXB,
            this.colNamXB,
            this.colSLTong,
            this.colSLHienTai,
            this.colThaoTac});
            this.ptnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptnMain.Location = new System.Drawing.Point(0, 0);
            this.ptnMain.Name = "ptnMain";
            this.ptnMain.RowHeadersWidth = 62;
            this.ptnMain.RowTemplate.Height = 28;
            this.ptnMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ptnMain.Size = new System.Drawing.Size(918, 361);
            this.ptnMain.TabIndex = 0;
            // 
            // colMaSach
            // 
            this.colMaSach.HeaderText = "MÃ SÁCH";
            this.colMaSach.MinimumWidth = 8;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.Width = 150;
            // 
            // colTenSach
            // 
            this.colTenSach.HeaderText = "TÊN SÁCH";
            this.colTenSach.MinimumWidth = 8;
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.Width = 150;
            // 
            // colTacGia
            // 
            this.colTacGia.HeaderText = "TÁC GIẢ";
            this.colTacGia.MinimumWidth = 8;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.Width = 150;
            // 
            // colTheLoai
            // 
            this.colTheLoai.HeaderText = "THỂ LOẠI";
            this.colTheLoai.MinimumWidth = 8;
            this.colTheLoai.Name = "colTheLoai";
            this.colTheLoai.Width = 150;
            // 
            // colNXB
            // 
            this.colNXB.HeaderText = "NXB";
            this.colNXB.MinimumWidth = 8;
            this.colNXB.Name = "colNXB";
            this.colNXB.Width = 150;
            // 
            // colNamXB
            // 
            this.colNamXB.HeaderText = "NĂM XB";
            this.colNamXB.MinimumWidth = 8;
            this.colNamXB.Name = "colNamXB";
            this.colNamXB.Width = 150;
            // 
            // colSLTong
            // 
            this.colSLTong.HeaderText = "SL TỔNG";
            this.colSLTong.MinimumWidth = 8;
            this.colSLTong.Name = "colSLTong";
            this.colSLTong.Width = 150;
            // 
            // colSLHienTai
            // 
            this.colSLHienTai.HeaderText = "SL HIỆN TẠI";
            this.colSLHienTai.MinimumWidth = 8;
            this.colSLHienTai.Name = "colSLHienTai";
            this.colSLHienTai.Width = 150;
            // 
            // colThaoTac
            // 
            this.colThaoTac.HeaderText = "THAO TÁC";
            this.colThaoTac.MinimumWidth = 8;
            this.colThaoTac.Name = "colThaoTac";
            this.colThaoTac.Width = 150;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Controls.Add(this.pictureBox1);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(30, 123);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(918, 58);
            this.pnlSearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(35, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(880, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.btnThemSach);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(30, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(918, 103);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnThemSach
            // 
            this.btnThemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSach.ForeColor = System.Drawing.Color.White;
            this.btnThemSach.Location = new System.Drawing.Point(711, 19);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(190, 40);
            this.btnThemSach.TabIndex = 1;
            this.btnThemSach.Text = "➕ Thêm sách mới";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý Sách";
            // 
            // qls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 562);
            this.Controls.Add(this.QuanLySach);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "qls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.QuanLySach.ResumeLayout(false);
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptnMain)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel QuanLySach;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.DataGridView ptnMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLHienTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThaoTac;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

