namespace quiz0218
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainStart2 = new System.Windows.Forms.Panel();
            this.mainExit = new System.Windows.Forms.Button();
            this.mainStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mainStart2
            // 
            this.mainStart2.BackColor = System.Drawing.SystemColors.Control;
            this.mainStart2.BackgroundImage = global::quiz0218.Properties.Resources.start_normal;
            this.mainStart2.Location = new System.Drawing.Point(399, 278);
            this.mainStart2.Name = "mainStart2";
            this.mainStart2.Size = new System.Drawing.Size(96, 96);
            this.mainStart2.TabIndex = 7;
            this.mainStart2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainStart2_MouseDown);
            this.mainStart2.MouseLeave += new System.EventHandler(this.mainStart2_MouseLeave);
            this.mainStart2.MouseHover += new System.EventHandler(this.mainStart2_MouseHover);
            this.mainStart2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainStart2_MouseUp);
            // 
            // mainExit
            // 
            this.mainExit.BackgroundImage = global::quiz0218.Properties.Resources.exit;
            this.mainExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainExit.FlatAppearance.BorderSize = 0;
            this.mainExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainExit.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainExit.Location = new System.Drawing.Point(215, 263);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(128, 128);
            this.mainExit.TabIndex = 6;
            this.mainExit.UseVisualStyleBackColor = true;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // mainStart
            // 
            this.mainStart.BackgroundImage = global::quiz0218.Properties.Resources.start;
            this.mainStart.FlatAppearance.BorderSize = 0;
            this.mainStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainStart.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainStart.Location = new System.Drawing.Point(48, 263);
            this.mainStart.Name = "mainStart";
            this.mainStart.Size = new System.Drawing.Size(128, 128);
            this.mainStart.TabIndex = 5;
            this.mainStart.UseVisualStyleBackColor = true;
            this.mainStart.Click += new System.EventHandler(this.mainStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 403);
            this.Controls.Add(this.mainStart2);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.mainStart);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "스피드 Quiz 프로그램 v1.5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainStart2;
        private System.Windows.Forms.Button mainExit;
        private System.Windows.Forms.Button mainStart;
    }
}

