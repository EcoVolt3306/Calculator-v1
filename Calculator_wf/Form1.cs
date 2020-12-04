using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator_wf
{
    public partial class Frame : Form
    {
        // 연산자는 1:덧셈, 2:뺄셈, 3:곱셈, 4:나눗셈으로 정의
        int operator1, operator2 = 0;   // 연산자
        double operand1, operand2, operand3 = 0;    // 피연산자
        string temp, txtTemp = null;    // 임시
        double Result = 0;  // 결과값

        string[,] historyValue = new string[100,2];    // 2차원 배열 = 계산 기록
        Label m;    // 저장기록에 사용할 컨트롤 자료형

        int listCount = 1;  // 계산 기록 카운트 횟수
        Boolean pressResult = false;    // = 버튼 누른 횟수

        // 딕셔너리 생성
        Dictionary<int, Label> dicList = new Dictionary<int, Label>();
        Dictionary<int, Label> dicResult = new Dictionary<int, Label>();

        public Frame()
        {
            InitializeComponent();

            // 저장 기록에 Label 20개 추가
            for (int i = 0; i < 20; i++)
            {
                Label MemoryValue = new Label();
                MemoryValue.Font = new System.Drawing.Font("넥슨Lv2고딕", 8.25F);
                MemoryValue.Location = new Point(20, (i * 50) + 10);
                MemoryValue.Name = "MemoryValue" + i;
                MemoryValue.Size = new System.Drawing.Size(205, 10);
                MemoryValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                MemoryValue.TabIndex = 33;
                MemoryValue.AutoSize = false;
                MemoryValue.Text = "";
                actMemory.Controls.Add(MemoryValue);

                // MemoryValue를 쉽게 찾을 수 있도록 딕셔너리를 통해 인덱스 연결
                this.dicList.Add(i, MemoryValue);

                Label MemoryResult = new Label();
                MemoryResult.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
                MemoryResult.Location = new Point(20, (i * 50)+10);
                MemoryResult.Name = "MemoryResult" + i;
                MemoryResult.Size = new System.Drawing.Size(205, 50);
                MemoryResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                MemoryResult.TabIndex = 33;
                MemoryResult.AutoSize = false;
                MemoryResult.Text = "";
                actMemory.Controls.Add(MemoryResult);

                // MemoryValue를 쉽게 찾을 수 있도록 딕셔너리를 통해 인덱스 연결
                this.dicResult.Add(i, MemoryResult);
            }

            m = dicList[0]; // m 변수를 Label 타입으로 초기화

            // 딕셔너리를 통해 접근
            foreach (var kvp in this.dicList)
            {
                Console.WriteLine(string.Format("{0}, {1}", kvp.Key, kvp.Value.Text));

            }

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                temp = temp.Remove(temp.Length - 1);
                txtResult.Text = temp.ToString();
                if(txtResult.Text == "")
                {
                    txtResult.Text = "0";
                    temp = null;
                }
            }

            // 합산 후 눌리면 초기화
            if (pressResult == true)
            {
                temp = null;
                txtExp.Text = "";
                pressResult = false;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            // CE 버튼
            if(temp != null)
            {
                temp = null;
                txtResult.Text = "0";
            }

            // 합산 후 눌리면 초기화
            if (pressResult == true)
            {
                temp = null;
                txtExp.Text = "";
                txtResult.Text = "0";
                pressResult = false;
            }
        }
        private void buttonPM_Click(object sender, EventArgs e)
        {
            // 플러스 마이너스 기호 버튼

            if(temp != null)
            {
                double pm = double.Parse(temp);
                temp = (-pm).ToString();
                txtResult.Text = temp;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            // 덧셈 버튼 기능

            if(pressResult == true)    // 결과 이력 초기화
            {
                txtExp.Text = "";
                pressResult = false;    
            }

            //// 이미 다른 연산자가 존재할 경우 처리
            //if ((operator2 == 1 || operator1 == 2 || operator1 == 3 || operator1 == 4) && temp == "")
            //{
            //    operator2 = 1;  // 연산자 교체

            //    // Display : 기존 연산자 제거
            //    txtTemp = txtExp.Text;
            //    txtTemp = txtTemp.Remove(txtTemp.Length - 3);
            //    txtExp.Text = txtTemp;
            //    // Display : 덧셈 연산자 추가
            //    txtExp.Text += " + ";

            //    return;
            //} else if ((operator1 == 1 || operator1 == 2 || operator1 == 3 || operator1 == 4) && temp == "")
            //{
            //    operator1 = 1;  // 덧셈 지정

            //    // Display : 기존 연산자 제거
            //    txtTemp = txtExp.Text;
            //    txtTemp = txtTemp.Remove(txtTemp.Length - 3);
            //    txtExp.Text = txtTemp;
            //    // Display : 덧셈 연산자 추가
            //    txtExp.Text += " + ";

            //    return;
            //}

            if (operator1 == 0)
            {
                operand1 = double.Parse(temp);        // 피연산자1에 값을 저장
                operator1 = 1;          // 1==Add
            }
            else if (operator2 == 0)
            {
                operand2 = double.Parse(temp);       // 피연산자2에 값을 저장
                operator2 = 1;          // 1==Add
            }
            else if (operator1 != 0 && operator2 != 0)
            {
                operand3 = double.Parse(temp);       // 피연산자1에 값을 저장
            }


            temp += " + ";               // temp에 + 기호 추가
            txtExp.Text += temp;    // 수식값에 temp값 추가
            temp = null;                  // temp 초기화

            // 디버깅
            label1.Text = operand1.ToString();
            label2.Text = operand2.ToString();
            label3.Text = operand3.ToString();
            label4.Text = operator1.ToString();
            label5.Text = operator2.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            // 뺄셈 버튼 기능

            if (pressResult == true)    // 결과 이력 초기화
            {
                txtExp.Text = "";
                pressResult = false;
            }

            // 이미 다른 연산자가 존재할 경우 처리
            if ((operator2 == 1 || operator1 == 2 || operator1 == 3 || operator1 == 4) && temp == "")
            {
                operator2 = 2;  // 연산자 교체

                // Display : 기존 연산자 제거
                txtTemp = txtExp.Text;
                txtTemp = txtTemp.Remove(txtTemp.Length - 3);
                txtExp.Text = txtTemp;
                // Display : 뺄셈 연산자 추가
                txtExp.Text += " - ";

                return;
            }
            else if ((operator1 == 1 || operator1 == 2 || operator1 == 3 || operator1 == 4) && temp == "")
            {
                operator1 = 2;  // 덧셈 지정

                // Display : 기존 연산자 제거
                txtTemp = txtExp.Text;
                txtTemp = txtTemp.Remove(txtTemp.Length - 3);
                txtExp.Text = txtTemp;
                // Display : 뺄셈 연산자 추가
                txtExp.Text += " - ";

                return;
            }

            if (operand1 == 0)
            {
                operand1 = double.Parse(temp);        // 피연산자1에 값을 저장
                operator1 = 2;          // 2==Minus
            }
            else if (operand2 == 0)
            {
                operand2 = double.Parse(temp);        // 피연산자2에 값을 저장
                operator2 = 2;        // 2==Minus
            }
            else if (operand3 == 0)
            {
                operand3 = double.Parse(temp);        // 피연산자1에 값을 저장
            }


            temp += " - ";               // temp에 + 기호 추가
            txtExp.Text += temp;    // 수식값에 temp값 추가
            temp = "";                  // temp 초기화

            // 디버깅
            label1.Text = operand1.ToString();
            label2.Text = operand2.ToString();
            label3.Text = operand3.ToString();
            label4.Text = operator1.ToString();
            label5.Text = operator2.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            // 곱셈 버튼 기능

            if (pressResult == true)    // 결과 이력 초기화
            {
                txtExp.Text = "";
                pressResult = false;
            }

            // 이미 다른 연산자가 존재할 경우 처리
            if ((operator2 == 1 || operator1 == 2 || operator1 == 3 || operator1 == 4) && temp == "")
            {
                operator2 = 3;  // 연산자 교체

                // Display : 기존 연산자 제거
                txtTemp = txtExp.Text;
                txtTemp = txtTemp.Remove(txtTemp.Length - 3);
                txtExp.Text = txtTemp;
                // Display : 곱셈 연산자 추가
                txtExp.Text += " x ";

                return;
            }
            else if ((operator1 == 1 || operator1 == 2 || operator1 == 3 || operator1 == 4) && temp == "")
            {
                operator1 = 3;  // 덧셈 지정

                // Display : 기존 연산자 제거
                txtTemp = txtExp.Text;
                txtTemp = txtTemp.Remove(txtTemp.Length - 3);
                txtExp.Text = txtTemp;
                // Display : 곱셈 연산자 추가
                txtExp.Text += " x ";

                return;
            }

            if (operand1 == 0)
            {
                operand1 = double.Parse(temp);        // 피연산자1에 값을 저장
                operator1 = 3;              // 3==Multiply
            }
            else if (operand2 == 0)
            {
                operand2 = double.Parse(temp);       // 피연산자2에 값을 저장
                operator2 = 3;               // 3==Multiply
            }
            else if (operand3 == 0)
            {
                operand3 = double.Parse(temp);      // 피연산자1에 값을 저장
            }

            temp += " x ";               // temp에 + 기호 추가
            txtExp.Text += temp;    // 수식값에 temp값 추가
            temp = "";                  // temp 초기화

            // 디버깅
            label1.Text = operand1.ToString();
            label2.Text = operand2.ToString();
            label3.Text = operand3.ToString();
            label4.Text = operator1.ToString();
            label5.Text = operator2.ToString();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            // 나눗셈 버튼 기능
            
            if (pressResult == true)    // 결과 이력 초기화
            {
                txtExp.Text = "";
                pressResult = false;
            }

            // 이미 다른 연산자가 존재할 경우 처리
            if ((operator2 == 1 || operator1 == 2 || operator1 == 3 || operator1 == 4) && temp == "")
            {
                operator2 = 4;  // 연산자 교체

                // Display : 기존 연산자 제거
                txtTemp = txtExp.Text;
                txtTemp = txtTemp.Remove(txtTemp.Length - 3);
                txtExp.Text = txtTemp;
                // Display : 나눗셈 연산자 추가
                txtExp.Text += " ÷ ";

                return;
            }
            else if ((operator1 == 1 || operator1 == 2 || operator1 == 3 || operator1 == 4) && temp == "")
            {
                operator1 = 4;  // 덧셈 지정

                // Display : 기존 연산자 제거
                txtTemp = txtExp.Text;
                txtTemp = txtTemp.Remove(txtTemp.Length - 3);
                txtExp.Text = txtTemp;
                // Display : 나눗셈 연산자 추가
                txtExp.Text += " ÷ ";

                return;
            }

            if (operand1 == 0)
            {
                operand1 = double.Parse(temp);       // 피연산자1에 값을 저장
                operator1 = 4;              // 4==Division
            }
            else if (operand2 == 0)
            {
                operand2 = double.Parse(temp);      // 피연산자2에 값을 저장
                operator2 = 4;               // 4==Division
            }
            else if (operand3 == 0)
            {
                operand3 = double.Parse(temp);     // 피연산자1에 값을 저장
            }

            temp += " ÷ ";               // temp에 + 기호 추가
            txtExp.Text += temp;    // 수식값에 temp값 추가
            temp = "";                  // temp 초기화

            // 디버깅
            label1.Text = operand1.ToString();
            label2.Text = operand2.ToString();
            label3.Text = operand3.ToString();
            label4.Text = operator1.ToString();
            label5.Text = operator2.ToString();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            // Clear : 초기화
            temp = null;
            txtExp.Text = "";
            txtResult.Text = "0";
            operand1 = 0;
            operand2 = 0;
            operand3 = 0;
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
            if (temp == "")
            {
                //if (operand1 == null)
                //{
                //    operand1 = temp;
                //}
                //else if (operand2 == null)
                //{
                //    operand2 = temp;
                //}
                //else if (operand3 == null)
                //{
                //    operand3 = temp;
                //}
            }

            // 피연산자 비존재할 경우 오류 방지
            //if (operator1 != null && operand2 == null)
            //{
            //    operand2 = operand1;
            //} else if (operator2 != null && operand3 == null)
            //{
            //    operand3 = operand2;
            //    // 오류 방지는 할 수 있으나, 실제 계산기 결과랑 다름(추후 수정예정)
            //}

            // 남은 피연산자(temp)값 적용하기
            if (operand2 == 0 && temp != null)
            {
                operand2 = double.Parse(temp);
            } else if (operand3 == 0 && temp != null)
            {
                operand3 = double.Parse(temp);
            }

            // 첫번째 연산자 계산 조건문
            if (operator1 == 1)
            {
                Result = operand1 + operand2;
            }
            else if (operator1 == 2)
            {
                Result = operand1 - operand2;
            }
            else if (operator1 == 3)
            {
                Result = operand1 * operand2;
            }
            else if (operator1 == 4)
            {
                // 0으로 나누려고 시도하는 경우 처리
                if (operand2 == 0)
                {
                    txtResult.Text = "0 으로 나눌 수 없습니다.";
                    temp = null;
                    operand1 = 0;
                    operand2 = 0;
                    operand3 = 0;
                    operator1 = 0;
                    operator2 = 0;
                    pressResult = true;    // 결과 이력 카운트
                    return;
                }

                Result = operand1 / operand2;
            }

            // 두번째 연산자 계산 조건문
            if (operator2 == 1)
            {
                Result += operand3;
            }
            else if (operator2 == 2)
            {
                Result -= operand3;
            }
            else if (operator2 == 3)
            {
                Result *= operand3;
            }
            else if (operator2 == 4)
            {
                // 0으로 나누려고 시도하는 경우 처리
                if (operand3 == 0)
                {
                    txtResult.Text = "0 으로 나눌 수 없습니다.";
                    temp = null;
                    operand1 = 0;
                    operand2 = 0;
                    operand3 = 0;
                    operator1 = 0;
                    operator2 = 0;
                    pressResult = true;    // 결과 이력 카운트
                    return;
                }
                Result /= operand3;
            }

            //피연산자 수의 따른 연산
            if (operand3 != 0 && operator2 != 0)   // 3 존재의 경우
            {
                txtExp.Text += operand3 + " =  ";
                txtResult.Text = Result.ToString();
            }
            else if (operand2 != 0 && operator1 != 0)    // 3 미존재의 경우
            {
                txtExp.Text += operand2 + " =  ";
                txtResult.Text = Result.ToString();
            }





            // 계산 기록에 저장
            if (listCount == 1) // 최초 1회
            {
                historyValue[0, 0] = txtExp.Text;
                historyValue[0, 1] = txtResult.Text;

                // 저장 기록에 저장
                dicList[0].Text = historyValue[0,0];
                dicResult[0].Text = historyValue[0, 1];

            }
            else if (listCount > 1)   // 기록 옮기자!
            {
                for (int i = listCount-1; i >= 0; i--)
                {
                    if(i != 0)
                    {
                        historyValue[i, 0] = historyValue[i - 1, 0];
                        historyValue[i, 1] = historyValue[i - 1, 1];
                        dicList[i].Text = historyValue[i, 0];   // 저장 기록
                        dicResult[i].Text = historyValue[i, 1];
                    } else if (i == 0)                                      // 마지막 처리
                    {
                        historyValue[0, 0] = txtExp.Text;
                        historyValue[0, 1] = txtResult.Text;
                        dicList[0].Text = historyValue[0, 0];   // 저장 기록
                        dicResult[0].Text = historyValue[0, 1];
                    }
                }
            }
            listCount++;    // = 카운트 횟수 1 증가



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
            label1.Text = operand1.ToString();
            label2.Text = operand2.ToString();
            label3.Text = operand3.ToString();
            label4.Text = operator1.ToString();
            label5.Text = operator2.ToString();
            txtListCount.Text = listCount.ToString();   // 디버깅

            // 초기화
            temp = null;
            operand1 = 0;
            operand2 = 0;
            operand3 = 0;
            operator1 = 0;
            operator2 = 0;
            pressResult = true;    // 결과 이력 카운트

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

        private void txtResult03_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
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
