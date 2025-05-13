namespace basic_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chk_puppy = new System.Windows.Forms.CheckBox();
            this.chk_kitty = new System.Windows.Forms.CheckBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_puppy
            // 
            this.chk_puppy.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_puppy.Image = ((System.Drawing.Image)(resources.GetObject("chk_puppy.Image")));
            this.chk_puppy.Location = new System.Drawing.Point(81, 138);
            this.chk_puppy.Name = "chk_puppy";
            this.chk_puppy.Size = new System.Drawing.Size(432, 435);
            this.chk_puppy.TabIndex = 0;
            this.chk_puppy.Text = "강아지";
            this.chk_puppy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_puppy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chk_puppy.UseVisualStyleBackColor = true;
            this.chk_puppy.CheckStateChanged += new System.EventHandler(this.chk_puppy_CheckStateChanged);
            // 
            // chk_kitty
            // 
            this.chk_kitty.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_kitty.Image = ((System.Drawing.Image)(resources.GetObject("chk_kitty.Image")));
            this.chk_kitty.Location = new System.Drawing.Point(546, 138);
            this.chk_kitty.Name = "chk_kitty";
            this.chk_kitty.Size = new System.Drawing.Size(466, 435);
            this.chk_kitty.TabIndex = 1;
            this.chk_kitty.Text = "고양이";
            this.chk_kitty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_kitty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chk_kitty.UseVisualStyleBackColor = true;
            this.chk_kitty.CheckStateChanged += new System.EventHandler(this.chk_kitty_CheckStateChanged);
            // 
            // tb_result
            // 
            this.tb_result.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_result.Location = new System.Drawing.Point(197, 609);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(664, 33);
            this.tb_result.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("돋움", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_title.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_title.Location = new System.Drawing.Point(249, 47);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(612, 40);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "강아지 vs 고양이 당신의 선택은?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 731);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.chk_kitty);
            this.Controls.Add(this.chk_puppy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_puppy;
        private System.Windows.Forms.CheckBox chk_kitty;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label lbl_title;
    }
}

