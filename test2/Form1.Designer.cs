namespace test2
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
            this.lbl_animal = new System.Windows.Forms.Label();
            this.bt_animal = new System.Windows.Forms.Button();
            this.ckb_animal = new System.Windows.Forms.CheckBox();
            this.cob_fruit = new System.Windows.Forms.ComboBox();
            this.tb_fruit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_fruit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_animal
            // 
            this.lbl_animal.AutoSize = true;
            this.lbl_animal.Location = new System.Drawing.Point(175, 248);
            this.lbl_animal.Name = "lbl_animal";
            this.lbl_animal.Size = new System.Drawing.Size(78, 32);
            this.lbl_animal.TabIndex = 0;
            this.lbl_animal.Text = "label1";
            // 
            // bt_animal
            // 
            this.bt_animal.Location = new System.Drawing.Point(255, 92);
            this.bt_animal.Name = "bt_animal";
            this.bt_animal.Size = new System.Drawing.Size(144, 58);
            this.bt_animal.TabIndex = 1;
            this.bt_animal.Text = "확인버튼";
            this.bt_animal.UseVisualStyleBackColor = true;
            this.bt_animal.Click += new System.EventHandler(this.bt_animal_Click_1);
            // 
            // ckb_animal
            // 
            this.ckb_animal.Location = new System.Drawing.Point(41, 92);
            this.ckb_animal.Name = "ckb_animal";
            this.ckb_animal.Size = new System.Drawing.Size(173, 58);
            this.ckb_animal.TabIndex = 2;
            this.ckb_animal.Text = "고양이";
            this.ckb_animal.UseVisualStyleBackColor = true;
            // 
            // cob_fruit
            // 
            this.cob_fruit.FormattingEnabled = true;
            this.cob_fruit.Items.AddRange(new object[] {
            "선택지",
            "사과",
            "배",
            "복숭아",
            "딸기",
            "귤"});
            this.cob_fruit.Location = new System.Drawing.Point(54, 94);
            this.cob_fruit.Name = "cob_fruit";
            this.cob_fruit.Size = new System.Drawing.Size(161, 40);
            this.cob_fruit.TabIndex = 3;
            this.cob_fruit.SelectedIndexChanged += new System.EventHandler(this.cob_fruit_SelectedIndexChanged);
            // 
            // tb_fruit
            // 
            this.tb_fruit.Location = new System.Drawing.Point(74, 256);
            this.tb_fruit.Name = "tb_fruit";
            this.tb_fruit.Size = new System.Drawing.Size(382, 39);
            this.tb_fruit.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_animal);
            this.groupBox1.Controls.Add(this.bt_animal);
            this.groupBox1.Controls.Add(this.lbl_animal);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(59, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 385);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_fruit);
            this.groupBox2.Controls.Add(this.cob_fruit);
            this.groupBox2.Controls.Add(this.tb_fruit);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(631, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 380);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btn_fruit
            // 
            this.btn_fruit.Location = new System.Drawing.Point(312, 77);
            this.btn_fruit.Name = "btn_fruit";
            this.btn_fruit.Size = new System.Drawing.Size(144, 58);
            this.btn_fruit.TabIndex = 3;
            this.btn_fruit.Text = "확인버튼";
            this.btn_fruit.UseVisualStyleBackColor = true;
            this.btn_fruit.Click += new System.EventHandler(this.btn_fruit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_animal;
        private System.Windows.Forms.Button bt_animal;
        private System.Windows.Forms.CheckBox ckb_animal;
        private System.Windows.Forms.ComboBox cob_fruit;
        private System.Windows.Forms.TextBox tb_fruit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_fruit;
    }
}

