namespace ITP4915M_Lab.Lab2
{
    partial class Lab2b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2b));
            this.lb_EnterName = new System.Windows.Forms.Label();
            this.tb_EnterName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Sunny = new System.Windows.Forms.RadioButton();
            this.rb_Snowy = new System.Windows.Forms.RadioButton();
            this.rb_Rainy = new System.Windows.Forms.RadioButton();
            this.rb_Cloudy = new System.Windows.Forms.RadioButton();
            this.pic_Cloudy = new System.Windows.Forms.PictureBox();
            this.pic_Snowy = new System.Windows.Forms.PictureBox();
            this.pic_Sunny = new System.Windows.Forms.PictureBox();
            this.pic_Rainy = new System.Windows.Forms.PictureBox();
            this.lb_Message = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Snowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Rainy)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_EnterName
            // 
            this.lb_EnterName.AutoSize = true;
            this.lb_EnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EnterName.Location = new System.Drawing.Point(12, 26);
            this.lb_EnterName.Name = "lb_EnterName";
            this.lb_EnterName.Size = new System.Drawing.Size(263, 29);
            this.lb_EnterName.TabIndex = 0;
            this.lb_EnterName.Text = "Enter Your Name Here:";
            // 
            // tb_EnterName
            // 
            this.tb_EnterName.Location = new System.Drawing.Point(281, 35);
            this.tb_EnterName.Name = "tb_EnterName";
            this.tb_EnterName.Size = new System.Drawing.Size(204, 20);
            this.tb_EnterName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Sunny);
            this.groupBox1.Controls.Add(this.rb_Snowy);
            this.groupBox1.Controls.Add(this.rb_Rainy);
            this.groupBox1.Controls.Add(this.rb_Cloudy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 269);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // rb_Sunny
            // 
            this.rb_Sunny.AutoSize = true;
            this.rb_Sunny.Location = new System.Drawing.Point(25, 160);
            this.rb_Sunny.Name = "rb_Sunny";
            this.rb_Sunny.Size = new System.Drawing.Size(97, 33);
            this.rb_Sunny.TabIndex = 3;
            this.rb_Sunny.TabStop = true;
            this.rb_Sunny.Text = "Sunny";
            this.rb_Sunny.UseVisualStyleBackColor = true;
            this.rb_Sunny.CheckedChanged += new System.EventHandler(this.rb_Sunny_CheckedChanged);
            // 
            // rb_Snowy
            // 
            this.rb_Snowy.AutoSize = true;
            this.rb_Snowy.Location = new System.Drawing.Point(25, 121);
            this.rb_Snowy.Name = "rb_Snowy";
            this.rb_Snowy.Size = new System.Drawing.Size(103, 33);
            this.rb_Snowy.TabIndex = 2;
            this.rb_Snowy.TabStop = true;
            this.rb_Snowy.Text = "Snowy";
            this.rb_Snowy.UseVisualStyleBackColor = true;
            this.rb_Snowy.CheckedChanged += new System.EventHandler(this.rb_Snowy_CheckedChanged);
            // 
            // rb_Rainy
            // 
            this.rb_Rainy.AutoSize = true;
            this.rb_Rainy.Location = new System.Drawing.Point(25, 82);
            this.rb_Rainy.Name = "rb_Rainy";
            this.rb_Rainy.Size = new System.Drawing.Size(91, 33);
            this.rb_Rainy.TabIndex = 1;
            this.rb_Rainy.TabStop = true;
            this.rb_Rainy.Text = "Rainy";
            this.rb_Rainy.UseVisualStyleBackColor = true;
            this.rb_Rainy.CheckedChanged += new System.EventHandler(this.rb_Rainy_CheckedChanged);
            // 
            // rb_Cloudy
            // 
            this.rb_Cloudy.AutoSize = true;
            this.rb_Cloudy.Location = new System.Drawing.Point(25, 43);
            this.rb_Cloudy.Name = "rb_Cloudy";
            this.rb_Cloudy.Size = new System.Drawing.Size(106, 33);
            this.rb_Cloudy.TabIndex = 0;
            this.rb_Cloudy.TabStop = true;
            this.rb_Cloudy.Text = "Cloudy";
            this.rb_Cloudy.UseVisualStyleBackColor = true;
            this.rb_Cloudy.CheckedChanged += new System.EventHandler(this.rb_Cloudy_CheckedChanged);
            // 
            // pic_Cloudy
            // 
            this.pic_Cloudy.Image = ((System.Drawing.Image)(resources.GetObject("pic_Cloudy.Image")));
            this.pic_Cloudy.Location = new System.Drawing.Point(277, 105);
            this.pic_Cloudy.Name = "pic_Cloudy";
            this.pic_Cloudy.Size = new System.Drawing.Size(64, 64);
            this.pic_Cloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Cloudy.TabIndex = 3;
            this.pic_Cloudy.TabStop = false;
            // 
            // pic_Snowy
            // 
            this.pic_Snowy.Image = ((System.Drawing.Image)(resources.GetObject("pic_Snowy.Image")));
            this.pic_Snowy.Location = new System.Drawing.Point(277, 183);
            this.pic_Snowy.Name = "pic_Snowy";
            this.pic_Snowy.Size = new System.Drawing.Size(64, 64);
            this.pic_Snowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Snowy.TabIndex = 4;
            this.pic_Snowy.TabStop = false;
            // 
            // pic_Sunny
            // 
            this.pic_Sunny.Image = ((System.Drawing.Image)(resources.GetObject("pic_Sunny.Image")));
            this.pic_Sunny.Location = new System.Drawing.Point(360, 183);
            this.pic_Sunny.Name = "pic_Sunny";
            this.pic_Sunny.Size = new System.Drawing.Size(64, 64);
            this.pic_Sunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Sunny.TabIndex = 5;
            this.pic_Sunny.TabStop = false;
            // 
            // pic_Rainy
            // 
            this.pic_Rainy.Image = ((System.Drawing.Image)(resources.GetObject("pic_Rainy.Image")));
            this.pic_Rainy.Location = new System.Drawing.Point(360, 105);
            this.pic_Rainy.Name = "pic_Rainy";
            this.pic_Rainy.Size = new System.Drawing.Size(64, 64);
            this.pic_Rainy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Rainy.TabIndex = 6;
            this.pic_Rainy.TabStop = false;
            // 
            // lb_Message
            // 
            this.lb_Message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Message.Location = new System.Drawing.Point(17, 368);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(468, 73);
            this.lb_Message.TabIndex = 7;
            // 
            // Lab2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.pic_Rainy);
            this.Controls.Add(this.pic_Sunny);
            this.Controls.Add(this.pic_Snowy);
            this.Controls.Add(this.pic_Cloudy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_EnterName);
            this.Controls.Add(this.lb_EnterName);
            this.Name = "Lab2b";
            this.Text = "Lab2b";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Snowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Rainy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_EnterName;
        private System.Windows.Forms.TextBox tb_EnterName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Sunny;
        private System.Windows.Forms.RadioButton rb_Snowy;
        private System.Windows.Forms.RadioButton rb_Rainy;
        private System.Windows.Forms.RadioButton rb_Cloudy;
        private System.Windows.Forms.PictureBox pic_Cloudy;
        private System.Windows.Forms.PictureBox pic_Snowy;
        private System.Windows.Forms.PictureBox pic_Sunny;
        private System.Windows.Forms.PictureBox pic_Rainy;
        private System.Windows.Forms.Label lb_Message;
    }
}