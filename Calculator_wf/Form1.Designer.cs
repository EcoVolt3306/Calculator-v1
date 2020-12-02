
namespace Calculator_wf
{
    partial class Frame
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPM = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.Label();
            this.txtExp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExp01 = new System.Windows.Forms.Label();
            this.txtResult01 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.actList = new System.Windows.Forms.TabPage();
            this.txtResult02 = new System.Windows.Forms.Label();
            this.txtExp02 = new System.Windows.Forms.Label();
            this.txtResult03 = new System.Windows.Forms.Label();
            this.txtExp03 = new System.Windows.Forms.Label();
            this.txtResult04 = new System.Windows.Forms.Label();
            this.txtExp04 = new System.Windows.Forms.Label();
            this.txtResult05 = new System.Windows.Forms.Label();
            this.txtExp05 = new System.Windows.Forms.Label();
            this.actMemory = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtListCount = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.actList.SuspendLayout();
            this.actMemory.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCE.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonCE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCE.Location = new System.Drawing.Point(12, 86);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(45, 35);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonC.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonC.Location = new System.Drawing.Point(63, 86);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(45, 35);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDelete.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(114, 86);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(45, 35);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "◀";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDivision.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonDivision.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDivision.Location = new System.Drawing.Point(165, 86);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(45, 35);
            this.buttonDivision.TabIndex = 3;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonNum7
            // 
            this.buttonNum7.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum7.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum7.Location = new System.Drawing.Point(12, 127);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(45, 35);
            this.buttonNum7.TabIndex = 4;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = false;
            this.buttonNum7.Click += new System.EventHandler(this.buttonNum7_Click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum8.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum8.Location = new System.Drawing.Point(63, 127);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(45, 35);
            this.buttonNum8.TabIndex = 5;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = false;
            this.buttonNum8.Click += new System.EventHandler(this.buttonNum8_Click);
            // 
            // buttonNum9
            // 
            this.buttonNum9.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum9.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum9.Location = new System.Drawing.Point(114, 127);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(45, 35);
            this.buttonNum9.TabIndex = 6;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = false;
            this.buttonNum9.Click += new System.EventHandler(this.buttonNum9_Click);
            // 
            // buttonNum4
            // 
            this.buttonNum4.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum4.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum4.Location = new System.Drawing.Point(12, 168);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(45, 35);
            this.buttonNum4.TabIndex = 7;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = false;
            this.buttonNum4.Click += new System.EventHandler(this.buttonNum4_Click);
            // 
            // buttonNum5
            // 
            this.buttonNum5.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum5.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum5.Location = new System.Drawing.Point(63, 168);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(45, 35);
            this.buttonNum5.TabIndex = 8;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = false;
            this.buttonNum5.Click += new System.EventHandler(this.buttonNum5_Click);
            // 
            // buttonNum6
            // 
            this.buttonNum6.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum6.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum6.Location = new System.Drawing.Point(114, 168);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(45, 35);
            this.buttonNum6.TabIndex = 9;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = false;
            this.buttonNum6.Click += new System.EventHandler(this.buttonNum6_Click);
            // 
            // buttonNum1
            // 
            this.buttonNum1.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum1.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum1.Location = new System.Drawing.Point(12, 209);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(45, 35);
            this.buttonNum1.TabIndex = 10;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = false;
            this.buttonNum1.Click += new System.EventHandler(this.buttonNum1_Click);
            // 
            // buttonNum2
            // 
            this.buttonNum2.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum2.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum2.Location = new System.Drawing.Point(63, 209);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(45, 35);
            this.buttonNum2.TabIndex = 11;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = false;
            this.buttonNum2.Click += new System.EventHandler(this.buttonNum2_Click);
            // 
            // buttonNum3
            // 
            this.buttonNum3.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum3.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum3.Location = new System.Drawing.Point(114, 209);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(45, 35);
            this.buttonNum3.TabIndex = 12;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = false;
            this.buttonNum3.Click += new System.EventHandler(this.buttonNum3_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonMultiply.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonMultiply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMultiply.Location = new System.Drawing.Point(165, 127);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(45, 35);
            this.buttonMultiply.TabIndex = 13;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonPlus.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonPlus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlus.Location = new System.Drawing.Point(165, 168);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(45, 35);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonMinus.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonMinus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMinus.Location = new System.Drawing.Point(165, 209);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(45, 35);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPM
            // 
            this.buttonPM.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonPM.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonPM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPM.Location = new System.Drawing.Point(12, 250);
            this.buttonPM.Name = "buttonPM";
            this.buttonPM.Size = new System.Drawing.Size(45, 35);
            this.buttonPM.TabIndex = 16;
            this.buttonPM.Text = "±";
            this.buttonPM.UseVisualStyleBackColor = false;
            // 
            // buttonNum0
            // 
            this.buttonNum0.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum0.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum0.Location = new System.Drawing.Point(63, 250);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(45, 35);
            this.buttonNum0.TabIndex = 17;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = false;
            this.buttonNum0.Click += new System.EventHandler(this.buttonNum0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDot.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonDot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDot.Location = new System.Drawing.Point(114, 250);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(45, 35);
            this.buttonDot.TabIndex = 18;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonResult.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonResult.Location = new System.Drawing.Point(165, 250);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(45, 35);
            this.buttonResult.TabIndex = 19;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("넥슨Lv2고딕", 22F);
            this.txtResult.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.txtResult.Location = new System.Drawing.Point(12, 46);
            this.txtResult.MaximumSize = new System.Drawing.Size(220, 30);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(198, 30);
            this.txtResult.TabIndex = 20;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtResult.Click += new System.EventHandler(this.txtResult_Click);
            // 
            // txtExp
            // 
            this.txtExp.Font = new System.Drawing.Font("넥슨Lv2고딕", 9F);
            this.txtExp.Location = new System.Drawing.Point(15, 25);
            this.txtExp.Name = "txtExp";
            this.txtExp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExp.Size = new System.Drawing.Size(192, 21);
            this.txtExp.TabIndex = 23;
            this.txtExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "operand1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "operand2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "operand3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "operator1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "operator2";
            // 
            // txtExp01
            // 
            this.txtExp01.Font = new System.Drawing.Font("넥슨Lv2고딕", 8.25F);
            this.txtExp01.Location = new System.Drawing.Point(17, 24);
            this.txtExp01.Name = "txtExp01";
            this.txtExp01.Size = new System.Drawing.Size(225, 10);
            this.txtExp01.TabIndex = 29;
            this.txtExp01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtExp01.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtResult01
            // 
            this.txtResult01.Font = new System.Drawing.Font("넥슨Lv2고딕", 14F);
            this.txtResult01.Location = new System.Drawing.Point(6, 34);
            this.txtResult01.Name = "txtResult01";
            this.txtResult01.Size = new System.Drawing.Size(236, 23);
            this.txtResult01.TabIndex = 30;
            this.txtResult01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtResult01.Click += new System.EventHandler(this.resultList01_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label6.Location = new System.Drawing.Point(8, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(464, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Debug area ---------------------------------------------------------------";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.actList);
            this.tabControl1.Controls.Add(this.actMemory);
            this.tabControl1.Location = new System.Drawing.Point(216, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(256, 282);
            this.tabControl1.TabIndex = 37;
            // 
            // actList
            // 
            this.actList.Controls.Add(this.txtResult02);
            this.actList.Controls.Add(this.txtExp02);
            this.actList.Controls.Add(this.txtResult03);
            this.actList.Controls.Add(this.txtExp03);
            this.actList.Controls.Add(this.txtResult04);
            this.actList.Controls.Add(this.txtExp04);
            this.actList.Controls.Add(this.txtResult05);
            this.actList.Controls.Add(this.txtExp05);
            this.actList.Controls.Add(this.txtExp01);
            this.actList.Controls.Add(this.txtResult01);
            this.actList.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.actList.Location = new System.Drawing.Point(4, 22);
            this.actList.Name = "actList";
            this.actList.Padding = new System.Windows.Forms.Padding(3);
            this.actList.Size = new System.Drawing.Size(248, 256);
            this.actList.TabIndex = 0;
            this.actList.Text = "계산 기록(5)";
            this.actList.UseVisualStyleBackColor = true;
            this.actList.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtResult02
            // 
            this.txtResult02.Font = new System.Drawing.Font("넥슨Lv2고딕", 14F);
            this.txtResult02.Location = new System.Drawing.Point(6, 82);
            this.txtResult02.Name = "txtResult02";
            this.txtResult02.Size = new System.Drawing.Size(236, 23);
            this.txtResult02.TabIndex = 38;
            this.txtResult02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtExp02
            // 
            this.txtExp02.Font = new System.Drawing.Font("넥슨Lv2고딕", 8.25F);
            this.txtExp02.Location = new System.Drawing.Point(17, 72);
            this.txtExp02.Name = "txtExp02";
            this.txtExp02.Size = new System.Drawing.Size(225, 10);
            this.txtExp02.TabIndex = 37;
            this.txtExp02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResult03
            // 
            this.txtResult03.Font = new System.Drawing.Font("넥슨Lv2고딕", 14F);
            this.txtResult03.Location = new System.Drawing.Point(6, 129);
            this.txtResult03.Name = "txtResult03";
            this.txtResult03.Size = new System.Drawing.Size(236, 23);
            this.txtResult03.TabIndex = 36;
            this.txtResult03.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtResult03.Click += new System.EventHandler(this.txtResult03_Click);
            // 
            // txtExp03
            // 
            this.txtExp03.Font = new System.Drawing.Font("넥슨Lv2고딕", 8.25F);
            this.txtExp03.Location = new System.Drawing.Point(17, 119);
            this.txtExp03.Name = "txtExp03";
            this.txtExp03.Size = new System.Drawing.Size(225, 10);
            this.txtExp03.TabIndex = 35;
            this.txtExp03.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResult04
            // 
            this.txtResult04.Font = new System.Drawing.Font("넥슨Lv2고딕", 14F);
            this.txtResult04.Location = new System.Drawing.Point(6, 175);
            this.txtResult04.Name = "txtResult04";
            this.txtResult04.Size = new System.Drawing.Size(236, 23);
            this.txtResult04.TabIndex = 34;
            this.txtResult04.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtExp04
            // 
            this.txtExp04.Font = new System.Drawing.Font("넥슨Lv2고딕", 8.25F);
            this.txtExp04.Location = new System.Drawing.Point(17, 165);
            this.txtExp04.Name = "txtExp04";
            this.txtExp04.Size = new System.Drawing.Size(225, 10);
            this.txtExp04.TabIndex = 33;
            this.txtExp04.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtExp04.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtResult05
            // 
            this.txtResult05.Font = new System.Drawing.Font("넥슨Lv2고딕", 14F);
            this.txtResult05.Location = new System.Drawing.Point(6, 219);
            this.txtResult05.Name = "txtResult05";
            this.txtResult05.Size = new System.Drawing.Size(236, 23);
            this.txtResult05.TabIndex = 32;
            this.txtResult05.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtExp05
            // 
            this.txtExp05.Font = new System.Drawing.Font("넥슨Lv2고딕", 8.25F);
            this.txtExp05.Location = new System.Drawing.Point(17, 209);
            this.txtExp05.Name = "txtExp05";
            this.txtExp05.Size = new System.Drawing.Size(225, 10);
            this.txtExp05.TabIndex = 31;
            this.txtExp05.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // actMemory
            // 
            this.actMemory.AutoScroll = true;
            this.actMemory.AutoScrollMinSize = new System.Drawing.Size(0, 2000);
            this.actMemory.Controls.Add(this.label12);
            this.actMemory.Controls.Add(this.label11);
            this.actMemory.Controls.Add(this.label10);
            this.actMemory.Controls.Add(this.label9);
            this.actMemory.Controls.Add(this.label7);
            this.actMemory.Controls.Add(this.label8);
            this.actMemory.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.actMemory.Location = new System.Drawing.Point(4, 22);
            this.actMemory.Name = "actMemory";
            this.actMemory.Padding = new System.Windows.Forms.Padding(3);
            this.actMemory.Size = new System.Drawing.Size(248, 256);
            this.actMemory.TabIndex = 1;
            this.actMemory.Text = "저장 기록(20)";
            this.actMemory.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("넥슨Lv2고딕", 14F);
            this.label12.Location = new System.Drawing.Point(6, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 23);
            this.label12.TabIndex = 36;
            this.label12.Text = "0000";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("넥슨Lv2고딕", 8.25F);
            this.label11.Location = new System.Drawing.Point(20, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 10);
            this.label11.TabIndex = 35;
            this.label11.Text = "00000";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("넥슨Lv2고딕", 14F);
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "0000";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("넥슨Lv2고딕", 8.25F);
            this.label9.Location = new System.Drawing.Point(20, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 10);
            this.label9.TabIndex = 33;
            this.label9.Text = "00000";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("넥슨Lv2고딕", 8.25F);
            this.label7.Location = new System.Drawing.Point(20, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 10);
            this.label7.TabIndex = 31;
            this.label7.Text = "00000";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("넥슨Lv2고딕", 14F);
            this.label8.Location = new System.Drawing.Point(9, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "0000";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtListCount
            // 
            this.txtListCount.AutoSize = true;
            this.txtListCount.Location = new System.Drawing.Point(218, 326);
            this.txtListCount.Name = "txtListCount";
            this.txtListCount.Size = new System.Drawing.Size(70, 12);
            this.txtListCount.TabIndex = 38;
            this.txtListCount.Text = "listCount(0)";
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.txtListCount);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonNum0);
            this.Controls.Add(this.buttonPM);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonNum3);
            this.Controls.Add(this.buttonNum2);
            this.Controls.Add(this.buttonNum1);
            this.Controls.Add(this.buttonNum6);
            this.Controls.Add(this.buttonNum5);
            this.Controls.Add(this.buttonNum4);
            this.Controls.Add(this.buttonNum9);
            this.Controls.Add(this.buttonNum8);
            this.Controls.Add(this.buttonNum7);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frame";
            this.Text = "WF 계산기";
            this.Load += new System.EventHandler(this.Frame_Load);
            this.tabControl1.ResumeLayout(false);
            this.actList.ResumeLayout(false);
            this.actMemory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonNum7;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum9;
        private System.Windows.Forms.Button buttonNum4;
        private System.Windows.Forms.Button buttonNum5;
        private System.Windows.Forms.Button buttonNum6;
        private System.Windows.Forms.Button buttonNum1;
        private System.Windows.Forms.Button buttonNum2;
        private System.Windows.Forms.Button buttonNum3;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPM;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Label txtExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtResult01;
        private System.Windows.Forms.Label txtExp01;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage actList;
        private System.Windows.Forms.TabPage actMemory;
        private System.Windows.Forms.Label txtResult02;
        private System.Windows.Forms.Label txtExp02;
        private System.Windows.Forms.Label txtResult03;
        private System.Windows.Forms.Label txtExp03;
        private System.Windows.Forms.Label txtResult04;
        private System.Windows.Forms.Label txtExp04;
        private System.Windows.Forms.Label txtResult05;
        private System.Windows.Forms.Label txtExp05;
        private System.Windows.Forms.Label txtListCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

