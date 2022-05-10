namespace winform0224
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
            this.cxFlatRoundButton1 = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatRoundButton2 = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatRoundButton3 = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatRoundButton4 = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatRoundButton5 = new CxFlatUI.CxFlatRoundButton();
            this.mainMin = new System.Windows.Forms.Panel();
            this.mainExit = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatRoundButton1
            // 
            this.cxFlatRoundButton1.BackColor = System.Drawing.Color.White;
            this.cxFlatRoundButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton1.Location = new System.Drawing.Point(445, 85);
            this.cxFlatRoundButton1.Name = "cxFlatRoundButton1";
            this.cxFlatRoundButton1.Size = new System.Drawing.Size(184, 56);
            this.cxFlatRoundButton1.TabIndex = 1;
            this.cxFlatRoundButton1.Text = "고객 정보 등록";
            this.cxFlatRoundButton1.TextColor = System.Drawing.Color.White;
            // 
            // cxFlatRoundButton2
            // 
            this.cxFlatRoundButton2.ButtonType = CxFlatUI.ButtonType.Info;
            this.cxFlatRoundButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton2.Location = new System.Drawing.Point(481, 168);
            this.cxFlatRoundButton2.Name = "cxFlatRoundButton2";
            this.cxFlatRoundButton2.Size = new System.Drawing.Size(184, 56);
            this.cxFlatRoundButton2.TabIndex = 2;
            this.cxFlatRoundButton2.Text = "구매 차량 등록";
            this.cxFlatRoundButton2.TextColor = System.Drawing.Color.White;
            // 
            // cxFlatRoundButton3
            // 
            this.cxFlatRoundButton3.ButtonType = CxFlatUI.ButtonType.Success;
            this.cxFlatRoundButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton3.Location = new System.Drawing.Point(531, 245);
            this.cxFlatRoundButton3.Name = "cxFlatRoundButton3";
            this.cxFlatRoundButton3.Size = new System.Drawing.Size(184, 56);
            this.cxFlatRoundButton3.TabIndex = 3;
            this.cxFlatRoundButton3.Text = "차량 매출 정보";
            this.cxFlatRoundButton3.TextColor = System.Drawing.Color.White;
            // 
            // cxFlatRoundButton4
            // 
            this.cxFlatRoundButton4.ButtonType = CxFlatUI.ButtonType.Waring;
            this.cxFlatRoundButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton4.Location = new System.Drawing.Point(481, 330);
            this.cxFlatRoundButton4.Name = "cxFlatRoundButton4";
            this.cxFlatRoundButton4.Size = new System.Drawing.Size(184, 56);
            this.cxFlatRoundButton4.TabIndex = 4;
            this.cxFlatRoundButton4.Text = "관리자 모드";
            this.cxFlatRoundButton4.TextColor = System.Drawing.Color.White;
            // 
            // cxFlatRoundButton5
            // 
            this.cxFlatRoundButton5.ButtonType = CxFlatUI.ButtonType.Danger;
            this.cxFlatRoundButton5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton5.Location = new System.Drawing.Point(445, 420);
            this.cxFlatRoundButton5.Name = "cxFlatRoundButton5";
            this.cxFlatRoundButton5.Size = new System.Drawing.Size(184, 56);
            this.cxFlatRoundButton5.TabIndex = 5;
            this.cxFlatRoundButton5.Text = "프로그램 정보";
            this.cxFlatRoundButton5.TextColor = System.Drawing.Color.White;
            // 
            // mainMin
            // 
            this.mainMin.BackColor = System.Drawing.Color.Transparent;
            this.mainMin.BackgroundImage = global::winform0224.Properties.Resources.min_normal;
            this.mainMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMin.Location = new System.Drawing.Point(664, 13);
            this.mainMin.Margin = new System.Windows.Forms.Padding(0);
            this.mainMin.Name = "mainMin";
            this.mainMin.Size = new System.Drawing.Size(36, 36);
            this.mainMin.TabIndex = 6;
            this.mainMin.Click += new System.EventHandler(this.mainMin_Click);
            this.mainMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainMin_MouseDown);
            this.mainMin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainMin_MouseUp);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.BackgroundImage = global::winform0224.Properties.Resources.exit_normal;
            this.mainExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainExit.Location = new System.Drawing.Point(703, 13);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(36, 36);
            this.mainExit.TabIndex = 7;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            this.mainExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainExit_MouseDown);
            this.mainExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainExit_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winform0224.Properties.Resources.car_back2;
            this.pictureBox1.Location = new System.Drawing.Point(1, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 512);
            this.ControlBox = false;
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.mainMin);
            this.Controls.Add(this.cxFlatRoundButton5);
            this.Controls.Add(this.cxFlatRoundButton4);
            this.Controls.Add(this.cxFlatRoundButton3);
            this.Controls.Add(this.cxFlatRoundButton2);
            this.Controls.Add(this.cxFlatRoundButton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "차량 관리 프로그램 v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton1;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton2;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton3;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton4;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton5;
        private System.Windows.Forms.Panel mainMin;
        private System.Windows.Forms.Panel mainExit;
    }
}

