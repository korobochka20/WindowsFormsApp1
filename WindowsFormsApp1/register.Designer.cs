
namespace WindowsFormsApp1
{
    partial class register
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
            this.button1 = new System.Windows.Forms.Button();
            this.name1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passw1 = new System.Windows.Forms.TextBox();
            this.passw2 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.log1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(315, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "стать феечкой";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(88, 73);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(181, 20);
            this.name1.TabIndex = 3;
            this.name1.Enter += new System.EventHandler(this.name1_Enter);
            this.name1.Leave += new System.EventHandler(this.name1_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_3669338_lock_ic_icon_64px;
            this.pictureBox2.Location = new System.Drawing.Point(29, 261);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_4781818_account_avatar_face_man_people_icon_64px;
            this.pictureBox1.Location = new System.Drawing.Point(29, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "регистрация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.log1);
            this.panel1.Controls.Add(this.name2);
            this.panel1.Controls.Add(this.passw2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.passw1);
            this.panel1.Controls.Add(this.name1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // passw1
            // 
            this.passw1.Location = new System.Drawing.Point(88, 261);
            this.passw1.Name = "passw1";
            this.passw1.Size = new System.Drawing.Size(181, 20);
            this.passw1.TabIndex = 4;
            this.passw1.Enter += new System.EventHandler(this.passw1_Enter);
            this.passw1.Leave += new System.EventHandler(this.passw1_Leave);
            // 
            // passw2
            // 
            this.passw2.Location = new System.Drawing.Point(88, 287);
            this.passw2.Name = "passw2";
            this.passw2.Size = new System.Drawing.Size(181, 20);
            this.passw2.TabIndex = 6;
            this.passw2.Enter += new System.EventHandler(this.passw2_Enter);
            this.passw2.Leave += new System.EventHandler(this.passw2_Leave);
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(88, 104);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(181, 20);
            this.name2.TabIndex = 7;
            this.name2.Enter += new System.EventHandler(this.name2_Enter);
            this.name2.Leave += new System.EventHandler(this.name2_Leave);
            // 
            // log1
            // 
            this.log1.Location = new System.Drawing.Point(88, 235);
            this.log1.Name = "log1";
            this.log1.Size = new System.Drawing.Size(181, 20);
            this.log1.TabIndex = 8;
            this.log1.Enter += new System.EventHandler(this.log1_Enter);
            this.log1.Leave += new System.EventHandler(this.log1_Leave);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passw1;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox passw2;
        private System.Windows.Forms.TextBox log1;
    }
}