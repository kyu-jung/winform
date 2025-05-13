using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chk_puppy_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_puppy.Checked)
            {
                tb_result.Text = "강아지가 선택 되었습니다.";
                chk_kitty.Checked = false;
            }
            else
            {
                if (!chk_kitty.Checked) // 강아지 체크박스가 false일때 고양이 체크박스가 false
                {
                    tb_result.Text = string.Empty;  // 텍스트 박스를 비워주는 기능
                }
                  
            }
        }

        private void chk_kitty_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_kitty.Checked)  // 체크박스가 체크되었을 때
            {
                tb_result.Text = "고양이가 선택 되었습니다.";
                chk_puppy.Checked = false;
            }
            else  // 텍스트 박스가 비어있지 않을 때
            {
                if (!chk_puppy.Checked)// 고양이 체크박스가 false일때 강아지 체크박스가 false
                {
                    tb_result.Text = string.Empty;
                }
                
            }
        }

        
    }
}
