﻿using System;
using System.Windows.Forms;

namespace Calculator_wf
{
    public partial class Frame : Form
    {
        // 연산자는 1:덧셈, 2:뺄셈, 3:곱셈, 4:나눗셈으로 정의
        int operator1, operator2;   // 연산자
        string operand1, operand2, operand3 = null;    // 피연산자
        string temp;    // 임시
        double Result;  // 결과값

        string[,] historyValue = new string[20,2];    // 2차원 배열 = 계산 기록

        int listCount = 1;  // 계산 기록 카운트 횟수
        Boolean resultCount = false;    // = 버튼 누른 횟수

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
            if (txtExp.Text == "0")
            {
                // txtResult 값이 이미 0일 경우 아무런 수행 X 
            }
            else
            {
                temp += "0";
                txtResult.Text = temp.ToString();
            }

        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            temp += ".";
            txtResult.Text = temp.ToString();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            // 덧셈 버튼 기능
            if(resultCount == true)    // 결과 이력 초기화
            {
                txtExp.Text = "";
                resultCount = false;    
            }
                
            if (operand1 == null)
            {
                operand1 = temp;        // 피연산자1에 값을 저장
                operator1 = 1;          // 1==Add
            }
            else if (operand2 == null)
            {
                operand2 = temp;        // 피연산자2에 값을 저장
                operator2 = 1;          // 1==Add
            }
            else if (operand3 == null)
            {
                operand3 = temp;        // 피연산자1에 값을 저장
            }


            temp += " + ";               // temp에 + 기호 추가
            txtExp.Text += temp;    // 수식값에 temp값 추가
            temp = null;                  // temp 초기화

            // 디버깅
            label1.Text = operand1;
            label2.Text = operand2;
            label3.Text = operand3;
            label4.Text = operator1.ToString();
            label5.Text = operator2.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            // 뺄셈 버튼 기능

            if (resultCount == true)    // 결과 이력 초기화
            {
                txtExp.Text = "";
                resultCount = false;
            }

            if (operand1 == null)
            {
                operand1 = temp;        // 피연산자1에 값을 저장
                operator1 = 2;          // 2==Minus
            }
            else if (operand2 == null)
            {
                operand2 = temp;        // 피연산자2에 값을 저장
                operator2 = 2;        // 2==Minus
            }
            else if (operand3 == null)
            {
                operand3 = temp;        // 피연산자1에 값을 저장
            }


            temp += " - ";               // temp에 + 기호 추가
            txtExp.Text += temp;    // 수식값에 temp값 추가
            temp = null;                  // temp 초기화

            // 디버깅
            label1.Text = operand1;
            label2.Text = operand2;
            label3.Text = operand3;
            label4.Text = operator1.ToString();
            label5.Text = operator2.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            // 곱셈 버튼 기능

            if (resultCount == true)    // 결과 이력 초기화
            {
                txtExp.Text = "";
                resultCount = false;
            }

            if (operand1 == null)
            {
                operand1 = temp;        // 피연산자1에 값을 저장
                operator1 = 3;              // 3==Multiply
            }
            else if (operand2 == null)
            {
                operand2 = temp;        // 피연산자2에 값을 저장
                operator2 = 3;               // 3==Multiply
            }
            else if (operand3 == null)
            {
                operand3 = temp;        // 피연산자1에 값을 저장
            }

            temp += " x ";               // temp에 + 기호 추가
            txtExp.Text += temp;    // 수식값에 temp값 추가
            temp = null;                  // temp 초기화

            // 디버깅
            label1.Text = operand1;
            label2.Text = operand2;
            label3.Text = operand3;
            label4.Text = operator1.ToString();
            label5.Text = operator2.ToString();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            // 나눗셈 버튼 기능

            if (resultCount == true)    // 결과 이력 초기화
            {
                txtExp.Text = "";
                resultCount = false;
            }

            if (operand1 == null)
            {
                operand1 = temp;        // 피연산자1에 값을 저장
                operator1 = 4;              // 4==Division
            }
            else if (operand2 == null)
            {
                operand2 = temp;        // 피연산자2에 값을 저장
                operator2 = 4;               // 4==Division
            }
            else if (operand3 == null)
            {
                operand3 = temp;        // 피연산자1에 값을 저장
            }

            temp += " ÷ ";               // temp에 + 기호 추가
            txtExp.Text += temp;    // 수식값에 temp값 추가
            temp = null;                  // temp 초기화

            // 디버깅
            label1.Text = operand1;
            label2.Text = operand2;
            label3.Text = operand3;
            label4.Text = operator1.ToString();
            label5.Text = operator2.ToString();
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
            operator1 = 0;
            operator2 = 0;


            // 디버깅
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = operator1.ToString();
            label5.Text = operator2.ToString();


        }

        /// ///////////////////////////////////////////////////////////////////////


