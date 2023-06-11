using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class EmployeeForm : Form
    {
        static Member mList = new Member();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            UpdateDisplay(mList);
        }

        private void UpdateDisplay(Member lt)
        {
            txt_Total.Items.Clear();
            for (int i = 0; i < lt.Count; i++)
                txt_Total.Items.Add(lt[i].ToString());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Birthdate.Text != "" && txt_Money.Text != "")
            {
                Employee em = new Employee(txt_Name.Text, txt_Birthdate.Text, txt_Money.Text);
                mList.Add(em);

                txt_Name.Text = "";
                txt_Birthdate.Text = "";
                txt_Money.Text = "";
                UpdateDisplay(mList);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string name = txt_delete.Text;
            if (name == "")
                return;

            txt_delete.Text = "";
            txt_delete.Focus();

            for (int i = 0; i < mList.Count; ++i)
                if (mList[i].Name == name)
                {
                    mList.Remove(i);
                }
            UpdateDisplay(mList);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UpdateDisplay(mList);
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            txt_Total.Items.Clear();
        }
    }
}