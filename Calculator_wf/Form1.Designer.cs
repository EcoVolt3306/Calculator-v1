
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
            this.expList01 = new System.Windows.Forms.Label();
            this.resultList01 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCE.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonCE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCE.Location = new System.Drawing.Point(12, 71);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(45, 35);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonC.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonC.Location = new System.Drawing.Point(63, 71);
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
            this.buttonDelete.Location = new System.Drawing.Point(114, 71);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(45, 35);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "◀";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDivision.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonDivision.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDivision.Location = new System.Drawing.Point(165, 71);
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
            this.buttonNum7.Location = new System.Drawing.Point(12, 112);
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
            this.buttonNum8.Location = new System.Drawing.Point(63, 112);
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
            this.buttonNum9.Location = new System.Drawing.Point(114, 112);
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
            this.buttonNum4.Location = new System.Drawing.Point(12, 153);
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
            this.buttonNum5.Location = new System.Drawing.Point(63, 153);
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
            this.buttonNum6.Location = new System.Drawing.Point(114, 153);
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
            this.buttonNum1.Location = new System.Drawing.Point(12, 194);
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
            this.buttonNum2.Location = new System.Drawing.Point(63, 194);
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
            this.buttonNum3.Location = new System.Drawing.Point(114, 194);
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
            this.buttonMultiply.Location = new System.Drawing.Point(165, 112);
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
            this.buttonPlus.Location = new System.Drawing.Point(165, 153);
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
            this.buttonMinus.Location = new System.Drawing.Point(165, 194);
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
            this.buttonPM.Location = new System.Drawing.Point(12, 235);
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
            this.buttonNum0.Location = new System.Drawing.Point(63, 235);
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
            this.buttonDot.Location = new System.Drawing.Point(114, 235);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(45, 35);
            this.buttonDot.TabIndex = 18;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonResult.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonResult.Location = new System.Drawing.Point(165, 235);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(45, 35);
            this.buttonResult.TabIndex = 19;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("넥슨Lv2고딕", 22F);
            this.txtResult.Location = new System.Drawing.Point(168, 35);
            this.txtResult.Name = "txtResult";
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResult.Size = new System.Drawing.Size(33, 33);
            this.txtResult.TabIndex = 20;
            this.txtResult.Text = "0";
            // 
            // txtExp
            // 
            this.txtExp.AutoSize = true;
            this.txtExp.Font = new System.Drawing.Font("넥슨Lv2고딕", 14F);
            this.txtExp.Location = new System.Drawing.Point(186, 9);
            this.txtExp.Name = "txtExp";
            this.txtExp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExp.Size = new System.Drawing.Size(0, 21);
            this.txtExp.TabIndex = 23;
            this.txtExp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "label5";
            // 
            // expList01
            // 
            this.expList01.AutoSize = true;
            this.expList01.Font = new System.Drawing.Font("넥슨Lv2고딕", 8.25F);
            this.expList01.Location = new System.Drawing.Point(419, 35);
            this.expList01.Name = "expList01";
            this.expList01.Size = new System.Drawing.Size(37, 12);
            this.expList01.TabIndex = 29;
            this.expList01.Text = "label6";
            this.expList01.Click += new System.EventHandler(this.label6_Click);
            // 
            // resultList01
            // 
            this.resultList01.AutoSize = true;
            this.resultList01.Font = new System.Drawing.Font("넥슨Lv2고딕", 14F);
            this.resultList01.Location = new System.Drawing.Point(394, 58);
            this.resultList01.Name = "resultList01";
            this.resultList01.Size = new System.Drawing.Size(62, 21);
            this.resultList01.TabIndex = 30;
            this.resultList01.Text = "label7";
            this.resultList01.Click += new System.EventHandler(this.resultList01_Click);
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.resultList01);
            this.Controls.Add(this.expList01);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExp);
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
            this.Name = "Frame";
            this.Text = "WF 계산기";
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
        private System.Windows.Forms.Label expList01;
        private System.Windows.Forms.Label resultList01;
    }
}

