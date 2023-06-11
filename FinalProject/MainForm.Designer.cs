
namespace Store
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.DelCall = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btnCharge = new System.Windows.Forms.Button();
            this.MV_Inventory = new System.Windows.Forms.Button();
            this.Cash = new System.Windows.Forms.RadioButton();
            this.Card = new System.Windows.Forms.RadioButton();
            this.CashSum = new System.Windows.Forms.TextBox();
            this.CardSum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalSum = new System.Windows.Forms.TextBox();
            this.btn_employeeManagement = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "제품 추가";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(85, 73);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(143, 21);
            this.txtCost.TabIndex = 1;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "가격 :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(234, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 21);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "음식 이름 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDisplay);
            this.groupBox2.Location = new System.Drawing.Point(51, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주문 내역";
            // 
            // lbDisplay
            // 
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.ItemHeight = 12;
            this.lbDisplay.Location = new System.Drawing.Point(6, 20);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(356, 292);
            this.lbDisplay.TabIndex = 0;
            this.lbDisplay.SelectedIndexChanged += new System.EventHandler(this.lbDisplay_SelectedIndexChanged);
            // 
            // DelCall
            // 
            this.DelCall.Location = new System.Drawing.Point(60, 76);
            this.DelCall.Name = "DelCall";
            this.DelCall.Size = new System.Drawing.Size(101, 37);
            this.DelCall.TabIndex = 1;
            this.DelCall.Text = "기사 호출";
            this.DelCall.UseVisualStyleBackColor = true;
            this.DelCall.Click += new System.EventHandler(this.DelCall_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(60, 76);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 37);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtAdd);
            this.groupBox3.Controls.Add(this.DelCall);
            this.groupBox3.Location = new System.Drawing.Point(395, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 119);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "배달";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "주소 : ";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(60, 46);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(134, 21);
            this.txtAdd.TabIndex = 0;
            this.txtAdd.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtRemove);
            this.groupBox4.Controls.Add(this.btnRemove);
            this.groupBox4.Location = new System.Drawing.Point(608, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 119);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "음식 삭제";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "음식 이름 : ";
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(81, 46);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(104, 21);
            this.txtRemove.TabIndex = 0;
            // 
            // btnCharge
            // 
            this.btnCharge.Location = new System.Drawing.Point(438, 284);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(107, 89);
            this.btnCharge.TabIndex = 1;
            this.btnCharge.Text = "결제";
            this.btnCharge.UseVisualStyleBackColor = true;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // MV_Inventory
            // 
            this.MV_Inventory.Location = new System.Drawing.Point(668, 202);
            this.MV_Inventory.Name = "MV_Inventory";
            this.MV_Inventory.Size = new System.Drawing.Size(135, 73);
            this.MV_Inventory.TabIndex = 5;
            this.MV_Inventory.Text = "재고관리";
            this.MV_Inventory.UseVisualStyleBackColor = true;
            this.MV_Inventory.Click += new System.EventHandler(this.MV_Inventory_Click);
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Location = new System.Drawing.Point(438, 379);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(47, 16);
            this.Cash.TabIndex = 7;
            this.Cash.TabStop = true;
            this.Cash.Text = "현금";
            this.Cash.UseVisualStyleBackColor = true;
            this.Cash.CheckedChanged += new System.EventHandler(this.Cash_CheckedChanged);
            // 
            // Card
            // 
            this.Card.AutoSize = true;
            this.Card.Location = new System.Drawing.Point(491, 379);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(47, 16);
            this.Card.TabIndex = 8;
            this.Card.TabStop = true;
            this.Card.Text = "카드";
            this.Card.UseVisualStyleBackColor = true;
            this.Card.CheckedChanged += new System.EventHandler(this.Card_CheckedChanged);
            // 
            // CashSum
            // 
            this.CashSum.Location = new System.Drawing.Point(509, 435);
            this.CashSum.Name = "CashSum";
            this.CashSum.Size = new System.Drawing.Size(100, 21);
            this.CashSum.TabIndex = 9;
            this.CashSum.TextChanged += new System.EventHandler(this.CashSum_TextChanged);
            // 
            // CardSum
            // 
            this.CardSum.Location = new System.Drawing.Point(509, 468);
            this.CardSum.Name = "CardSum";
            this.CardSum.Size = new System.Drawing.Size(100, 21);
            this.CardSum.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "현금 총합 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "카드 총합 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "오늘 총 매출 : ";
            // 
            // TotalSum
            // 
            this.TotalSum.Location = new System.Drawing.Point(732, 450);
            this.TotalSum.Name = "TotalSum";
            this.TotalSum.Size = new System.Drawing.Size(104, 21);
            this.TotalSum.TabIndex = 14;
            this.TotalSum.TextChanged += new System.EventHandler(this.TotalSum_TextChanged);
            // 
            // btn_employeeManagement
            // 
            this.btn_employeeManagement.Location = new System.Drawing.Point(667, 299);
            this.btn_employeeManagement.Name = "btn_employeeManagement";
            this.btn_employeeManagement.Size = new System.Drawing.Size(136, 74);
            this.btn_employeeManagement.TabIndex = 15;
            this.btn_employeeManagement.Text = "직원관리";
            this.btn_employeeManagement.UseVisualStyleBackColor = true;
            this.btn_employeeManagement.Click += new System.EventHandler(this.btn_employeeManagement_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 587);
            this.Controls.Add(this.btn_employeeManagement);
            this.Controls.Add(this.TotalSum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CardSum);
            this.Controls.Add(this.CashSum);
            this.Controls.Add(this.Card);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.MV_Inventory);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCharge);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button DelCall;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.Button MV_Inventory;
        private System.Windows.Forms.RadioButton Cash;
        private System.Windows.Forms.RadioButton Card;
        private System.Windows.Forms.TextBox CashSum;
        private System.Windows.Forms.TextBox CardSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalSum;
        private System.Windows.Forms.Button btn_employeeManagement;
    }
}

