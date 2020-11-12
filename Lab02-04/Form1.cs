using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_04
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //add to list view
        private void add(int stt,String matk,String ten,String diaCHi,double soTien)
        {
            //Row
            String[] row = { stt.ToString(), matk, ten, diaCHi, soTien.ToString() };
            ListViewItem item = new ListViewItem(row);
            ds_khach_hang.Items.Add(item);
       
        }
        private void update()
        {
            ds_khach_hang.SelectedItems[0].SubItems[1].Text = tb_stk.Text;
            ds_khach_hang.SelectedItems[0].SubItems[2].Text = tb_ten.Text;
            ds_khach_hang.SelectedItems[0].SubItems[3].Text = tb_diachi.Text;
            ds_khach_hang.SelectedItems[0].SubItems[4].Text = tb_sotien.Text;

            tb_ten.Text = "";
            tb_diachi.Text = "";
            tb_stk.Text = "";
            tb_sotien.Text = "";
        }
        private void delete()
        {
            if(MessageBox.Show("Sure ?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ds_khach_hang.Items.RemoveAt(ds_khach_hang.SelectedIndices[0]);
                tb_ten.Text = "";
                tb_diachi.Text = "";
                tb_stk.Text = "";
                tb_sotien.Text = "";
                
            }
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_stk.Text == "" || tb_ten.Text == "" || tb_diachi.Text == ""||tb_sotien.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thong tin sinh viên!");
                if (ds_khach_hang.Items.Count > 0 && ds_khach_hang.SelectedItems.Count > 0)
                {
                    update();
                }
                else
                {
                    count++;
                    add(count, tb_stk.Text, tb_ten.Text, tb_diachi.Text, double.Parse(tb_sotien.Text));
                    tb_ten.Text = "";
                    tb_diachi.Text = "";
                    tb_stk.Text = "";
                    tb_sotien.Text = "";
                }
            }
            catch
            {

            }
                
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if(count == 0)
            {
                MessageBox.Show("Khong co khach hang de xoa");
            }
            else
            {
                delete();
                count--;
                for (int i = 0; i < count; i++)
                {
                    ds_khach_hang.Items[i].SubItems[0].Text = (i + 1).ToString();
                }
            }
            

        }

        private void ds_khach_hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ds_khach_hang_MouseClick(object sender, MouseEventArgs e)
        {
            tb_stk.Text = ds_khach_hang.SelectedItems[0].SubItems[1].Text;
            tb_ten.Text = ds_khach_hang.SelectedItems[0].SubItems[2].Text;
            tb_diachi.Text = ds_khach_hang.SelectedItems[0].SubItems[3].Text;
            tb_sotien.Text = ds_khach_hang.SelectedItems[0].SubItems[4].Text;
        }
    }
}
