namespace finalproject
{
    partial class adminform
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
            this.btn_visitdoctors = new System.Windows.Forms.Button();
            this.btn_visitbimar = new System.Windows.Forms.Button();
            this.btn_visitassistant = new System.Windows.Forms.Button();
            this.btn_visitsahamdar = new System.Windows.Forms.Button();
            this.datagridviewdoctors = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewdoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "رئیس کلینیک";
            // 
            // btn_visitdoctors
            // 
            this.btn_visitdoctors.BackColor = System.Drawing.SystemColors.Info;
            this.btn_visitdoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visitdoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_visitdoctors.ForeColor = System.Drawing.Color.Brown;
            this.btn_visitdoctors.Location = new System.Drawing.Point(37, 307);
            this.btn_visitdoctors.Name = "btn_visitdoctors";
            this.btn_visitdoctors.Size = new System.Drawing.Size(218, 102);
            this.btn_visitdoctors.TabIndex = 2;
            this.btn_visitdoctors.Text = "مشاهده لیست پزشکان کلینیک";
            this.btn_visitdoctors.UseVisualStyleBackColor = false;
            this.btn_visitdoctors.Click += new System.EventHandler(this.btn_visitdoctors_Click);
            // 
            // btn_visitbimar
            // 
            this.btn_visitbimar.BackColor = System.Drawing.SystemColors.Info;
            this.btn_visitbimar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visitbimar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_visitbimar.ForeColor = System.Drawing.Color.Brown;
            this.btn_visitbimar.Location = new System.Drawing.Point(37, 438);
            this.btn_visitbimar.Name = "btn_visitbimar";
            this.btn_visitbimar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_visitbimar.Size = new System.Drawing.Size(218, 92);
            this.btn_visitbimar.TabIndex = 3;
            this.btn_visitbimar.Text = "مشاهده لیست بیماران";
            this.btn_visitbimar.UseVisualStyleBackColor = false;
            this.btn_visitbimar.Click += new System.EventHandler(this.btn_visitbimar_Click);
            // 
            // btn_visitassistant
            // 
            this.btn_visitassistant.BackColor = System.Drawing.SystemColors.Info;
            this.btn_visitassistant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visitassistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_visitassistant.ForeColor = System.Drawing.Color.Brown;
            this.btn_visitassistant.Location = new System.Drawing.Point(37, 565);
            this.btn_visitassistant.Name = "btn_visitassistant";
            this.btn_visitassistant.Size = new System.Drawing.Size(218, 96);
            this.btn_visitassistant.TabIndex = 4;
            this.btn_visitassistant.Text = "مشاهده لیست دستیاران پزشکان کلینیک";
            this.btn_visitassistant.UseVisualStyleBackColor = false;
            this.btn_visitassistant.Click += new System.EventHandler(this.btn_visitassistant_Click);
            // 
            // btn_visitsahamdar
            // 
            this.btn_visitsahamdar.BackColor = System.Drawing.SystemColors.Info;
            this.btn_visitsahamdar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visitsahamdar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_visitsahamdar.ForeColor = System.Drawing.Color.Brown;
            this.btn_visitsahamdar.Location = new System.Drawing.Point(37, 702);
            this.btn_visitsahamdar.Name = "btn_visitsahamdar";
            this.btn_visitsahamdar.Size = new System.Drawing.Size(218, 94);
            this.btn_visitsahamdar.TabIndex = 5;
            this.btn_visitsahamdar.Text = "مشاهده لیست سهامداران";
            this.btn_visitsahamdar.UseVisualStyleBackColor = false;
            this.btn_visitsahamdar.Click += new System.EventHandler(this.btn_visitsahamdar_Click);
            // 
            // datagridviewdoctors
            // 
            this.datagridviewdoctors.BackgroundColor = System.Drawing.Color.Thistle;
            this.datagridviewdoctors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridviewdoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewdoctors.Location = new System.Drawing.Point(283, 22);
            this.datagridviewdoctors.Name = "datagridviewdoctors";
            this.datagridviewdoctors.RowHeadersWidth = 62;
            this.datagridviewdoctors.RowTemplate.Height = 28;
            this.datagridviewdoctors.Size = new System.Drawing.Size(1355, 804);
            this.datagridviewdoctors.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::finalproject.Properties.Resources.index;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(53, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 219);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1693, 901);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datagridviewdoctors);
            this.Controls.Add(this.btn_visitsahamdar);
            this.Controls.Add(this.btn_visitassistant);
            this.Controls.Add(this.btn_visitbimar);
            this.Controls.Add(this.btn_visitdoctors);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "adminform";
            this.Text = "adminform";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewdoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_visitdoctors;
        private System.Windows.Forms.Button btn_visitbimar;
        private System.Windows.Forms.Button btn_visitassistant;
        private System.Windows.Forms.Button btn_visitsahamdar;
        private System.Windows.Forms.DataGridView datagridviewdoctors;
        private System.Windows.Forms.Button button1;
    }
}