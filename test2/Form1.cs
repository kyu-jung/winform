using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            cob_fruit.SelectedIndex = 0;
        }

       

        private void bt_animal_Click_1(object sender, EventArgs e)
        {
            if (ckb_animal.Checked)
            {
                lbl_animal.Text = ckb_animal.Text;
            }
            else
            {
                lbl_animal.Text = string.Empty;
            }
        }

        private void cob_fruit_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_fruit.Text = cob_fruit.SelectedItem.ToString();
        }

        private void btn_fruit_Click(object sender, EventArgs e)
        {
            string text = tb_fruit.Text;
            tb_fruit.Text = text + "선택되었습니다.";
        }
    }
}
