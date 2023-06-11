using Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Store
{
    public partial class MainForm : Form
    {
        Food pList = new Food();
        public static int SumCash = 0;
        public static int SumCard = 0;
        public static int SumTotal = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void UpdateDisplay(Food lt)
        {
            lbDisplay.Items.Clear();
            for (int i = 0; i < lt.Count; i++)
                lbDisplay.Items.Add(lt[i].ToString());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtCost.Text != "")
            {
                Order per = new Order(txtName.Text, txtCost.Text);
                pList.Add(per);

                txtName.Text = "";
                txtCost.Text = "";
                UpdateDisplay(pList);
            }
        }
        
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = txtRemove.Text;
            if (name == "")
                return;

            txtRemove.Text = "";
            txtRemove.Focus();

            for (int i = 0; i < pList.Count; ++i)
                if (pList[i].Name == name)
                {
                    pList.Remove(i);
                }
            UpdateDisplay(pList);
        }
        private void btnCharge_Click(object sender, EventArgs e)
        {
            lbDisplay.Items.Clear();

            if (Cash.Checked)
            {
                Cash.Checked = false;
                Card.Checked = false;

                for (int i = 0; i < pList.Count; i++)
                {
                    SumCash += int.Parse(pList[i].Cost);
                }

                pList.RemoveAll();

                lbDisplay.Items.Clear();
                CashSum.Text = SumCash.ToString() +"원";
                SumTotal += SumCash;
                TotalSum.Text = SumTotal.ToString() + "원";
                
            }

            else if (Card.Checked)
            {
                Cash.Checked = false;
                Card.Checked = false;

                for (int i = 0; i < pList.Count; i++)
                {
                    SumCard += int.Parse(pList[i].Cost);
                }

                pList.RemoveAll();
                lbDisplay.Items.Clear();
                CardSum.Text = SumCard.ToString() + "원";
                SumTotal += SumCard;
                TotalSum.Text = SumTotal.ToString() +"원";
            }


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MV_Inventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Cash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Card_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CashSum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void DelCall_Click(object sender, EventArgs e)
        {
            
            if (Cash.Checked)
            {
                MessageBox.Show(string.Format("{0}의 주소로 배달 기사를 요청했습니다 !!", txtAdd.Text));
                Cash.Checked = false;
                Card.Checked = false;

                for (int i = 0; i < pList.Count; i++)
                {
                    SumCash += int.Parse(pList[i].Cost);
                }

                pList.RemoveAll();

                lbDisplay.Items.Clear();
                CashSum.Text = SumCash.ToString() + "원";
                SumTotal += SumCash;
                TotalSum.Text = SumTotal.ToString() + "원";

            }

            else if (Card.Checked)
            {
                MessageBox.Show(string.Format("{0}의 주소로 배달 기사를 요청했습니다 !!", txtAdd.Text));
                Cash.Checked = false;
                Card.Checked = false;

                for (int i = 0; i < pList.Count; i++)
                {
                    SumCard += int.Parse(pList[i].Cost);
                }

                pList.RemoveAll();
                lbDisplay.Items.Clear();
                CardSum.Text = SumCard.ToString() + "원";
                SumTotal += SumCard;
                TotalSum.Text = SumTotal.ToString() + "원";
            }
            
        }

        private void btn_employeeManagement_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            form.Show();
        }
    }
}
