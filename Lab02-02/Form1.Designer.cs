namespace Lab02_02
{
    partial class fmQuanlySinhVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinSV = new System.Windows.Forms.GroupBox();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lbChuyenNganh = new System.Windows.Forms.Label();
            this.lbDiemTB = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.btThemSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(68, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // gbThongTinSV
            // 
            this.gbThongTinSV.Controls.Add(this.cbNganh);
            this.gbThongTinSV.Controls.Add(this.txtDiemTB);
            this.gbThongTinSV.Controls.Add(this.rdNu);
            this.gbThongTinSV.Controls.Add(this.rbNam);
            this.gbThongTinSV.Controls.Add(this.txtHoTen);
            this.gbThongTinSV.Controls.Add(this.txtMaSV);
            this.gbThongTinSV.Controls.Add(this.lbChuyenNganh);
            this.gbThongTinSV.Controls.Add(this.lbDiemTB);
            this.gbThongTinSV.Controls.Add(this.lbGioiTinh);
            this.gbThongTinSV.Controls.Add(this.lbHoTen);
            this.gbThongTinSV.Controls.Add(this.lbMaSV);
            this.gbThongTinSV.Location = new System.Drawing.Point(24, 152);
            this.gbThongTinSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbThongTinSV.Name = "gbThongTinSV";
            this.gbThongTinSV.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbThongTinSV.Size = new System.Drawing.Size(366, 299);
            this.gbThongTinSV.TabIndex = 4;
            this.gbThongTinSV.TabStop = false;
            this.gbThongTinSV.Text = "Thông Tin Sinh Viên";
            // 
            // cbNganh
            // 
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cbNganh.Location = new System.Drawing.Point(139, 230);
            this.cbNganh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(140, 23);
            this.cbNganh.TabIndex = 10;
            this.cbNganh.Text = "QTKD";
            this.cbNganh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(139, 183);
            this.txtDiemTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(116, 23);
            this.txtDiemTB.TabIndex = 9;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Checked = true;
            this.rdNu.Location = new System.Drawing.Point(234, 142);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(41, 19);
            this.rdNu.TabIndex = 8;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(139, 142);
            this.rbNam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(51, 19);
            this.rbNam.TabIndex = 7;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(139, 88);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(190, 23);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(139, 46);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(116, 23);
            this.txtMaSV.TabIndex = 5;
            // 
            // lbChuyenNganh
            // 
            this.lbChuyenNganh.AutoSize = true;
            this.lbChuyenNganh.Location = new System.Drawing.Point(7, 239);
            this.lbChuyenNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChuyenNganh.Name = "lbChuyenNganh";
            this.lbChuyenNganh.Size = new System.Drawing.Size(94, 15);
            this.lbChuyenNganh.TabIndex = 4;
            this.lbChuyenNganh.Text = "Chuyên Nghành";
            // 
            // lbDiemTB
            // 
            this.lbDiemTB.AutoSize = true;
            this.lbDiemTB.Location = new System.Drawing.Point(10, 192);
            this.lbDiemTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiemTB.Name = "lbDiemTB";
            this.lbDiemTB.Size = new System.Drawing.Size(51, 15);
            this.lbDiemTB.TabIndex = 3;
            this.lbDiemTB.Text = "Điểm TB";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(7, 147);
            this.lbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(54, 15);
            this.lbGioiTinh.TabIndex = 2;
            this.lbGioiTinh.Text = "Giới Tính";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(7, 91);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(44, 15);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(7, 46);
            this.lbMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(76, 15);
            this.lbMaSV.TabIndex = 0;
            this.lbMaSV.Text = "Mã Sinh Viên";
            // 
            // btThemSua
            // 
            this.btThemSua.Location = new System.Drawing.Point(76, 472);
            this.btThemSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btThemSua.Name = "btThemSua";
            this.btThemSua.Size = new System.Drawing.Size(88, 27);
            this.btThemSua.TabIndex = 5;
            this.btThemSua.Text = "Thêm / Sửa";
            this.btThemSua.UseVisualStyleBackColor = true;
            this.btThemSua.Click += new System.EventHandler(this.btThemSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(234, 472);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(88, 27);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStudent.Location = new System.Drawing.Point(442, 171);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(645, 280);
            this.dgvStudent.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MSSV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "HoTen";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Diểm TB";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngành";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fmQuanlySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 660);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThemSua);
            this.Controls.Add(this.gbThongTinSV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fmQuanlySinhVien";
            this.Text = "Quản Lý Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.fmQuanlySinhVien_Load);
            this.gbThongTinSV.ResumeLayout(false);
            this.gbThongTinSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongTinSV;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbChuyenNganh;
        private System.Windows.Forms.Label lbDiemTB;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Button btThemSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

