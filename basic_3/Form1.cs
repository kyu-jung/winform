using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0; // 콤보박스에 있는 인덱스 중 선택해서 초기화면에 띄울수 있다.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "저녁메뉴 : " + comboBox1.Text;
        }

        // 콤보박스의 메뉴를 넣어주고 선택되는 글자를 화면에 출력되도록 label에 넣어주기

    }
}
