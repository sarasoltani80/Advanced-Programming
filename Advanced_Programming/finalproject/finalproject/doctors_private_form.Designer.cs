namespace finalproject
{
    partial class doctors_private_form
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.changeid_btn = new System.Windows.Forms.Button();
            this.listofappointment_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newid_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_information = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_information)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.changeid_btn);
            this.splitContainer1.Panel1.Controls.Add(this.listofappointment_btn);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.newid_txt);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_information);
            this.splitContainer1.Size = new System.Drawing.Size(1137, 698);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.BackgroundImage = global::finalproject.Properties.Resources.dentist;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Location = new System.Drawing.Point(43, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 238);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // changeid_btn
            // 
            this.changeid_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.changeid_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.changeid_btn.ForeColor = System.Drawing.Color.Coral;
            this.changeid_btn.Location = new System.Drawing.Point(43, 561);
            this.changeid_btn.Name = "changeid_btn";
            this.changeid_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.changeid_btn.Size = new System.Drawing.Size(274, 68);
            this.changeid_btn.TabIndex = 3;
            this.changeid_btn.Text = "تغییر رمز عبور";
            this.changeid_btn.UseVisualStyleBackColor = false;
            this.changeid_btn.Click += new System.EventHandler(this.changeid_btn_Click);
            // 
            // listofappointment_btn
            // 
            this.listofappointment_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.listofappointment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listofappointment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listofappointment_btn.ForeColor = System.Drawing.Color.Coral;
            this.listofappointment_btn.Location = new System.Drawing.Point(43, 357);
            this.listofappointment_btn.Name = "listofappointment_btn";
            this.listofappointment_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listofappointment_btn.Size = new System.Drawing.Size(274, 68);
            this.listofappointment_btn.TabIndex = 1;
            this.listofappointment_btn.Text = "مشاهده لیست نویتهای اخیر";
            this.listofappointment_btn.UseVisualStyleBackColor = false;
            this.listofappointment_btn.Click += new System.EventHandler(this.listofappointment_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(147, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "پزشک";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.checkBox1.Location = new System.Drawing.Point(590, 588);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(86, 41);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "تمام";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(394, 532);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(327, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "اگر تکمیل کردی دکمه تمام را انتخاب کن!!";
            this.label3.Visible = false;
            // 
            // newid_txt
            // 
            this.newid_txt.Location = new System.Drawing.Point(525, 462);
            this.newid_txt.Name = "newid_txt";
            this.newid_txt.Size = new System.Drawing.Size(172, 26);
            this.newid_txt.TabIndex = 6;
            this.newid_txt.Visible = false;
            this.newid_txt.TextChanged += new System.EventHandler(this.newid_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(464, 407);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(257, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "رمز عبور جدید خود را وارد کن:";
            this.label2.Visible = false;
            // 
            // dataGridView_information
            // 
            this.dataGridView_information.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGridView_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_information.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_information.GridColor = System.Drawing.Color.Yellow;
            this.dataGridView_information.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_information.Name = "dataGridView_information";
            this.dataGridView_information.RowHeadersWidth = 62;
            this.dataGridView_information.RowTemplate.Height = 28;
            this.dataGridView_information.Size = new System.Drawing.Size(754, 360);
            this.dataGridView_information.TabIndex = 4;
            this.dataGridView_information.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(43, 453);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(274, 74);
            this.button2.TabIndex = 5;
            this.button2.Text = "مشاهده لیست نوبت های سورت شده";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // doctors_private_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 698);
            this.Controls.Add(this.splitContainer1);
            this.Name = "doctors_private_form";
            this.Text = "doctors_private_form";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_information)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button listofappointment_btn;
        private System.Windows.Forms.Button changeid_btn;
        private System.Windows.Forms.DataGridView dataGridView_information;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newid_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}