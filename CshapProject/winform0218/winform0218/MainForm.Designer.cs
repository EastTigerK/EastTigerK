namespace winform0218
{
    partial class MainForm
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
            this.input = new System.Windows.Forms.TextBox();
            this.open = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(118, 54);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(209, 21);
            this.input.TabIndex = 0;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(118, 129);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(155, 66);
            this.open.TabIndex = 1;
            this.open.Text = "폼 열기";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(299, 129);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(155, 66);
            this.exit.TabIndex = 2;
            this.exit.Text = "종 료";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 292);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.open);
            this.Controls.Add(this.input);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button exit;
    }
}

