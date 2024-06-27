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
    public partial class change_the_darsad_of_sahamdaran : Form
    {
        string folderName1 = @"D:\C#Files991\";
        string filenamePrefix3 = "sahamdaranFile";
        string sahamdar_id = "";
        int new_darsad;
        string newsahamdar_id = "";
        string newsahamdar_darsad;
        public change_the_darsad_of_sahamdaran()
        {
            InitializeComponent();
        }
        private void change_the_darsad_of_sahamdaran_Load(object sender, EventArgs e)
        {
            var managesahamdar = new Managesahamdaran(folderName1 + filenamePrefix3, new SaveLoadManagesahamdaran_WriteReadAll());
            dataGridView_sahamdaran.DataSource = managesahamdar.sahamdarList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sahamdar_id = textBox1.Text;
        }

        private void new_darsadsahm_TextChanged(object sender, EventArgs e)
        {
            new_darsad = Convert.ToInt32(new_darsadsahm.Text);
        }

        private void finish_chk_CheckedChanged(object sender, EventArgs e)
        {
            var managesahamdar = new Managesahamdaran(folderName1 + filenamePrefix3, new SaveLoadManagesahamdaran_WriteReadAll());
            managesahamdar.changedarsadsahm(sahamdar_id, new_darsad);
            MessageBox.Show("درصد سهم سهامدار موردنظر با موفقیت تغییر یافت!!");
            dataGridView_sahamdaran.DataSource = managesahamdar.sahamdarList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = false;
            label7.Visible = false;
            checkBox1.Visible = false;
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            new_darsadsahm.Visible = true;
            finish_chk.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            newsahamdar_id = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            newsahamdar_darsad = textBox3.Text;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var managesahamdar = new Managesahamdaran(folderName1 + filenamePrefix3, new SaveLoadManagesahamdaran_WriteReadAll());
            int newsahamdardarsad = Convert.ToInt32(newsahamdar_darsad);
            var sahamdar1 = new sahamdar { idnumber = newsahamdar_id, darsadsahm = newsahamdardarsad };
            int Is_motabar=managesahamdar.Addsahamdar(sahamdar1);
            if (Is_motabar == 0)
            {
                MessageBox.Show("درصد سهم سهامدار مورد نظر نامعتبر می باشد.");
            }
            else
            {
                MessageBox.Show("سهامدار جدید با موفقیت به لیست سهامداران کلینیک اضافه شد :)");
                dataGridView_sahamdaran.DataSource = managesahamdar.sahamdarList;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            new_darsadsahm.Visible = false;
            finish_chk.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = true;
            label7.Visible = true;
            checkBox1.Visible = true;
        }
    }
}
