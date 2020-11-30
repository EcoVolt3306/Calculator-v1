using System;
using System.Windows.Forms;

namespace Calculator_wf
{
    public partial class Form1 : Form
    {
        string operand1;    // 피연산자1
        string operand2;    // 피연산자2

        bool operand_check = false; // 피연산자1 또는 2 중 무엇을 사용할지 확인

        double result;      // 결과 값

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int data1 = 15;
            int data2 = 10;
            int result = 0;

            data1 = int.Parse(textBox1.Text);
            data2 = int.Parse(textBox2.Text);

            result = data1 + data2;
            label1.Text = result.ToString();

        }

    }
}
