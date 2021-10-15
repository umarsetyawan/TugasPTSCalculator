using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPTS
{
    public partial class Calculator : Form
    {
        double firstnumber;
        double secondnumber;
        double answer;
        public Calculator()
        {
            InitializeComponent();
        }
        private void clr_btn_Click(object sender, EventArgs e)
        {
            number1_txt.Text = "";
            number2_txt.Text = "";
            answer_txt.Text = "";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(number1_txt.Text) && string.IsNullOrEmpty(number2_txt.Text))
            {
                MessageBox.Show("Angka harus di isi");
            }
            if (string.IsNullOrEmpty(answer_txt.Text))
            {
                firstnumber = Convert.ToDouble(number1_txt.Text);
                secondnumber = Convert.ToDouble(number2_txt.Text);
                answer = firstnumber + secondnumber;
                answer_txt.Text = Convert.ToString(answer);
            }
            else
            {
                MessageBox.Show("Tolong bersihkan angka sebelum melakukan operasi");
            }
        }

        private void subtract_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(number1_txt.Text) && string.IsNullOrEmpty(number2_txt.Text))
            {
                MessageBox.Show("Angka harus di isi");
            }
            if (string.IsNullOrEmpty(answer_txt.Text))
            {
                firstnumber = Convert.ToDouble(number1_txt.Text);
                secondnumber = Convert.ToDouble(number2_txt.Text);
                answer = firstnumber - secondnumber;
                answer_txt.Text = Convert.ToString(answer);
            }
            else
            {
                MessageBox.Show("Tolong bersihkan angka sebelum melakukan operasi");
            }
        }

        private void devide_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(number1_txt.Text) && string.IsNullOrEmpty(number2_txt.Text))
            {
                MessageBox.Show("Angka harus di isi");
            }
            if (string.IsNullOrEmpty(answer_txt.Text))
            {
                firstnumber = Convert.ToDouble(number1_txt.Text);
                secondnumber = Convert.ToDouble(number2_txt.Text);
                answer = firstnumber / secondnumber;
                answer_txt.Text = Convert.ToString(answer);
            }
            else
            {
                MessageBox.Show("Tolong bersihkan angka sebelum melakukan operasi");
            }
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(number1_txt.Text) && string.IsNullOrEmpty(number2_txt.Text))
            {
                MessageBox.Show("Angka harus di isi");
            }
            if (string.IsNullOrEmpty(answer_txt.Text))
            {
                firstnumber = Convert.ToDouble(number1_txt.Text);
                secondnumber = Convert.ToDouble(number2_txt.Text);
                answer = firstnumber * secondnumber;
                answer_txt.Text = Convert.ToString(answer);
            }
            else
            {
                MessageBox.Show("Tolong bersihkan angka sebelum melakukan operasi");
            }
        }

        private void die_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