        private void buttonResult_Click(object sender, EventArgs e)
        {
            // Result : 최종 합산

            // 마지막 피식별자 입력
            if (temp != null)
            {
                if (operand1 == null)
                {
                    operand1 = temp;
                }
                else if (operand2 == null)
                {
                    operand2 = temp;
                }
                else if (operand3 == null)
                {
                    operand3 = temp;
                }
            }

            // 피연산자 비존재할 경우 오류 방지
            if (operator1 != null && operand2 == null)
            {
                operand2 = operand1;
            } else if (operator2 != null && operand3 == null)
            {
                operand3 = operand2;
                // 오류 방지는 할 수 있으나, 실제 계산기 결과랑 다름(추후 수정예정)
            }

            // 첫번째 연산자 조건문
            if (operator1 == 1)
            {
                Result = double.Parse(operand1) + double.Parse(operand2);
            }
            else if (operator1 == 2)
            {
                Result = double.Parse(operand1) - double.Parse(operand2);
            }
            else if (operator1 == 3)
            {
                Result = double.Parse(operand1) * double.Parse(operand2);
            }
            else if (operator1 == 4)
            {
                Result = double.Parse(operand1) / double.Parse(operand2);
            }

            // 두번째 연산자 조건문
            if (operator2 == 1)
            {
                Result += double.Parse(operand3);
            }
            else if (operator2 == 2)
            {
                Result -= double.Parse(operand3);
            }
            else if (operator2 == 3)
            {
                Result *= double.Parse(operand3);
            }
            else if (operator2 == 4)
            {
                Result /= double.Parse(operand3);
            }

            // 피연산자 수의 따른 연산
            if (operand3 != null)   // 3 존재의 경우
            {
                txtExp.Text += operand3 + "=";
                txtResult.Text = Result.ToString();
            }
            else if (operand2 != null)    // 3 미존재의 경우
            {
                txtExp.Text += operand2 + "=";
                txtResult.Text = Result.ToString();
            }






            if (listCount == 1) // 맨 처음엔...
            {
                historyValue[0, 0] = txtExp.Text;
                historyValue[0, 1] = txtResult.Text;

            } else if (listCount > 1)   // 기록 옮기자!
            {
                for (int i = listCount; i > 0; i--)
                {
                    historyValue[i-1, 0] = historyValue[i - 1, 0];
                    historyValue[i-1, 1] = historyValue[i - 1, 1];

                    if (i == 1)
                    {
                        historyValue[0, 0] = txtExp.Text;
                        historyValue[0, 1] = txtResult.Text;
                    }

                    //historyValue[1, 0] = historyValue[0, 0];
                    //historyValue[1, 1] = historyValue[0, 1];
                    //historyValue[0, 0] = txtExp.Text;
                    //historyValue[0, 1] = txtResult.Text;
                }
            }

            listCount++;    // = 카운트 횟수 1 증가

            //historyValue[0, 0] = txtExp.Text;
            //historyValue[0, 1] = txtResult.Text;

            // 기록에도 저장
            switch (listCount)
            {
                case 1:
                    //historyValue[0, 0] = txtExp.Text;
                    //historyValue[0, 1] = txtResult.Text;
                    break;
                case 2:
                    //historyValue[1, 0] = historyValue[0, 0];
                    //historyValue[1, 1] = historyValue[0, 1];

                    //for(int i=listCount; i>=listCount; i--)
                    //{
                    //    historyValue[i, 0] = historyValue[listCount - i, 0];
                    //    historyValue[i, 1] = historyValue[listCount - i, 1];
                    //}

                    //historyValue[0, 0] = txtExp.Text;
                    //historyValue[0, 1] = txtResult.Text;
                    break;
                case 3:
                    //historyValue[2, 0] = historyValue[1, 0];
                    //historyValue[2, 1] = historyValue[1, 1];
                    //historyValue[1, 0] = historyValue[0, 0];
                    //historyValue[1, 1] = historyValue[0, 1];


                    break;
                case 4:
                    //historyValue[3, 0] = historyValue[2, 0];
                    //historyValue[3, 1] = historyValue[2, 1];
                    //historyValue[2, 0] = historyValue[1, 0];
                    //historyValue[2, 1] = historyValue[1, 1];
                    //historyValue[1, 0] = historyValue[0, 0];
                    //historyValue[1, 1] = historyValue[0, 1];
                case 5:
                    break;
            }

            // 계산 기록에 표시
            txtExp01.Text = historyValue[0, 0];
            txtExp02.Text = historyValue[1, 0];
            txtExp03.Text = historyValue[2, 0];
            txtExp04.Text = historyValue[3, 0];
            txtExp05.Text = historyValue[4, 0];
            txtResult01.Text = historyValue[0, 1];
            txtResult02.Text = historyValue[1, 1];
            txtResult03.Text = historyValue[2, 1];
            txtResult04.Text = historyValue[3, 1];
            txtResult05.Text = historyValue[4, 1];


            // 디버깅
            label1.Text = operand1;
            label2.Text = operand2;
            label3.Text = operand3;
            label4.Text = operator1.ToString();
            label5.Text = operator2.ToString();
            txtListCount.Text = listCount.ToString();   // 디버깅

            // 초기화
            temp = "";
            operand1 = null;
            operand2 = null;
            operand3 = null;
            operator1 = 0;
            operator2 = 0;
            resultCount = true;    // 결과 이력 카운트

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void resultList01_Click(object sender, EventArgs e)
        {

        }

        private void txtResult_Click(object sender, EventArgs e)
        {

        }

        private void Frame_Load(object sender, EventArgs e)
        {

        }

        private void txtResult02_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void actMemory_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtExp02_Click(object sender, EventArgs e)
        {

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
