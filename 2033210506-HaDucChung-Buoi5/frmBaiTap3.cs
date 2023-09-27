using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2033210506_HaDucChung_Buoi5
{
    public partial class frmBaiTap3 : Form
    {
        ErrorProvider errorProvider1;
        public frmBaiTap3()
        {
            errorProvider1 = new ErrorProvider();
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Vui lòng không được để trống giá trị a");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }
        private void textBox2_TextChanged(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Vui lòng không được để trống giá trị a");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, null);
            }
        }

        private void textBox1_TextChanged(object sender,  KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        double ketQua = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("du lieu ko duoc de trong", "thong bao");
            else
            {
                ketQua=double.Parse(textBox1.Text)+double.Parse(textBox2.Text);
                textBox3.Text = ketQua.ToString();
            }

        }

       
    }
}
