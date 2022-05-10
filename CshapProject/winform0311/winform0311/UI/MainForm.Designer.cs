namespace winform0311
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.custFixAdd = new Sunny.UI.UISymbolButton();
            this.custFixView = new Sunny.UI.UISymbolButton();
            this.custFixAdmin = new Sunny.UI.UISymbolButton();
            this.setting = new Sunny.UI.UISymbolButton();
            this.about = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.mainMin = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winform0311.Properties.Resources.bg2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // custFixAdd
            // 
            this.custFixAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixAdd.FillColor = System.Drawing.Color.Silver;
            this.custFixAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixAdd.Location = new System.Drawing.Point(454, 99);
            this.custFixAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixAdd.Name = "custFixAdd";
            this.custFixAdd.RectColor = System.Drawing.Color.Silver;
            this.custFixAdd.Size = new System.Drawing.Size(183, 56);
            this.custFixAdd.Style = Sunny.UI.UIStyle.Custom;
            this.custFixAdd.Symbol = 62004;
            this.custFixAdd.SymbolSize = 36;
            this.custFixAdd.TabIndex = 1;
            this.custFixAdd.Text = "고객 접수";
            this.custFixAdd.Click += new System.EventHandler(this.custFixAdd_Click);
            // 
            // custFixView
            // 
            this.custFixView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixView.Location = new System.Drawing.Point(502, 181);
            this.custFixView.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixView.Name = "custFixView";
            this.custFixView.Size = new System.Drawing.Size(183, 56);
            this.custFixView.Symbol = 61508;
            this.custFixView.SymbolSize = 36;
            this.custFixView.TabIndex = 2;
            this.custFixView.Text = "접수 내역";
            this.custFixView.Click += new System.EventHandler(this.custFixView_Click);
            // 
            // custFixAdmin
            // 
            this.custFixAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixAdmin.Location = new System.Drawing.Point(553, 263);
            this.custFixAdmin.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixAdmin.Name = "custFixAdmin";
            this.custFixAdmin.Size = new System.Drawing.Size(183, 56);
            this.custFixAdmin.Symbol = 61568;
            this.custFixAdmin.SymbolSize = 36;
            this.custFixAdmin.TabIndex = 3;
            this.custFixAdmin.Text = "관리자 모드";
            this.custFixAdmin.Click += new System.EventHandler(this.custFixAdmin_Click);
            // 
            // setting
            // 
            this.setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.setting.Location = new System.Drawing.Point(502, 345);
            this.setting.MinimumSize = new System.Drawing.Size(1, 1);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(183, 56);
            this.setting.Symbol = 61573;
            this.setting.SymbolSize = 36;
            this.setting.TabIndex = 4;
            this.setting.Text = "환경 설정";
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // about
            // 
            this.about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.about.Location = new System.Drawing.Point(454, 427);
            this.about.MinimumSize = new System.Drawing.Size(1, 1);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(183, 56);
            this.about.Symbol = 61736;
            this.about.SymbolSize = 36;
            this.about.TabIndex = 5;
            this.about.Text = "프로그램 정보";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(2, 12);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(235, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61881;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel1.TabIndex = 6;
            this.uiSymbolLabel1.Text = "SpeedMate 관리 앱 v1.0";
            // 
            // mainMin
            // 
            this.mainMin.BackColor = System.Drawing.Color.Transparent;
            this.mainMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMin.FillColor = System.Drawing.Color.Transparent;
            this.mainMin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainMin.Location = new System.Drawing.Point(634, 12);
            this.mainMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainMin.Name = "mainMin";
            this.mainMin.RectColor = System.Drawing.Color.Red;
            this.mainMin.Size = new System.Drawing.Size(48, 35);
            this.mainMin.Style = Sunny.UI.UIStyle.Custom;
            this.mainMin.Symbol = 62161;
            this.mainMin.TabIndex = 7;
            this.mainMin.Click += new System.EventHandler(this.mainMin_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.Location = new System.Drawing.Point(688, 12);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Red;
            this.mainExit.Size = new System.Drawing.Size(48, 35);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61453;
            this.mainExit.TabIndex = 8;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 527);
            this.ControlBox = false;
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.mainMin);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.about);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.custFixAdmin);
            this.Controls.Add(this.custFixView);
            this.Controls.Add(this.custFixAdd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton custFixAdd;
        private Sunny.UI.UISymbolButton custFixView;
        private Sunny.UI.UISymbolButton custFixAdmin;
        private Sunny.UI.UISymbolButton setting;
        private Sunny.UI.UISymbolButton about;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton mainMin;
        private Sunny.UI.UISymbolButton mainExit;
    }
}

