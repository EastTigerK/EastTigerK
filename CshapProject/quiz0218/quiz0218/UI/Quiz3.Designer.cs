namespace quiz0218
{
    partial class Quiz3
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
            this.quiz3Main = new System.Windows.Forms.Button();
            this.quiz3Next = new System.Windows.Forms.Button();
            this.quiz3_x = new System.Windows.Forms.Button();
            this.quiz3_o = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quiz3Main
            // 
            this.quiz3Main.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quiz3Main.Location = new System.Drawing.Point(341, 342);
            this.quiz3Main.Name = "quiz3Main";
            this.quiz3Main.Size = new System.Drawing.Size(200, 69);
            this.quiz3Main.TabIndex = 11;
            this.quiz3Main.Text = "메인 화면";
            this.quiz3Main.UseVisualStyleBackColor = true;
            this.quiz3Main.Click += new System.EventHandler(this.quiz3Main_Click);
            // 
            // quiz3Next
            // 
            this.quiz3Next.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quiz3Next.Location = new System.Drawing.Point(116, 342);
            this.quiz3Next.Name = "quiz3Next";
            this.quiz3Next.Size = new System.Drawing.Size(200, 69);
            this.quiz3Next.TabIndex = 10;
            this.quiz3Next.Text = "다음 문제";
            this.quiz3Next.UseVisualStyleBackColor = true;
            // 
            // quiz3_x
            // 
            this.quiz3_x.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quiz3_x.Location = new System.Drawing.Point(341, 207);
            this.quiz3_x.Name = "quiz3_x";
            this.quiz3_x.Size = new System.Drawing.Size(90, 69);
            this.quiz3_x.TabIndex = 9;
            this.quiz3_x.Text = "X";
            this.quiz3_x.UseVisualStyleBackColor = true;
            // 
            // quiz3_o
            // 
            this.quiz3_o.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quiz3_o.Location = new System.Drawing.Point(226, 207);
            this.quiz3_o.Name = "quiz3_o";
            this.quiz3_o.Size = new System.Drawing.Size(90, 69);
            this.quiz3_o.TabIndex = 8;
            this.quiz3_o.Text = "O";
            this.quiz3_o.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(110, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "대마도도 대한민국 영토이다.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(259, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "퀴즈 3";
            // 
            // Quiz3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.quiz3Main);
            this.Controls.Add(this.quiz3Next);
            this.Controls.Add(this.quiz3_x);
            this.Controls.Add(this.quiz3_o);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Quiz3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quiz3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quiz3Main;
        private System.Windows.Forms.Button quiz3Next;
        private System.Windows.Forms.Button quiz3_x;
        private System.Windows.Forms.Button quiz3_o;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}