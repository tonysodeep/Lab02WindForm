using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
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

        private void btCong_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txtNumber1.Text);
            float number2 = float.Parse(txtNumber2.Text);
            txtAnswer.Text = (number1 + number2).ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                txtAnswer.Text = (number1 - number2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                txtAnswer.Text = (number1 * number2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                txtAnswer.Text = (number1 / number2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
