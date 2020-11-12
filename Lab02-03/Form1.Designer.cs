using System.Drawing;

namespace Lab02_03
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_kt = new System.Windows.Forms.Button();
            this.bt_huy_bo = new System.Windows.Forms.Button();
            this.bt_chon = new System.Windows.Forms.Button();
            this.sit15 = new System.Windows.Forms.Label();
            this.sit14 = new System.Windows.Forms.Label();
            this.sit13 = new System.Windows.Forms.Label();
            this.lb_money = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sit11 = new System.Windows.Forms.Label();
            this.sit12 = new System.Windows.Forms.Label();
            this.sit10 = new System.Windows.Forms.Label();
            this.sit9 = new System.Windows.Forms.Label();
            this.sit6 = new System.Windows.Forms.Label();
            this.sit7 = new System.Windows.Forms.Label();
            this.sit8 = new System.Windows.Forms.Label();
            this.sit2 = new System.Windows.Forms.Label();
            this.sit3 = new System.Windows.Forms.Label();
            this.sit4 = new System.Windows.Forms.Label();
            this.sit5 = new System.Windows.Forms.Label();
            this.sit1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(54, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "MAN ANH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_kt);
            this.panel1.Controls.Add(this.bt_huy_bo);
            this.panel1.Controls.Add(this.bt_chon);
            this.panel1.Controls.Add(this.sit15);
            this.panel1.Controls.Add(this.sit14);
            this.panel1.Controls.Add(this.sit13);
            this.panel1.Controls.Add(this.lb_money);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.sit11);
            this.panel1.Controls.Add(this.sit12);
            this.panel1.Controls.Add(this.sit10);
            this.panel1.Controls.Add(this.sit9);
            this.panel1.Controls.Add(this.sit6);
            this.panel1.Controls.Add(this.sit7);
            this.panel1.Controls.Add(this.sit8);
            this.panel1.Controls.Add(this.sit2);
            this.panel1.Controls.Add(this.sit3);
            this.panel1.Controls.Add(this.sit4);
            this.panel1.Controls.Add(this.sit5);
            this.panel1.Controls.Add(this.sit1);
            this.panel1.Location = new System.Drawing.Point(54, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 299);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_kt
            // 
            this.bt_kt.Location = new System.Drawing.Point(278, 262);
            this.bt_kt.Name = "bt_kt";
            this.bt_kt.Size = new System.Drawing.Size(75, 23);
            this.bt_kt.TabIndex = 7;
            this.bt_kt.Text = "Ket Thuc";
            this.bt_kt.UseVisualStyleBackColor = true;
            // 
            // bt_huy_bo
            // 
            this.bt_huy_bo.Location = new System.Drawing.Point(158, 262);
            this.bt_huy_bo.Name = "bt_huy_bo";
            this.bt_huy_bo.Size = new System.Drawing.Size(75, 23);
            this.bt_huy_bo.TabIndex = 6;
            this.bt_huy_bo.Text = "Huy Bo";
            this.bt_huy_bo.UseVisualStyleBackColor = true;
            this.bt_huy_bo.Click += new System.EventHandler(this.bt_huy_bo_Click);
            // 
            // bt_chon
            // 
            this.bt_chon.Location = new System.Drawing.Point(34, 262);
            this.bt_chon.Name = "bt_chon";
            this.bt_chon.Size = new System.Drawing.Size(75, 23);
            this.bt_chon.TabIndex = 5;
            this.bt_chon.Text = "Chon";
            this.bt_chon.UseVisualStyleBackColor = true;
            this.bt_chon.Click += new System.EventHandler(this.bt_chon_Click);
            // 
            // sit15
            // 
            this.sit15.BackColor = System.Drawing.Color.White;
            this.sit15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit15.Location = new System.Drawing.Point(327, 170);
            this.sit15.Name = "sit15";
            this.sit15.Size = new System.Drawing.Size(40, 40);
            this.sit15.TabIndex = 0;
            this.sit15.Text = "15";
            this.sit15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit15.Click += new System.EventHandler(this.sit15_Click);
            // 
            // sit14
            // 
            this.sit14.BackColor = System.Drawing.Color.White;
            this.sit14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit14.Location = new System.Drawing.Point(251, 170);
            this.sit14.Name = "sit14";
            this.sit14.Size = new System.Drawing.Size(40, 40);
            this.sit14.TabIndex = 0;
            this.sit14.Text = "14";
            this.sit14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit14.Click += new System.EventHandler(this.sit14_Click);
            // 
            // sit13
            // 
            this.sit13.BackColor = System.Drawing.Color.White;
            this.sit13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit13.Location = new System.Drawing.Point(172, 170);
            this.sit13.Name = "sit13";
            this.sit13.Size = new System.Drawing.Size(40, 40);
            this.sit13.TabIndex = 0;
            this.sit13.Text = "13";
            this.sit13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit13.Click += new System.EventHandler(this.sit13_Click);
            // 
            // lb_money
            // 
            this.lb_money.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_money.Location = new System.Drawing.Point(158, 226);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(100, 23);
            this.lb_money.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(79, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Thanh tien";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-174, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "label12";
            // 
            // sit11
            // 
            this.sit11.BackColor = System.Drawing.Color.White;
            this.sit11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit11.Location = new System.Drawing.Point(25, 170);
            this.sit11.Name = "sit11";
            this.sit11.Size = new System.Drawing.Size(40, 40);
            this.sit11.TabIndex = 0;
            this.sit11.Text = "11";
            this.sit11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit11.Click += new System.EventHandler(this.sit11_Click);
            // 
            // sit12
            // 
            this.sit12.BackColor = System.Drawing.Color.White;
            this.sit12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit12.Location = new System.Drawing.Point(102, 170);
            this.sit12.Name = "sit12";
            this.sit12.Size = new System.Drawing.Size(40, 40);
            this.sit12.TabIndex = 0;
            this.sit12.Text = "12";
            this.sit12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit12.Click += new System.EventHandler(this.sit12_Click);
            // 
            // sit10
            // 
            this.sit10.BackColor = System.Drawing.Color.White;
            this.sit10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit10.Location = new System.Drawing.Point(327, 101);
            this.sit10.Name = "sit10";
            this.sit10.Size = new System.Drawing.Size(40, 40);
            this.sit10.TabIndex = 0;
            this.sit10.Text = "10";
            this.sit10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit10.Click += new System.EventHandler(this.sit10_Click);
            // 
            // sit9
            // 
            this.sit9.BackColor = System.Drawing.Color.White;
            this.sit9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit9.Location = new System.Drawing.Point(251, 101);
            this.sit9.Name = "sit9";
            this.sit9.Size = new System.Drawing.Size(40, 40);
            this.sit9.TabIndex = 0;
            this.sit9.Text = "9";
            this.sit9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit9.Click += new System.EventHandler(this.sit9_Click);
            // 
            // sit6
            // 
            this.sit6.BackColor = System.Drawing.Color.White;
            this.sit6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit6.Location = new System.Drawing.Point(25, 101);
            this.sit6.Name = "sit6";
            this.sit6.Size = new System.Drawing.Size(40, 40);
            this.sit6.TabIndex = 0;
            this.sit6.Text = "6";
            this.sit6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit6.Click += new System.EventHandler(this.sit6_Click);
            // 
            // sit7
            // 
            this.sit7.BackColor = System.Drawing.Color.White;
            this.sit7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit7.Location = new System.Drawing.Point(102, 101);
            this.sit7.Name = "sit7";
            this.sit7.Size = new System.Drawing.Size(40, 40);
            this.sit7.TabIndex = 0;
            this.sit7.Text = "7";
            this.sit7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit7.Click += new System.EventHandler(this.sit7_Click);
            // 
            // sit8
            // 
            this.sit8.BackColor = System.Drawing.Color.White;
            this.sit8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit8.Location = new System.Drawing.Point(172, 101);
            this.sit8.Name = "sit8";
            this.sit8.Size = new System.Drawing.Size(40, 40);
            this.sit8.TabIndex = 0;
            this.sit8.Text = "8";
            this.sit8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit8.Click += new System.EventHandler(this.sit8_Click);
            // 
            // sit2
            // 
            this.sit2.BackColor = System.Drawing.Color.White;
            this.sit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit2.Location = new System.Drawing.Point(102, 35);
            this.sit2.Name = "sit2";
            this.sit2.Size = new System.Drawing.Size(40, 40);
            this.sit2.TabIndex = 0;
            this.sit2.Text = "2";
            this.sit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit2.Click += new System.EventHandler(this.sit2_Click);
            // 
            // sit3
            // 
            this.sit3.BackColor = System.Drawing.Color.White;
            this.sit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit3.Location = new System.Drawing.Point(172, 35);
            this.sit3.Name = "sit3";
            this.sit3.Size = new System.Drawing.Size(40, 40);
            this.sit3.TabIndex = 0;
            this.sit3.Text = "3";
            this.sit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit3.Click += new System.EventHandler(this.sit3_Click);
            // 
            // sit4
            // 
            this.sit4.BackColor = System.Drawing.Color.White;
            this.sit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit4.Location = new System.Drawing.Point(251, 35);
            this.sit4.Name = "sit4";
            this.sit4.Size = new System.Drawing.Size(40, 40);
            this.sit4.TabIndex = 0;
            this.sit4.Text = "4";
            this.sit4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit4.Click += new System.EventHandler(this.sit4_Click);
            // 
            // sit5
            // 
            this.sit5.BackColor = System.Drawing.Color.White;
            this.sit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit5.Location = new System.Drawing.Point(327, 35);
            this.sit5.Name = "sit5";
            this.sit5.Size = new System.Drawing.Size(40, 40);
            this.sit5.TabIndex = 0;
            this.sit5.Text = "5";
            this.sit5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit5.Click += new System.EventHandler(this.sit5_Click);
            // 
            // sit1
            // 
            this.sit1.BackColor = System.Drawing.Color.White;
            this.sit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sit1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sit1.Location = new System.Drawing.Point(25, 35);
            this.sit1.Name = "sit1";
            this.sit1.Size = new System.Drawing.Size(40, 40);
            this.sit1.TabIndex = 0;
            this.sit1.Text = "1";
            this.sit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sit1.Click += new System.EventHandler(this.sit1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sit2;
        private System.Windows.Forms.Label sit3;
        private System.Windows.Forms.Label sit4;
        private System.Windows.Forms.Label sit5;
        private System.Windows.Forms.Label sit1;
        private System.Windows.Forms.Label sit11;
        private System.Windows.Forms.Label sit12;
        private System.Windows.Forms.Label sit10;
        private System.Windows.Forms.Label sit9;
        private System.Windows.Forms.Label sit6;
        private System.Windows.Forms.Label sit7;
        private System.Windows.Forms.Label sit8;
        private System.Windows.Forms.Label lb_money;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_kt;
        private System.Windows.Forms.Button bt_huy_bo;
        private System.Windows.Forms.Button bt_chon;
        private System.Windows.Forms.Label sit15;
        private System.Windows.Forms.Label sit14;
        private System.Windows.Forms.Label sit13;
    }
}

