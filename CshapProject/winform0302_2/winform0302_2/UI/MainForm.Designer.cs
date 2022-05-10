namespace winform0302_2
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
            this.mainExit = new System.Windows.Forms.Button();
            this.insRand = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.dropTb = new System.Windows.Forms.Button();
            this.createTb = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainExit
            // 
            this.mainExit.Location = new System.Drawing.Point(485, 341);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(147, 78);
            this.mainExit.TabIndex = 15;
            this.mainExit.Text = "종 료";
            this.mainExit.UseVisualStyleBackColor = true;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // insRand
            // 
            this.insRand.Location = new System.Drawing.Point(332, 341);
            this.insRand.Name = "insRand";
            this.insRand.Size = new System.Drawing.Size(147, 78);
            this.insRand.TabIndex = 14;
            this.insRand.Text = "랜덤 데이터 추가";
            this.insRand.UseVisualStyleBackColor = true;
            this.insRand.Click += new System.EventHandler(this.insRand_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(179, 341);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(147, 78);
            this.delete.TabIndex = 13;
            this.delete.Text = "데이터 삭제";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(26, 341);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(147, 78);
            this.update.TabIndex = 12;
            this.update.Text = "데이터 수정";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(485, 257);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(147, 78);
            this.view.TabIndex = 11;
            this.view.Text = "데이터 보기";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(332, 257);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(147, 78);
            this.insert.TabIndex = 10;
            this.insert.Text = "데이터 추가";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // dropTb
            // 
            this.dropTb.Location = new System.Drawing.Point(179, 257);
            this.dropTb.Name = "dropTb";
            this.dropTb.Size = new System.Drawing.Size(147, 78);
            this.dropTb.TabIndex = 9;
            this.dropTb.Text = "테이블 삭제";
            this.dropTb.UseVisualStyleBackColor = true;
            this.dropTb.Click += new System.EventHandler(this.dropTb_Click);
            // 
            // createTb
            // 
            this.createTb.Location = new System.Drawing.Point(26, 257);
            this.createTb.Name = "createTb";
            this.createTb.Size = new System.Drawing.Size(147, 78);
            this.createTb.TabIndex = 8;
            this.createTb.Text = "테이블 생성";
            this.createTb.UseVisualStyleBackColor = true;
            this.createTb.Click += new System.EventHandler(this.createTb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winform0302_2.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.insRand);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.view);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dropTb);
            this.Controls.Add(this.createTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "간단한 주소록 관리 App v1.5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainExit;
        private System.Windows.Forms.Button insRand;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button dropTb;
        private System.Windows.Forms.Button createTb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

