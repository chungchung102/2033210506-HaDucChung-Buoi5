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
    public partial class frmBaiTap1 : Form
    {
        ErrorProvider errorProvider1;
        public frmBaiTap1()
        {
            errorProvider1 = new ErrorProvider();
            InitializeComponent();
        }

        

        private void maskedTextBox1_MaskInputRejected(object sender, EventArgs e)
        {
            Control ctr=(Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "you must enter your name");
            else
                this.errorProvider1.Clear();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, EventArgs e)
        {
            Control ctr=(Control)(sender);
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
                this.errorProvider1.SetError(ctr, "this is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "my name is: " + maskedTextBox1.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(maskedTextBox2.Text);
            s = s + "age" + age.ToString();
            MessageBox.Show(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
    }
}
