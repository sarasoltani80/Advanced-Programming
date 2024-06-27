namespace finalproject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bimar_checked = new System.Windows.Forms.CheckBox();
            this.doctor_checked = new System.Windows.Forms.CheckBox();
            this.admin_checked = new System.Windows.Forms.CheckBox();
            this.kadredarman_checked = new System.Windows.Forms.CheckBox();
            this.nobatdahi_checked = new System.Windows.Forms.CheckBox();
            this.khadamat_checked = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bimar_checked
            // 
            this.bimar_checked.AutoSize = true;
            this.bimar_checked.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bimar_checked.ForeColor = System.Drawing.Color.YellowGreen;
            this.bimar_checked.Location = new System.Drawing.Point(950, 204);
            this.bimar_checked.Name = "bimar_checked";
            this.bimar_checked.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bimar_checked.Size = new System.Drawing.Size(105, 44);
            this.bimar_checked.TabIndex = 1;
            this.bimar_checked.Text = "بیمار";
            this.bimar_checked.UseVisualStyleBackColor = true;
            this.bimar_checked.CheckedChanged += new System.EventHandler(this.bimar_checked_CheckedChanged);
            // 
            // doctor_checked
            // 
            this.doctor_checked.AutoSize = true;
            this.doctor_checked.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.doctor_checked.ForeColor = System.Drawing.Color.YellowGreen;
            this.doctor_checked.Location = new System.Drawing.Point(938, 309);
            this.doctor_checked.Name = "doctor_checked";
            this.doctor_checked.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.doctor_checked.Size = new System.Drawing.Size(127, 50);
            this.doctor_checked.TabIndex = 2;
            this.doctor_checked.Text = "پزشک";
            this.doctor_checked.UseVisualStyleBackColor = true;
            this.doctor_checked.CheckedChanged += new System.EventHandler(this.doctor_checked_CheckedChanged);
            // 
            // admin_checked
            // 
            this.admin_checked.AutoSize = true;
            this.admin_checked.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.admin_checked.ForeColor = System.Drawing.Color.YellowGreen;
            this.admin_checked.Location = new System.Drawing.Point(881, 587);
            this.admin_checked.Name = "admin_checked";
            this.admin_checked.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.admin_checked.Size = new System.Drawing.Size(184, 41);
            this.admin_checked.TabIndex = 3;
            this.admin_checked.Text = "رئیس کلینیک";
            this.admin_checked.UseVisualStyleBackColor = true;
            this.admin_checked.CheckedChanged += new System.EventHandler(this.admin_checked_CheckedChanged);
            // 
            // kadredarman_checked
            // 
            this.kadredarman_checked.AutoSize = true;
            this.kadredarman_checked.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.kadredarman_checked.ForeColor = System.Drawing.Color.YellowGreen;
            this.kadredarman_checked.Location = new System.Drawing.Point(881, 444);
            this.kadredarman_checked.Name = "kadredarman_checked";
            this.kadredarman_checked.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kadredarman_checked.Size = new System.Drawing.Size(184, 44);
            this.kadredarman_checked.TabIndex = 4;
            this.kadredarman_checked.Text = "کادر درمان";
            this.kadredarman_checked.UseVisualStyleBackColor = true;
            this.kadredarman_checked.CheckedChanged += new System.EventHandler(this.kadredarman_checked_CheckedChanged);
            // 
            // nobatdahi_checked
            // 
            this.nobatdahi_checked.AutoSize = true;
            this.nobatdahi_checked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nobatdahi_checked.Location = new System.Drawing.Point(720, 193);
            this.nobatdahi_checked.Name = "nobatdahi_checked";
            this.nobatdahi_checked.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nobatdahi_checked.Size = new System.Drawing.Size(117, 30);
            this.nobatdahi_checked.TabIndex = 6;
            this.nobatdahi_checked.Text = "نوبت دهی";
            this.nobatdahi_checked.UseVisualStyleBackColor = true;
            this.nobatdahi_checked.Visible = false;
            this.nobatdahi_checked.CheckedChanged += new System.EventHandler(this.nobatdahi_checked_CheckedChanged);
            // 
            // khadamat_checked
            // 
            this.khadamat_checked.AutoSize = true;
            this.khadamat_checked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.khadamat_checked.Location = new System.Drawing.Point(635, 266);
            this.khadamat_checked.Name = "khadamat_checked";
            this.khadamat_checked.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.khadamat_checked.Size = new System.Drawing.Size(202, 30);
            this.khadamat_checked.TabIndex = 7;
            this.khadamat_checked.Text = "پس از ارائه خدمات ";
            this.khadamat_checked.UseVisualStyleBackColor = true;
            this.khadamat_checked.Visible = false;
            this.khadamat_checked.CheckedChanged += new System.EventHandler(this.khadamat_checked_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(404, 12);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(476, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "به کلینیک دندان پزشکی خوش آمدید!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(928, 119);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "چه نوع کاربری هستی؟";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.BackgroundImage = global::finalproject.Properties.Resources.nurse;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1071, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 89);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.BackgroundImage = global::finalproject.Properties.Resources.dentist;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1071, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 93);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::finalproject.Properties.Resources.dentistry__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 175);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(125, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 754);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.khadamat_checked);
            this.Controls.Add(this.nobatdahi_checked);
            this.Controls.Add(this.kadredarman_checked);
            this.Controls.Add(this.admin_checked);
            this.Controls.Add(this.doctor_checked);
            this.Controls.Add(this.bimar_checked);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox bimar_checked;
        private System.Windows.Forms.CheckBox doctor_checked;
        private System.Windows.Forms.CheckBox admin_checked;
        private System.Windows.Forms.CheckBox kadredarman_checked;
        private System.Windows.Forms.CheckBox nobatdahi_checked;
        private System.Windows.Forms.CheckBox khadamat_checked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

