using System;
using System.Windows.Forms;

namespace Calculator_wf
{
    public partial class Frame : Form
    {
        // 연산자는 1:덧셈, 2:뺄셈, 3:곱셈, 4:나눗셈으로 정의
        string operator1, operator2 = null;   // 연산자
        string operand1, operand2, operand3 = null;    // 피연산자
        string temp;    // 임시

        double Result;

        public Frame()
        {
            InitializeComponent();
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            temp += "1";
            txtResult.Text = temp.ToString();
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            temp += "2";
            txtResult.Text = temp.ToString();
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            temp += "3";
            txtResult.Text = temp.ToString();
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            temp += "4";
            txtResult.Text = temp.ToString();
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            temp += "5";
            txtResult.Text = temp.ToString();
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            temp += "6";
            txtResult.Text = temp.ToString();
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            temp += "7";
            txtResult.Text = temp.ToString();
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            temp += "8";
            txtResult.Text = temp.ToString();
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            temp += "9";
            txtResult.Text = temp.ToString();
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            if(txtExp.Text == "0")
            {
                // txtResult 값이 이미 0일 경우 아무런 수행 X 
            }
            else
            {
                temp += "0";
                txtResult.Text = temp.ToString();
            }

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            // 덧셈 버튼 기능
            if (operand1 == null)
            {
                operand1 = temp;        // 피연산자1에 값을 저장
            } else if (operand2 == null)
            {
                operand2 = temp;        // 피연산자2에 값을 저장
            } else if (operand3 == null)
            {
                operand3 = temp;        // 피연산자1에 값을 저장
            }
            

            temp += "+";               // temp에 + 기호 추가
            txtExp.Text += temp;    // 수식값에 temp값 추가
            temp = null;                  // temp 초기화

            // 디버깅
            label1.Text = operand1;
            label2.Text = operand2;
            label3.Text = operand3;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            // Clear : 초기화
            temp = "";
            txtExp.Text = "";
            txtResult.Text = "0";
            operand1 = null;
            operand2 = null;
            operand3 = null;

            // 디버깅
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            // Result : 최종 합산

            if (temp != null)
            {
                if(operand1 == null)
                {
                    operand1 = temp;
                } else if (operand2 == null)
                {
                    operand2 = temp;
                } else if (operand3 == null)
                {
                    operand3 = temp;
                }
            }



            // 디버깅
            label1.Text = operand1;
            label2.Text = operand2;
            label3.Text = operand3;

            if (operand3 != null)
            {
                txtExp.Text += operand3 + "=";
                Result = double.Parse(operand1) + double.Parse(operand2) + double.Parse(operand3);
                txtResult.Text = Result.ToString();
            } else if (operand2 != null)
            {
                txtExp.Text += operand2 + "=";
                Result = double.Parse(operand1) + double.Parse(operand2);
                txtResult.Text = Result.ToString();
            }

        }
    }
}

//int data1 = 15;
//int data2 = 10;
//int result = 0;

//data1 = int.Parse(textBox1.Text);
//data2 = int.Parse(textBox2.Text);

//result = data1 + data2;
//txtResult.Text = result.ToString();
