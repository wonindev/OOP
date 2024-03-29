﻿namespace Store
{
    partial class Inventory
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
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Due = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.ListBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_delete = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(246, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 53);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "항목 추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "품목 이름 : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "유통기한 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "수량 : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(112, 22);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 21);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_Due
            // 
            this.txt_Due.Location = new System.Drawing.Point(112, 54);
            this.txt_Due.Name = "txt_Due";
            this.txt_Due.Size = new System.Drawing.Size(100, 21);
            this.txt_Due.TabIndex = 5;
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(112, 84);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(100, 21);
            this.txt_Count.TabIndex = 6;
            // 
            // txt_Total
            // 
            this.txt_Total.FormattingEnabled = true;
            this.txt_Total.ItemHeight = 12;
            this.txt_Total.Location = new System.Drawing.Point(39, 171);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(476, 244);
            this.txt_Total.TabIndex = 7;
            this.txt_Total.SelectedIndexChanged += new System.EventHandler(this.txt_Total_SelectedIndexChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(241, 71);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(137, 53);
            this.btn_refresh.TabIndex = 8;
            this.btn_refresh.Text = "새로고침";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "삭제할 품목 : ";
            // 
            // txt_delete
            // 
            this.txt_delete.Location = new System.Drawing.Point(579, 22);
            this.txt_delete.Name = "txt_delete";
            this.txt_delete.Size = new System.Drawing.Size(100, 21);
            this.txt_delete.TabIndex = 10;
            this.txt_delete.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(494, 57);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(185, 42);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.Location = new System.Drawing.Point(551, 258);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(145, 59);
            this.btn_Hide.TabIndex = 12;
            this.btn_Hide.Text = "품목 숨김";
            this.btn_Hide.UseVisualStyleBackColor = true;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Hide);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.txt_Due);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Name = "Inventory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Due;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.ListBox txt_Total;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_delete;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Hide;
    }
}