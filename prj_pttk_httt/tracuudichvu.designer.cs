namespace DA_PTTK
{
    partial class MH_TRACUUDICHVU
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemVaoDSChon = new System.Windows.Forms.Button();
            this.dtgDSDichVu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaKhoiDSChon = new System.Windows.Forms.Button();
            this.dtgDSDichVuThucHien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDongYChon = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.colmadv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgiatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSDichVu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSDichVuThucHien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(36, 73);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(467, 22);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(509, 72);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 23);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemVaoDSChon);
            this.groupBox1.Controls.Add(this.dtgDSDichVu);
            this.groupBox1.Location = new System.Drawing.Point(30, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 301);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ";
            // 
            // btnThemVaoDSChon
            // 
            this.btnThemVaoDSChon.Location = new System.Drawing.Point(195, 272);
            this.btnThemVaoDSChon.Name = "btnThemVaoDSChon";
            this.btnThemVaoDSChon.Size = new System.Drawing.Size(197, 29);
            this.btnThemVaoDSChon.TabIndex = 1;
            this.btnThemVaoDSChon.Text = "Thêm vào danh sách chọn";
            this.btnThemVaoDSChon.UseVisualStyleBackColor = true;
            this.btnThemVaoDSChon.Click += new System.EventHandler(this.btnThemVaoDSChon_Click);
            // 
            // dtgDSDichVu
            // 
            this.dtgDSDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSDichVu.Location = new System.Drawing.Point(6, 21);
            this.dtgDSDichVu.MultiSelect = false;
            this.dtgDSDichVu.Name = "dtgDSDichVu";
            this.dtgDSDichVu.RowHeadersWidth = 51;
            this.dtgDSDichVu.RowTemplate.Height = 24;
            this.dtgDSDichVu.Size = new System.Drawing.Size(568, 245);
            this.dtgDSDichVu.TabIndex = 0;
            this.dtgDSDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDSDichVu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(385, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "TRA CỨU DỊCH VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaKhoiDSChon);
            this.groupBox2.Controls.Add(this.dtgDSDichVuThucHien);
            this.groupBox2.Location = new System.Drawing.Point(30, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 208);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách dịch vụ được chọn thực hiện";
            // 
            // btnXoaKhoiDSChon
            // 
            this.btnXoaKhoiDSChon.Location = new System.Drawing.Point(195, 179);
            this.btnXoaKhoiDSChon.Name = "btnXoaKhoiDSChon";
            this.btnXoaKhoiDSChon.Size = new System.Drawing.Size(197, 29);
            this.btnXoaKhoiDSChon.TabIndex = 1;
            this.btnXoaKhoiDSChon.Text = "Xóa Khỏi danh sách chọn";
            this.btnXoaKhoiDSChon.UseVisualStyleBackColor = true;
            this.btnXoaKhoiDSChon.Click += new System.EventHandler(this.btnXoaKhoiDSChon_Click);
            // 
            // dtgDSDichVuThucHien
            // 
            this.dtgDSDichVuThucHien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSDichVuThucHien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmadv,
            this.colten,
            this.colmota,
            this.colgiatien});
            this.dtgDSDichVuThucHien.Location = new System.Drawing.Point(6, 21);
            this.dtgDSDichVuThucHien.Name = "dtgDSDichVuThucHien";
            this.dtgDSDichVuThucHien.RowHeadersWidth = 51;
            this.dtgDSDichVuThucHien.RowTemplate.Height = 24;
            this.dtgDSDichVuThucHien.Size = new System.Drawing.Size(568, 152);
            this.dtgDSDichVuThucHien.TabIndex = 0;
            this.dtgDSDichVuThucHien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDSDichVuThucHien_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "MÔ TẢ DỊCH VỤ";
            // 
            // btnDongYChon
            // 
            this.btnDongYChon.Location = new System.Drawing.Point(425, 650);
            this.btnDongYChon.Name = "btnDongYChon";
            this.btnDongYChon.Size = new System.Drawing.Size(122, 31);
            this.btnDongYChon.TabIndex = 6;
            this.btnDongYChon.Text = "Đồng ý chọn";
            this.btnDongYChon.UseVisualStyleBackColor = true;
            this.btnDongYChon.Click += new System.EventHandler(this.btnDongYChon_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(625, 113);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(324, 516);
            this.txtMoTa.TabIndex = 8;
            this.txtMoTa.TextChanged += new System.EventHandler(this.txtMoTa_TextChanged);
            // 
            // colmadv
            // 
            this.colmadv.HeaderText = "iddichvu";
            this.colmadv.MinimumWidth = 6;
            this.colmadv.Name = "colmadv";
            // 
            // colten
            // 
            this.colten.HeaderText = "tendichvu";
            this.colten.MinimumWidth = 6;
            this.colten.Name = "colten";
            // 
            // colmota
            // 
            this.colmota.HeaderText = "mieuta";
            this.colmota.MinimumWidth = 6;
            this.colmota.Name = "colmota";
            // 
            // colgiatien
            // 
            this.colgiatien.HeaderText = "giatien";
            this.colgiatien.MinimumWidth = 6;
            this.colgiatien.Name = "colgiatien";
            // 
            // MH_TRACUUDICHVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 706);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.btnDongYChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "MH_TRACUUDICHVU";
            this.Text = "TRACUUDICHVU";
            this.Load += new System.EventHandler(this.MH_TRACUUDICHVU_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSDichVu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSDichVuThucHien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgDSDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemVaoDSChon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaKhoiDSChon;
        private System.Windows.Forms.DataGridView dtgDSDichVuThucHien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDongYChon;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmadv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgiatien;
    }
}

