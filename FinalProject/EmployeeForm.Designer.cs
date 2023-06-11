namespace Store
{
    partial class EmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Birthdate = new System.Windows.Forms.TextBox();
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.ListBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_delete = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "생년월일: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "월급: ";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(187, 38);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 21);
            this.txt_Name.TabIndex = 3;
            // 
            // txt_Birthdate
            // 
            this.txt_Birthdate.Location = new System.Drawing.Point(187, 74);
            this.txt_Birthdate.Name = "txt_Birthdate";
            this.txt_Birthdate.Size = new System.Drawing.Size(100, 21);
            this.txt_Birthdate.TabIndex = 4;
            // 
            // txt_Money
            // 
            this.txt_Money.Location = new System.Drawing.Point(187, 113);
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.Size = new System.Drawing.Size(100, 21);
            this.txt_Money.TabIndex = 5;
            // 
            // txt_Total
            // 
            this.txt_Total.FormattingEnabled = true;
            this.txt_Total.ItemHeight = 12;
            this.txt_Total.Location = new System.Drawing.Point(107, 174);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(268, 196);
            this.txt_Total.TabIndex = 6;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(312, 38);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(134, 96);
            this.btn_Register.TabIndex = 7;
            this.btn_Register.Text = "등록";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "이름: ";
            // 
            // txt_delete
            // 
            this.txt_delete.Location = new System.Drawing.Point(586, 68);
            this.txt_delete.Name = "txt_delete";
            this.txt_delete.Size = new System.Drawing.Size(93, 21);
            this.txt_delete.TabIndex = 9;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(549, 101);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(129, 41);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(549, 244);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(134, 48);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "새로고침";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.Location = new System.Drawing.Point(549, 322);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(134, 48);
            this.btn_Hide.TabIndex = 12;
            this.btn_Hide.Text = "직원 목록 숨김";
            this.btn_Hide.UseVisualStyleBackColor = true;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Hide);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Money);
            this.Controls.Add(this.txt_Birthdate);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Birthdate;
        private System.Windows.Forms.TextBox txt_Money;
        private System.Windows.Forms.ListBox txt_Total;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_delete;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Hide;
    }
}