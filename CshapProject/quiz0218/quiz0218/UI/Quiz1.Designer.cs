namespace quiz0218
{
    partial class Quiz1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.quiz1Q = new System.Windows.Forms.Label();
            this.quiz1_o = new System.Windows.Forms.Button();
            this.quiz1_x = new System.Windows.Forms.Button();
            this.quiz1Next = new System.Windows.Forms.Button();
            this.quiz1Main = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quiz1Score = new System.Windows.Forms.Label();
            this.quiz1Timer = new System.Windows.Forms.Timer(this.components);
            this.quiz1RT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(248, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "퀴즈 1";
            // 
            // quiz1Q
            // 
            this.quiz1Q.AutoSize = true;
            this.quiz1Q.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quiz1Q.Location = new System.Drawing.Point(99, 107);
            this.quiz1Q.Name = "quiz1Q";
            this.quiz1Q.Size = new System.Drawing.Size(171, 32);
            this.quiz1Q.TabIndex = 1;
            this.quiz1Q.Text = "퀴즈1 문제";
            // 
            // quiz1_o
            // 
            this.quiz1_o.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quiz1_o.Location = new System.Drawing.Point(215, 204);
            this.quiz1_o.Name = "quiz1_o";
            this.quiz1_o.Size = new System.Drawing.Size(90, 69);
            this.quiz1_o.TabIndex = 2;
            this.quiz1_o.Text = "O";
            this.quiz1_o.UseVisualStyleBackColor = true;
            this.quiz1_o.Click += new System.EventHandler(this.quiz1_o_Click);
            // 
            // quiz1_x
            // 
            this.quiz1_x.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quiz1_x.Location = new System.Drawing.Point(330, 204);
            this.quiz1_x.Name = "quiz1_x";
            this.quiz1_x.Size = new System.Drawing.Size(90, 69);
            this.quiz1_x.TabIndex = 3;
            this.quiz1_x.Text = "X";
            this.quiz1_x.UseVisualStyleBackColor = true;
            this.quiz1_x.Click += new System.EventHandler(this.quiz1_x_Click);
            // 
            // quiz1Next
            // 
            this.quiz1Next.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quiz1Next.Location = new System.Drawing.Point(105, 339);
            this.quiz1Next.Name = "quiz1Next";
            this.quiz1Next.Size = new System.Drawing.Size(200, 69);
            this.quiz1Next.TabIndex = 4;
            this.quiz1Next.Text = "다음 문제";
            this.quiz1Next.UseVisualStyleBackColor = true;
            this.quiz1Next.Click += new System.EventHandler(this.quiz1Next_Click);
            // 
            // quiz1Main
            // 
            this.quiz1Main.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quiz1Main.Location = new System.Drawing.Point(330, 339);
            this.quiz1Main.Name = "quiz1Main";
            this.quiz1Main.Size = new System.Drawing.Size(200, 69);
            this.quiz1Main.TabIndex = 5;
            this.quiz1Main.Text = "메인 화면";
            this.quiz1Main.UseVisualStyleBackColor = true;
            this.quiz1Main.Click += new System.EventHandler(this.quiz1Main_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(33, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "점 수";
            // 
            // quiz1Score
            // 
            this.quiz1Score.AutoSize = true;
            this.quiz1Score.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quiz1Score.Location = new System.Drawing.Point(31, 58);
            this.quiz1Score.Name = "quiz1Score";
            this.quiz1Score.Size = new System.Drawing.Size(32, 32);
            this.quiz1Score.TabIndex = 7;
            this.quiz1Score.Text = "0";
            // 
            // quiz1Timer
            // 
            this.quiz1Timer.Interval = 1000;
            this.quiz1Timer.Tick += new System.EventHandler(this.quiz1Timer_Tick);
            // 
            // quiz1RT
            // 
            this.quiz1RT.AutoSize = true;
            this.quiz1RT.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quiz1RT.Location = new System.Drawing.Point(566, 58);
            this.quiz1RT.Name = "quiz1RT";
            this.quiz1RT.Size = new System.Drawing.Size(50, 32);
            this.quiz1RT.TabIndex = 9;
            this.quiz1RT.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(537, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "남은 시간";
            // 
            // Quiz1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.quiz1RT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quiz1Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quiz1Main);
            this.Controls.Add(this.quiz1Next);
            this.Controls.Add(this.quiz1_x);
            this.Controls.Add(this.quiz1_o);
            this.Controls.Add(this.quiz1Q);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Quiz1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quiz1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quiz1_FormClosing);
            this.Load += new System.EventHandler(this.Quiz1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quiz1Q;
        private System.Windows.Forms.Button quiz1_o;
        private System.Windows.Forms.Button quiz1_x;
        private System.Windows.Forms.Button quiz1Next;
        private System.Windows.Forms.Button quiz1Main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label quiz1Score;
        private System.Windows.Forms.Timer quiz1Timer;
        private System.Windows.Forms.Label quiz1RT;
        private System.Windows.Forms.Label label5;
    }
}