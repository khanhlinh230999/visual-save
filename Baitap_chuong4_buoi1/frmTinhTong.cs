using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap_chuong4_buoi1
{
    public partial class frmTinhTong : Form
    {
        public frmTinhTong()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập a");
                txta.Focus();
            }
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            double Tong;
            
           
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);
          
            if (a < b)
            {


                lbTong.Text = ("Tổng các số từ" + a + " đến" + b + "là" + lbTong.Text);
            }
            
            lbTong.Text = lbTong.ToString();
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            if (txtb.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập b");
                txtb.Focus();
            }
        }
    }
}
