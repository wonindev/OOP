using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Store
{
    public partial class Inventory : Form
    {
        public static Storeage inList = new Storeage();
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            UpdateDisplay(inList);
        }
        private void UpdateDisplay(Storeage lt)
        {
               txt_Total.Items.Clear();
            for (int i = 0; i < lt.Count; i++)
                txt_Total.Items.Add(lt[i].ToString());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Due.Text != "" && txt_Count.Text != "")
            {
                Inven inv = new Inven(txt_Name.Text, txt_Due.Text, txt_Count.Text);
                inList.Add(inv);

                txt_Name.Text = "";
                txt_Due.Text = "";
                txt_Count.Text = "";
                UpdateDisplay(inList);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            UpdateDisplay(inList);
        }

        private void txt_Total_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string name = txt_delete.Text;
            if (name == "")
                return;

            txt_delete.Text = "";
            txt_delete.Focus();

            for (int i = 0; i < inList.Count; ++i)
                if (inList[i].Name == name)
                {
                    inList.Remove(i);
                }
            UpdateDisplay(inList);
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            txt_Total.Items.Clear();
        }
    }
}
