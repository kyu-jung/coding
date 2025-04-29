using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1: Form
    {
        #region 전역변수
        string input = string.Empty; // 입력되는 값
        string num1 = string.Empty;  // 첫번째 숫자
        string num2 = string.Empty;  // 두번째 숫자
        char opeartion;  // 연산자
        double result = 0;  // 결과값
        #endregion

        

        public Form1()
        {
            InitializeComponent();
            lbl_memory.Visible = false; // label 투명화
        }
        #region 함수
        private void UpdateMemory()
        {
            lbl_memory.Visible = true;
            lbl_memory.Text = num1 + "" + opeartion + "" + input;
        }
        #endregion

        #region 이벤트
        private void btn_Number_Click(object sender, EventArgs e)
        {
            // 소수점은 1개여야해서 확인용
            // 소수점 여부확인 && 클릭한 버튼의 텍스트를 확인해서 소수점인지 확인
            if (txt_result.Text.Contains(".") && ((Button)sender).Text == ".")
            { 
                return; // 소수점이 있을 경우 추가되는 소수점을 막기 위함.
            }
            else
            {
                input += ((Button)sender).Text; // 클릭한 버튼의 텍스트를 변수에 저장함
            }

            txt_result.Text = input; // 텍스트 박스에 글씨를 표시함
            UpdateMemory(); // Alt + Enter 누르고 선택하면 자동으로 함수생성
            txt_result.Focus(); 
        }

        

        private void btn_Operator_Click(object sender, EventArgs e)
        {
            num1 = input; // 연산자를 기준으로 input이 하나의 숫자
            // opeartion = ((Button)sender).Text[0];
            // 버튼의 글자(string)를 char로 변환
            opeartion = Convert.ToChar(((Button)sender).Text);
            input = string.Empty; // 두번째 숫자를 받기 위함

            lbl_memory.Visible = true;
            UpdateMemory();
            txt_result.Focus();
        }

        private void btn_eql_Click(object sender, EventArgs e)
        {
            num2 = input; // 두번째 숫자를 완성
            double check1, check2;
            double.TryParse(num1, out check1); // double로 형변환 후 오류없이 값 받기
            double.TryParse(num2, out check2);

            switch (opeartion)
            {
                case '+':
                    result = check1 + check2;
                    break;
                case '-':
                    result = check1 - check2;
                    break;
                case '*':
                    result = check1 * check2;
                    break;
                case '/':
                    if (check2 != 0)
                    {
                        result = check1 / check2;
                    }
                    else // 0으로 나눌수 없으므로
                    {
                        txt_result.Text = "0으로 나눌 수 없습니다.";
                        input = string.Empty;
                        return;
                    }
                    break;
            }
            txt_result.Text = result.ToString();
            UpdateMemory();
            input = string.Empty;
            txt_result.Focus();
        }

        private void txt_result_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 키문자가 숫자 이거나 || 소수점이 하나일때 값을 받아옴
            // 숫자만 갖기위함 || 소수점을 갖기 위함(하나만)
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '.' && !input.Contains('.')))
            {
                input += e.KeyChar;
                txt_result.Text = input;
                UpdateMemory();
            }
            else
            {
                e.Handled = true; // 글자키 무시하기
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            num1 = num2 = input = string.Empty;
            txt_result.Text = "0";
            lbl_memory.Text = "";
            lbl_memory.Visible = false;
            txt_result.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (input.Length > 0) // 지울 글자를 확보한 상태 (Substring 적용을 위해서)
            {
                // 0번째 부터 Length에서 제일 뒷자리 하나 빼고 출력
                // 가나다라마바사 -> 가나다라마바
                input = input.Substring(0, input.Length - 1);

                
                // 변수 = 조건 ? true : false; / 삼항 연산자 포맷
                txt_result.Text = input.Length > 0 ? input : "0"; // 마지막 한글자 지웠을때 한번더 질문해서 0으로 출력
                /*
                 * if (input.Length > 0)
                 * {
                   txt_result.Text = input;
                   }
                   else
                   {
                   txt_result.Text = "0";
                   }
                */
                UpdateMemory();
            }
            txt_result.Focus(); // input이 있거나 없거나 상관없이 적용되서
        }

        #endregion


    }
}
