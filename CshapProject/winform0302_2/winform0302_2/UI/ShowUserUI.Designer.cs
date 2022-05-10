namespace winform0302_2.UI
{
    partial class ShowUserUI
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.gvCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView = new System.Windows.Forms.ListView();
            this.lvCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewOK = new System.Windows.Forms.Button();
            this.viewCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvCount,
            this.gvName,
            this.gvAge,
            this.gvAddr});
            this.dataGridView.Location = new System.Drawing.Point(12, 220);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(699, 202);
            this.dataGridView.TabIndex = 0;
            // 
            // gvCount
            // 
            this.gvCount.HeaderText = "번 호";
            this.gvCount.Name = "gvCount";
            // 
            // gvName
            // 
            this.gvName.HeaderText = "이 름";
            this.gvName.Name = "gvName";
            this.gvName.Width = 150;
            // 
            // gvAge
            // 
            this.gvAge.HeaderText = "나 이";
            this.gvAge.Name = "gvAge";
            // 
            // gvAddr
            // 
            this.gvAddr.HeaderText = "주 소";
            this.gvAddr.Name = "gvAddr";
            this.gvAddr.Width = 300;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvCount,
            this.lvName,
            this.lvAge,
            this.lvAddr});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(699, 202);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // lvCount
            // 
            this.lvCount.Text = "번 호";
            // 
            // lvName
            // 
            this.lvName.Text = "이 름";
            this.lvName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvName.Width = 120;
            // 
            // lvAge
            // 
            this.lvAge.Text = "나 이";
            this.lvAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvAge.Width = 80;
            // 
            // lvAddr
            // 
            this.lvAddr.Text = "주 소";
            this.lvAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvAddr.Width = 300;
            // 
            // viewOK
            // 
            this.viewOK.Location = new System.Drawing.Point(141, 455);
            this.viewOK.Name = "viewOK";
            this.viewOK.Size = new System.Drawing.Size(158, 47);
            this.viewOK.TabIndex = 2;
            this.viewOK.Text = "확인";
            this.viewOK.UseVisualStyleBackColor = true;
            this.viewOK.Click += new System.EventHandler(this.viewOK_Click);
            // 
            // viewCancel
            // 
            this.viewCancel.Location = new System.Drawing.Point(418, 455);
            this.viewCancel.Name = "viewCancel";
            this.viewCancel.Size = new System.Drawing.Size(158, 47);
            this.viewCancel.TabIndex = 3;
            this.viewCancel.Text = "취소";
            this.viewCancel.UseVisualStyleBackColor = true;
            this.viewCancel.Click += new System.EventHandler(this.viewCancel_Click);
            // 
            // ShowUserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 538);
            this.Controls.Add(this.viewCancel);
            this.Controls.Add(this.viewOK);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.dataGridView);
            this.Name = "ShowUserUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 데이터 보기";
            this.Load += new System.EventHandler(this.ShowUserUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader lvCount;
        private System.Windows.Forms.ColumnHeader lvName;
        private System.Windows.Forms.ColumnHeader lvAge;
        private System.Windows.Forms.ColumnHeader lvAddr;
        private System.Windows.Forms.Button viewOK;
        private System.Windows.Forms.Button viewCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAddr;
    }
}