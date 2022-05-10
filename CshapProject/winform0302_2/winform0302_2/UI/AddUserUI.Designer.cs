namespace winform0302_2.UI
{
    partial class AddUserUI
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddr = new System.Windows.Forms.TextBox();
            this.addUserOK = new System.Windows.Forms.Button();
            this.addUserCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(157, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(241, 21);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이 름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "나 이";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(157, 98);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(241, 21);
            this.tbAge.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "주 소";
            // 
            // tbAddr
            // 
            this.tbAddr.Location = new System.Drawing.Point(157, 153);
            this.tbAddr.Name = "tbAddr";
            this.tbAddr.Size = new System.Drawing.Size(241, 21);
            this.tbAddr.TabIndex = 4;
            // 
            // addUserOK
            // 
            this.addUserOK.Location = new System.Drawing.Point(81, 244);
            this.addUserOK.Name = "addUserOK";
            this.addUserOK.Size = new System.Drawing.Size(126, 54);
            this.addUserOK.TabIndex = 6;
            this.addUserOK.Text = "확 인";
            this.addUserOK.UseVisualStyleBackColor = true;
            this.addUserOK.Click += new System.EventHandler(this.addUserOK_Click);
            // 
            // addUserCancel
            // 
            this.addUserCancel.Location = new System.Drawing.Point(272, 244);
            this.addUserCancel.Name = "addUserCancel";
            this.addUserCancel.Size = new System.Drawing.Size(126, 54);
            this.addUserCancel.TabIndex = 7;
            this.addUserCancel.Text = "취 소";
            this.addUserCancel.UseVisualStyleBackColor = true;
            this.addUserCancel.Click += new System.EventHandler(this.addUserCancel_Click);
            // 
            // AddUserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 319);
            this.Controls.Add(this.addUserCancel);
            this.Controls.Add(this.addUserOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAddr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "AddUserUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 정보 입력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddr;
        private System.Windows.Forms.Button addUserOK;
        private System.Windows.Forms.Button addUserCancel;
    }
}