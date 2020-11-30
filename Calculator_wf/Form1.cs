using System;
using System.Windows.Forms;

namespace Calculator_wf
{
    public partial class Frame : Form
    {
        string operand1;    // 피연산자1
        string operand2;    // 피연산자2
        string exp="";         // 수식값
        string expTemp="";    // 수식 임시값

        bool operand_check = false; // 피연산자1 또는 2 중 무엇을 사용할지 확인

        double result;      // 결과 값

        public Frame()
        {
            InitializeComponent();
        }


        private void buttonResult_Click(object sender, EventArgs e)
        {
            //int data1 = 15;
            //int data2 = 10;
            //int result = 0;

            //data1 = int.Parse(textBox1.Text);
            //data2 = int.Parse(textBox2.Text);

            //result = data1 + data2;
            //txtResult.Text = result.ToString();

        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            exp += "1";
            txtExp.Text = exp.ToString();
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            exp += "2";
            txtExp.Text = exp.ToString();
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            exp += "3";
            txtExp.Text = exp.ToString();
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            exp += "4";
            txtExp.Text = exp.ToString();
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            exp += "5";
            txtExp.Text = exp.ToString();
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            exp += "6";
            txtExp.Text = exp.ToString();
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            exp += "7";
            txtExp.Text = exp.ToString();
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            exp += "8";
            txtExp.Text = exp.ToString();
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            exp += "9";
            txtExp.Text = exp.ToString();
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            if(txtExp.Text == "0")
            {

            }
            else
            {
                exp += "0";
                txtExp.Text = exp.ToString();
            }

        }

        private void txtExp_Click(object sender, EventArgs e)
        {

        }
    }
}
