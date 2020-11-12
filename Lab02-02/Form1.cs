using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class fmQuanlySinhVien : Form
    {
        public fmQuanlySinhVien()
        {
            InitializeComponent();
        }
        private void fmQuanlySinhVien_Load(object sender, EventArgs e)
        {
            cbNganh.SelectedIndex = 0;
        }
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value == null)
                    return -1;
                if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                    return i;
            }
            return -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void InserUpdate(int selectRow)
        {
            dgvStudent.Rows[selectRow].Cells[0].Value = txtMaSV.Text;
            dgvStudent.Rows[selectRow].Cells[1].Value = txtHoTen.Text;
            dgvStudent.Rows[selectRow].Cells[2].Value = rdNu.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectRow].Cells[3].Value = float.Parse(txtDiemTB.Text).ToString();
            dgvStudent.Rows[selectRow].Cells[4].Value = cbNganh.Text;
        }

        private void btThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text == "" || txtHoTen.Text == "" || txtDiemTB.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thong tin sinh viên!");
                int selectRow = GetSelectedRow(txtMaSV.Text);
                if (selectRow == -1)
                {
                    selectRow = dgvStudent.Rows.Add();
                    InserUpdate(selectRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    InserUpdate(selectRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMaSV.Text);
                if (selectedRow == -1)
                    throw new Exception("Khong co sv để xóa");
                else
                {
                    DialogResult dr = MessageBox.Show("bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa sinh vien thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
