using System.Windows.Forms;

namespace Lab02_04
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_stk = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_sotien = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.ds_khach_hang = new System.Windows.Forms.ListView();
            this.cl_stt = new System.Windows.Forms.ColumnHeader();
            this.cl_tk = new System.Windows.Forms.ColumnHeader();
            this.cl_ten = new System.Windows.Forms.ColumnHeader();
            this.cl_dia_chi = new System.Windows.Forms.ColumnHeader();
            this.cl_tien = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUAN LY THONG TIN SINH VIEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "So tai khoan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ten khach hang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dia chi khach hang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "So tien trong tai khoan";
            // 
            // tb_stk
            // 
            this.tb_stk.Location = new System.Drawing.Point(206, 86);
            this.tb_stk.Name = "tb_stk";
            this.tb_stk.Size = new System.Drawing.Size(314, 23);
            this.tb_stk.TabIndex = 5;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(206, 167);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(314, 23);
            this.tb_diachi.TabIndex = 5;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(206, 124);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(314, 23);
            this.tb_ten.TabIndex = 5;
            // 
            // tb_sotien
            // 
            this.tb_sotien.Location = new System.Drawing.Point(206, 210);
            this.tb_sotien.Name = "tb_sotien";
            this.tb_sotien.Size = new System.Drawing.Size(314, 23);
            this.tb_sotien.TabIndex = 5;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(230, 249);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(107, 23);
            this.bt_add.TabIndex = 6;
            this.bt_add.Text = "Them/Cap Nhat";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(445, 249);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "Xoa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // ds_khach_hang
            // 
            this.ds_khach_hang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_stt,
            this.cl_tk,
            this.cl_ten,
            this.cl_dia_chi,
            this.cl_tien});
            this.ds_khach_hang.FullRowSelect = true;
            this.ds_khach_hang.HideSelection = false;
            this.ds_khach_hang.Location = new System.Drawing.Point(33, 303);
            this.ds_khach_hang.Name = "ds_khach_hang";
            this.ds_khach_hang.Size = new System.Drawing.Size(713, 97);
            this.ds_khach_hang.TabIndex = 7;
            this.ds_khach_hang.UseCompatibleStateImageBehavior = false;
            this.ds_khach_hang.View = System.Windows.Forms.View.Details;
            this.ds_khach_hang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ds_khach_hang_MouseClick);
            // 
            // cl_stt
            // 
            this.cl_stt.Text = "STT";
            // 
            // cl_tk
            // 
            this.cl_tk.Text = "Ma tai khoan";
            this.cl_tk.Width = 150;
            // 
            // cl_ten
            // 
            this.cl_ten.Text = "Ten khach hang";
            this.cl_ten.Width = 150;
            // 
            // cl_dia_chi
            // 
            this.cl_dia_chi.Text = "Dia chi";
            this.cl_dia_chi.Width = 200;
            // 
            // cl_tien
            // 
            this.cl_tien.Text = "So tien";
            this.cl_tien.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 465);
            this.Controls.Add(this.ds_khach_hang);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_sotien);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_stk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_stk;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_sotien;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_xoa;
        private ListView ds_khach_hang;
        private ColumnHeader cl_stt;
        private ColumnHeader cl_tk;
        private ColumnHeader cl_ten;
        private ColumnHeader cl_dia_chi;
        private ColumnHeader cl_tien;
    }
}

