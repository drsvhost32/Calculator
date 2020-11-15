using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycalculate
{
    public partial class Form1 : Form
    {
        calculate Calculate = new calculate();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnbxplus_Click(object sender, EventArgs e)
        {
           if(isevalidate())
            {
                int sum = Calculate.plus((int)txtnumber1.Value, (int)txtnumber2.Value);
                MessageBox.Show("sum is :"+sum);
            }
        }

        private void Btnbxminus_Click(object sender, EventArgs e)
        {
            if (isevalidate())
            {
                int minus = Calculate.minus((int)txtnumber1.Value, (int)txtnumber2.Value);
                MessageBox.Show("minus is :" + minus);
            }
        }

        private void Btnbxmulitple_Click(object sender, EventArgs e)
        {
            if (isevalidate())
            {
                int multiple = Calculate.multiple((int)txtnumber1.Value, (int)txtnumber2.Value);
                MessageBox.Show("multiple is :" + multiple);
            }
        }

        private void Btnbxdivide_Click(object sender, EventArgs e)
        {
            if (isevalidate())
            {
                int divide = Calculate.divide((int)txtnumber1.Value, (int)txtnumber2.Value);
                MessageBox.Show("divide is :" + divide);
            }
        }

        bool isevalidate()
        {
            bool isValidate = true;
            if(txtnumber1.Value==0)
            {
                isValidate = false;
                MessageBox.Show("لطفا عدد اول را وارد نمایید");
            }
            else
            {
                if(txtnumber2.Value==0)
                {
                    isValidate = false;
                    MessageBox.Show("لطفا عدد دوم را وارد نمایید");
                }
            }


            return isValidate;
        }
    }
}
