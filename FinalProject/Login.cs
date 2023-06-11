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
    public partial class Login : Form
    {

        public static string ID = "admin";
        public static string PW = "admin";
        public Login()
        {
            InitializeComponent();
        }

        

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(LoginText.Text == ID && PWText.Text == PW)
            {
                this.Visible = false;
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }

            else
            {
                LoginText.Text = "";
                PWText.Text = "";
            }
        }
    }
}
