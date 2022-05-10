namespace winform0217
{
    partial class FormTest1
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
            this.inputData = new System.Windows.Forms.TextBox();
            this.getData = new System.Windows.Forms.Button();
            this.viewData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputData
            // 
            this.inputData.Location = new System.Drawing.Point(68, 59);
            this.inputData.Multiline = true;
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(328, 94);
            this.inputData.TabIndex = 0;
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(96, 233);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(267, 87);
            this.getData.TabIndex = 1;
            this.getData.Text = "정보 가져오기";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // viewData
            // 
            this.viewData.AutoSize = true;
            this.viewData.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.viewData.Location = new System.Drawing.Point(548, 200);
            this.viewData.Name = "viewData";
            this.viewData.Size = new System.Drawing.Size(76, 16);
            this.viewData.TabIndex = 2;
            this.viewData.Text = "정보 출력";
            // 
            // FormTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewData);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.inputData);
            this.Name = "FormTest1";
            this.Text = "폼 테스트 화면입니다.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputData;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.Label viewData;
    }
}