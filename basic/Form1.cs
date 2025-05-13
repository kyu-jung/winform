using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 전역변수 -> 클래스 안 어디서든 사용할 수 있는 변수
        string allrounder = "전역변수";

        // 함수(메서드)
        void nothing()
        {

        }
        int number = 0;
        int number2 = 0;


        // 전역변수, 메서드 만들기
        string quiz = "전역변수 만들기";

        void quiz2()
        {

        }


        // 이벤트 -> 폼 디자인에 가서 해당 위젯 더블클릭하여 기본 이벤트를 활용할 수 있음.
        // 원하는 이벤트를 찾아 더블클릭하면 원하는 이벤트를 활용할 수 있음.
        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        
        // 함수(메서드), 이벤트 영역에서 작성하는 것들
        private void btn_name_Click(object sender, EventArgs e)
        {
            #region 필기
            // 클래스의 객체
            allrounder = "전역변수 이용하기";
            nothing();
            quiz = "전역변수 활용하기";
            quiz2();

            // 지역변수 -> 특정 함수 안에서만 이용가능한 변수, 클릭을 할때만 사용하는 변수(1회용)
            //int number = 0;

            

            // 컨트롤 (label, textbox, button) -> 각 위젯의 이름을 불러오면 설정가능
            lbl_1.Text = "할당";
            #endregion
            number ++; // number += 1;

            lbl_1.Text = lbl_2.Text = lbl_3.Text = lbl_4.Text = "글자";

            // tb_name.Text = '글자' + '글자' + '글자' + '글자';
            tb_name.Text = lbl_1.Text + $"가 {number} 만큼 클릭되었습니다.";
            tb_name.ReadOnly = true;  // 읽기 전용
        }



        // label, textbox, button을 이용해서 Text의값을 제어하는 프로그램을 만들어 봅시다.
        // Text가 string 이니까 format도 연습해보기
        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_5.Text = "반복";

            tb_2.Text = string.Format("버튼이 {0} 되어 클릭되었습니다.", lbl_5.Text);
            tb_2.ReadOnly = true;
        }



    }
}
