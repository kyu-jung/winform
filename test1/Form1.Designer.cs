namespace test1
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
            this.chk_test1 = new System.Windows.Forms.CheckBox();
            this.chk_test2 = new System.Windows.Forms.CheckBox();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.lbl_test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_test1
            // 
            this.chk_test1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_test1.Location = new System.Drawing.Point(128, 237);
            this.chk_test1.Name = "chk_test1";
            this.chk_test1.Size = new System.Drawing.Size(454, 314);
            this.chk_test1.TabIndex = 0;
            this.chk_test1.Text = "짜장면";
            this.chk_test1.UseVisualStyleBackColor = true;
            this.chk_test1.CheckedChanged += new System.EventHandler(this.chk_test1_CheckedChanged);
            // 
            // chk_test2
            // 
            this.chk_test2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_test2.Location = new System.Drawing.Point(690, 237);
            this.chk_test2.Name = "chk_test2";
            this.chk_test2.Size = new System.Drawing.Size(454, 314);
            this.chk_test2.TabIndex = 1;
            this.chk_test2.Text = "짬뽕";
            this.chk_test2.UseVisualStyleBackColor = true;
            this.chk_test2.CheckedChanged += new System.EventHandler(this.chk_test2_CheckedChanged);
            // 
            // tb_test
            // 
            this.tb_test.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_test.Location = new System.Drawing.Point(284, 679);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(668, 35);
            this.tb_test.TabIndex = 2;
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_test.Location = new System.Drawing.Point(316, 104);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(549, 32);
            this.lbl_test.TabIndex = 3;
            this.lbl_test.Text = "짜장면과 짬뽕 중 하나를 선택하시오.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 807);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.tb_test);
            this.Controls.Add(this.chk_test2);
            this.Controls.Add(this.chk_test1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_test1;
        private System.Windows.Forms.CheckBox chk_test2;
        private System.Windows.Forms.TextBox tb_test;
        private System.Windows.Forms.Label lbl_test;
    }
}

