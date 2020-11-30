
namespace Calculator_wf
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonPM = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCE.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonCE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCE.Location = new System.Drawing.Point(12, 67);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(45, 35);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonC.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonC.Location = new System.Drawing.Point(63, 67);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(45, 35);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDelete.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(114, 67);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(45, 35);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "◀";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDivision.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonDivision.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDivision.Location = new System.Drawing.Point(165, 67);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(45, 35);
            this.buttonDivision.TabIndex = 3;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = false;
            // 
            // buttonNum7
            // 
            this.buttonNum7.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum7.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum7.Location = new System.Drawing.Point(12, 108);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(45, 35);
            this.buttonNum7.TabIndex = 4;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = false;
            this.buttonNum7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum8.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum8.Location = new System.Drawing.Point(63, 108);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(45, 35);
            this.buttonNum8.TabIndex = 5;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = false;
            // 
            // buttonNum9
            // 
            this.buttonNum9.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum9.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum9.Location = new System.Drawing.Point(114, 108);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(45, 35);
            this.buttonNum9.TabIndex = 6;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = false;
            // 
            // buttonNum4
            // 
            this.buttonNum4.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum4.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum4.Location = new System.Drawing.Point(12, 149);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(45, 35);
            this.buttonNum4.TabIndex = 7;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = false;
            this.buttonNum4.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonNum5
            // 
            this.buttonNum5.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum5.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum5.Location = new System.Drawing.Point(63, 149);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(45, 35);
            this.buttonNum5.TabIndex = 8;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = false;
            // 
            // buttonNum6
            // 
            this.buttonNum6.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum6.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum6.Location = new System.Drawing.Point(114, 149);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(45, 35);
            this.buttonNum6.TabIndex = 9;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = false;
            // 
            // buttonNum1
            // 
            this.buttonNum1.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum1.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum1.Location = new System.Drawing.Point(12, 190);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(45, 35);
            this.buttonNum1.TabIndex = 10;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = false;
            // 
            // buttonNum2
            // 
            this.buttonNum2.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum2.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum2.Location = new System.Drawing.Point(63, 190);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(45, 35);
            this.buttonNum2.TabIndex = 11;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = false;
            // 
            // buttonNum3
            // 
            this.buttonNum3.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNum3.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonNum3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNum3.Location = new System.Drawing.Point(114, 190);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(45, 35);
            this.buttonNum3.TabIndex = 12;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = false;
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonMultiply.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonMultiply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMultiply.Location = new System.Drawing.Point(165, 108);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(45, 35);
            this.buttonMultiply.TabIndex = 13;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonPlus.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonPlus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlus.Location = new System.Drawing.Point(165, 149);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(45, 35);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonMinus.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonMinus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMinus.Location = new System.Drawing.Point(165, 190);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(45, 35);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            // 
            // buttonPM
            // 
            this.buttonPM.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonPM.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonPM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPM.Location = new System.Drawing.Point(12, 231);
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
            this.buttonNum0.Location = new System.Drawing.Point(63, 231);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(45, 35);
            this.buttonNum0.TabIndex = 17;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = false;
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDot.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F);
            this.buttonDot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDot.Location = new System.Drawing.Point(114, 231);
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
            this.buttonResult.Location = new System.Drawing.Point(165, 231);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(45, 35);
            this.buttonResult.TabIndex = 19;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 281);
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
            this.Name = "Form1";
            this.Text = "WF 계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonPM;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonResult;
    }
}

