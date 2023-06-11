namespace Store
{
    partial class FindIDPW
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.btn_IDfind = new System.Windows.Forms.Button();
            this.btn_PWfind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디 찾기 답변: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호 찾기 답변: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(332, 125);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(122, 21);
            this.txt_ID.TabIndex = 2;
            // 
            // txt_PW
            // 
            this.txt_PW.Location = new System.Drawing.Point(328, 235);
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.Size = new System.Drawing.Size(143, 21);
            this.txt_PW.TabIndex = 3;
            // 
            // btn_IDfind
            // 
            this.btn_IDfind.Location = new System.Drawing.Point(494, 124);
            this.btn_IDfind.Name = "btn_IDfind";
            this.btn_IDfind.Size = new System.Drawing.Size(95, 21);
            this.btn_IDfind.TabIndex = 4;
            this.btn_IDfind.Text = "찾기";
            this.btn_IDfind.UseVisualStyleBackColor = true;
            this.btn_IDfind.Click += new System.EventHandler(this.btn_IDfind_Click);
            // 
            // btn_PWfind
            // 
            this.btn_PWfind.Location = new System.Drawing.Point(497, 234);
            this.btn_PWfind.Name = "btn_PWfind";
            this.btn_PWfind.Size = new System.Drawing.Size(108, 21);
            this.btn_PWfind.TabIndex = 5;
            this.btn_PWfind.Text = "찾기";
            this.btn_PWfind.UseVisualStyleBackColor = true;
            this.btn_PWfind.Click += new System.EventHandler(this.btn_PWfind_Click);
            // 
            // FindIDPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_PWfind);
            this.Controls.Add(this.btn_IDfind);
            this.Controls.Add(this.txt_PW);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindIDPW";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.Button btn_IDfind;
        private System.Windows.Forms.Button btn_PWfind;
    }
}