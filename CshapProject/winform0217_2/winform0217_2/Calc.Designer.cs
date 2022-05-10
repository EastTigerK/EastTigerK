namespace winform0217_2
{
    partial class Calc
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
            this.output = new System.Windows.Forms.TextBox();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output.Location = new System.Drawing.Point(11, 20);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(322, 48);
            this.output.TabIndex = 0;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.Navy;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.SystemColors.Control;
            this.num7.Location = new System.Drawing.Point(15, 91);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 60);
            this.num7.TabIndex = 1;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.onClickHandler);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.Navy;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.SystemColors.Control;
            this.num8.Location = new System.Drawing.Point(96, 91);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 60);
            this.num8.TabIndex = 2;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.onClickHandler);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.Navy;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.SystemColors.Control;
            this.num9.Location = new System.Drawing.Point(177, 91);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 60);
            this.num9.TabIndex = 3;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.onClickHandler);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Navy;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.SystemColors.Control;
            this.plus.Location = new System.Drawing.Point(258, 91);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 60);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.onClickHandler);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Navy;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.SystemColors.Control;
            this.minus.Location = new System.Drawing.Point(258, 157);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 60);
            this.minus.TabIndex = 8;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.onClickHandler);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.Navy;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.SystemColors.Control;
            this.num6.Location = new System.Drawing.Point(177, 157);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 60);
            this.num6.TabIndex = 7;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.onClickHandler);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.Navy;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.SystemColors.Control;
            this.num5.Location = new System.Drawing.Point(96, 157);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 60);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.onClickHandler);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.Navy;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.SystemColors.Control;
            this.num4.Location = new System.Drawing.Point(15, 157);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 60);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.onClickHandler);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.Navy;
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.div.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.ForeColor = System.Drawing.SystemColors.Control;
            this.div.Location = new System.Drawing.Point(258, 289);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 60);
            this.div.TabIndex = 16;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.onClickHandler);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Navy;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.ForeColor = System.Drawing.Color.Cyan;
            this.enter.Location = new System.Drawing.Point(177, 289);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 60);
            this.enter.TabIndex = 15;
            this.enter.Text = "=";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.onClickHandler);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.Navy;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.SystemColors.Control;
            this.num0.Location = new System.Drawing.Point(96, 289);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(75, 60);
            this.num0.TabIndex = 14;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.onClickHandler);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Navy;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Cyan;
            this.clear.Location = new System.Drawing.Point(15, 289);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 60);
            this.clear.TabIndex = 13;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.onClickHandler);
            // 
            // multi
            // 
            this.multi.BackColor = System.Drawing.Color.Navy;
            this.multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi.ForeColor = System.Drawing.SystemColors.Control;
            this.multi.Location = new System.Drawing.Point(258, 223);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(75, 60);
            this.multi.TabIndex = 12;
            this.multi.Text = "x";
            this.multi.UseVisualStyleBackColor = false;
            this.multi.Click += new System.EventHandler(this.onClickHandler);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.Navy;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.SystemColors.Control;
            this.num3.Location = new System.Drawing.Point(177, 223);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 60);
            this.num3.TabIndex = 11;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.onClickHandler);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.Navy;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.Control;
            this.num2.Location = new System.Drawing.Point(96, 223);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 60);
            this.num2.TabIndex = 10;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.onClickHandler);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.Navy;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.Control;
            this.num1.Location = new System.Drawing.Point(15, 223);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 60);
            this.num1.TabIndex = 9;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.onClickHandler);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(347, 365);
            this.Controls.Add(this.div);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "간단한 계산기 2.0";
            this.Load += new System.EventHandler(this.Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
    }
}