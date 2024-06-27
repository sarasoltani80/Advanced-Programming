using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class adminloginform : Form
    {
        string _idnumber = "";
        public adminloginform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _idnumber = textBox1.Text;
        }
        private void tryagain()
        {
            textBox1.Text = "";
            checkBox1.Checked = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Manageadmin manageadmin3 = Manageadmin.GetInstance();
            int x = manageadmin3.checkadmin(_idnumber);
            if(x==1)
            {
                MessageBox.Show("you login successfully as admin");
                admin_options _form = new admin_options();
                _form.Show();
            }
            if(x==0)
            {
                MessageBox.Show("try again!!");
                tryagain();
            }
        }
    }
}
