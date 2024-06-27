namespace finalproject
{
    partial class loginbimarsforvisiting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.family_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.check_finished = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.canceling_chk = new System.Windows.Forms.CheckBox();
            this.not_canceling_chk = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(860, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم بیمار را وارد کن:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(810, 201);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی بیمار را وارد کن:";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(848, 121);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(202, 26);
            this.name_text.TabIndex = 2;
            this.name_text.TextChanged += new System.EventHandler(this.name_text_TextChanged);
            // 
            // family_text
            // 
            this.family_text.Location = new System.Drawing.Point(848, 269);
            this.family_text.Name = "family_text";
            this.family_text.Size = new System.Drawing.Size(202, 26);
            this.family_text.TabIndex = 3;
            this.family_text.TextChanged += new System.EventHandler(this.family_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(860, 352);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "آیدی بیمار را وارد کن:";
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(838, 424);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(202, 26);
            this.id_text.TabIndex = 5;
            this.id_text.TextChanged += new System.EventHandler(this.id_text_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(663, 516);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(413, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "اگر اطلاعات را کامل کردی دکمه تمام را انتخاب کن!!";
            // 
            // check_finished
            // 
            this.check_finished.AutoSize = true;
            this.check_finished.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.check_finished.ForeColor = System.Drawing.Color.Coral;
            this.check_finished.Location = new System.Drawing.Point(921, 578);
            this.check_finished.Name = "check_finished";
            this.check_finished.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_finished.Size = new System.Drawing.Size(86, 41);
            this.check_finished.TabIndex = 7;
            this.check_finished.Text = "تمام";
            this.check_finished.UseVisualStyleBackColor = true;
            this.check_finished.CheckedChanged += new System.EventHandler(this.check_finished_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(360, 62);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "آیا میخواهی نوبتت را لغو کنی؟";
            this.label5.Visible = false;
            // 
            // canceling_chk
            // 
            this.canceling_chk.AutoSize = true;
            this.canceling_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.canceling_chk.ForeColor = System.Drawing.Color.Coral;
            this.canceling_chk.Location = new System.Drawing.Point(514, 131);
            this.canceling_chk.Name = "canceling_chk";
            this.canceling_chk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.canceling_chk.Size = new System.Drawing.Size(73, 41);
            this.canceling_chk.TabIndex = 9;
            this.canceling_chk.Text = "بله";
            this.canceling_chk.UseVisualStyleBackColor = true;
            this.canceling_chk.Visible = false;
            this.canceling_chk.CheckedChanged += new System.EventHandler(this.canceling_chk_CheckedChanged);
            // 
            // not_canceling_chk
            // 
            this.not_canceling_chk.AutoSize = true;
            this.not_canceling_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.not_canceling_chk.ForeColor = System.Drawing.Color.Coral;
            this.not_canceling_chk.Location = new System.Drawing.Point(350, 131);
            this.not_canceling_chk.Name = "not_canceling_chk";
            this.not_canceling_chk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.not_canceling_chk.Size = new System.Drawing.Size(87, 41);
            this.not_canceling_chk.TabIndex = 10;
            this.not_canceling_chk.Text = "خیر";
            this.not_canceling_chk.UseVisualStyleBackColor = true;
            this.not_canceling_chk.Visible = false;
            this.not_canceling_chk.CheckedChanged += new System.EventHandler(this.not_canceling_chk_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::finalproject.Properties.Resources.tabir_khab_kelid;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(2, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 242);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // loginbimarsforvisiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 716);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.not_canceling_chk);
            this.Controls.Add(this.canceling_chk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.check_finished);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.family_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginbimarsforvisiting";
            this.Text = "loginbimarsforvisiting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox family_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox check_finished;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox canceling_chk;
        private System.Windows.Forms.CheckBox not_canceling_chk;
        private System.Windows.Forms.Button button2;
    }
}