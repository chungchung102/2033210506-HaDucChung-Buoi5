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
    public partial class frmBaiTap2 : Form
    {
        ErrorProvider errorProvider1;
        public frmBaiTap2()
        {
            errorProvider1 = new ErrorProvider();
            InitializeComponent();
        }
       

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr=(Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
                this.errorProvider1.SetError(ctr, "this is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
                this.errorProvider1.SetError(ctr, "this is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
                this.errorProvider1.SetError(ctr, "this is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        
    }
}
