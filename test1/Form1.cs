using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chk_test1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_test1.Checked)
            {
                tb_test.Text = "짜장면을 선택하셨습니다.";
                chk_test2.Checked = false;
            }
            else
            {
                if (!chk_test2.Checked)
                {
                    tb_test.Text = string.Empty;
                }
                
            }
        }

        private void chk_test2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_test2.Checked)
            {
                tb_test.Text = "짬뽕을 선택하셨습니다.";
                chk_test1.Checked = false;
            }
            else
            {
                if (!chk_test1.Checked)
                {
                    tb_test.Text = string.Empty;
                }
                
            }
        }
    }
}
