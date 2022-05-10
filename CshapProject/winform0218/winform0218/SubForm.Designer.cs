namespace winform0218
{
    partial class SubForm
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
            this.subExit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // subExit
            // 
            this.subExit.Location = new System.Drawing.Point(190, 165);
            this.subExit.Name = "subExit";
            this.subExit.Size = new System.Drawing.Size(152, 61);
            this.subExit.TabIndex = 0;
            this.subExit.Text = "종 료";
            this.subExit.UseVisualStyleBackColor = true;
            this.subExit.Click += new System.EventHandler(this.subExit_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(144, 60);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(222, 21);
            this.output.TabIndex = 1;
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 292);
            this.Controls.Add(this.output);
            this.Controls.Add(this.subExit);
            this.Name = "SubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subExit;
        private System.Windows.Forms.TextBox output;
    }
}