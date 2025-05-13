namespace basic
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_name = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.btn_2 = new System.Windows.Forms.Button();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_1.AutoEllipsis = true;
            this.lbl_1.AutoSize = true;
            this.lbl_1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(48, 44);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(129, 30);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "텍스트 출력";
            // 
            // btn_name
            // 
            this.btn_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_name.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_name.Location = new System.Drawing.Point(648, 148);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(266, 204);
            this.btn_name.TabIndex = 1;
            this.btn_name.Text = "클릭";
            this.btn_name.UseVisualStyleBackColor = false;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_name.BackColor = System.Drawing.SystemColors.Window;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(38, 178);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(562, 146);
            this.tb_name.TabIndex = 2;
            // 
            // lbl_2
            // 
            this.lbl_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_2.AutoEllipsis = true;
            this.lbl_2.AutoSize = true;
            this.lbl_2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(228, 44);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(129, 30);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "텍스트 출력";
            // 
            // lbl_3
            // 
            this.lbl_3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_3.AutoEllipsis = true;
            this.lbl_3.AutoSize = true;
            this.lbl_3.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.Location = new System.Drawing.Point(422, 44);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(129, 30);
            this.lbl_3.TabIndex = 4;
            this.lbl_3.Text = "텍스트 출력";
            // 
            // lbl_4
            // 
            this.lbl_4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_4.AutoEllipsis = true;
            this.lbl_4.AutoSize = true;
            this.lbl_4.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4.Location = new System.Drawing.Point(617, 44);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(129, 30);
            this.lbl_4.TabIndex = 5;
            this.lbl_4.Text = "텍스트 출력";
            // 
            // lbl_5
            // 
            this.lbl_5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_5.AutoEllipsis = true;
            this.lbl_5.AutoSize = true;
            this.lbl_5.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_5.Location = new System.Drawing.Point(48, 109);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(129, 30);
            this.lbl_5.TabIndex = 6;
            this.lbl_5.Text = "텍스트 출력";
            // 
            // btn_2
            // 
            this.btn_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_2.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(648, 358);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(266, 204);
            this.btn_2.TabIndex = 7;
            this.btn_2.Text = "버튼";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // tb_2
            // 
            this.tb_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_2.BackColor = System.Drawing.SystemColors.Window;
            this.tb_2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_2.Location = new System.Drawing.Point(35, 381);
            this.tb_2.Multiline = true;
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(565, 163);
            this.tb_2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 646);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.lbl_1);
            this.Name = "Form1";
            this.Text = "0";
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.TextBox tb_2;
    }
}

