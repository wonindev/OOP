using System;
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
    public partial class FindIDPW : Form
    {
        string ansid = "내산초등학교";
        string anspw = "도담이";
        public FindIDPW()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내가 다녔던 초등학교 이름은 ?");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("처음으로 키웠던 강아지 이름은 ?");
        }

        private void btn_IDfind_Click(object sender, EventArgs e)
        {
            if(txt_ID.Text != "")
            {
                if(txt_ID.Text == ansid)
                {
                    MessageBox.Show("admin");
                }
            }
        }

        private void btn_PWfind_Click(object sender, EventArgs e)
        {
            if (txt_PW.Text != "")
            {
                if (txt_PW.Text == anspw)
                {
                    MessageBox.Show("admin");
                }
            }
        }
    }
}
