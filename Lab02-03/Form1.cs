using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Lab02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        List<Label> danhSachChon = new List<Label>();
        int thanhTien = 0;
        private void choiceSeat(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label.BackColor == System.Drawing.Color.White)
            {
                label.BackColor = Color.Blue;
                danhSachChon.Add(label);
            }
            else if (label.BackColor == Color.Blue)
            {
                label.BackColor = Color.White;
                danhSachChon.Remove(label);
            }
            else if (label.BackColor == Color.Yellow)
                MessageBox.Show("Ghe da duoc chon");
        }


        private void sit2_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit1_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit3_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit4_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit5_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit6_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit7_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit8_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit9_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit10_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit11_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit12_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void sit13_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }
        private void sit14_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }
        private void sit15_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void bt_chon_Click(object sender, EventArgs e)
        {
            foreach(Label l in danhSachChon)
            {
                l.BackColor = Color.Yellow;
                if (float.Parse(l.Text.ToString()) <= 5)
                    thanhTien += 5000;
                else if (float.Parse(l.Text.ToString()) <= 10)
                    thanhTien += 6500;
                else
                    thanhTien += 8000;

            }
            lb_money.Text = thanhTien.ToString();
            lb_money.Text = "";
            danhSachChon = new List<Label>();
        }

        private void bt_huy_bo_Click(object sender, EventArgs e)
        {
            foreach(Label l in danhSachChon)
            {
                l.BackColor = Color.White;
                lb_money.Text = "";
            }
            danhSachChon = new List<Label>();
        }
    }
}
