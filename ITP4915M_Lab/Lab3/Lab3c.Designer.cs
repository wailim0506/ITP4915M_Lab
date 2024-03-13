namespace ITP4915M_Lab.Lab3
{
    partial class Lab3c
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
            this.lst_Shop = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Shop
            // 
            this.lst_Shop.FormattingEnabled = true;
            this.lst_Shop.Location = new System.Drawing.Point(12, 12);
            this.lst_Shop.Name = "lst_Shop";
            this.lst_Shop.Size = new System.Drawing.Size(86, 121);
            this.lst_Shop.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(220, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(85, 121);
            this.listBox2.TabIndex = 1;
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(119, 33);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 2;
            this.btn_right.Text = "-->";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(119, 79);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 3;
            this.btn_left.Text = "<--";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(202, 148);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(103, 50);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear Cart";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(96, 148);
            this.btn_count.Margin = new System.Windows.Forms.Padding(0);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(103, 50);
            this.btn_count.TabIndex = 5;
            this.btn_count.Text = "Count Shop + Cart";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // Lab3c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 204);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lst_Shop);
            this.Name = "Lab3c";
            this.Text = "Lab3c";
            this.Load += new System.EventHandler(this.Lab3c_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Shop;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_count;
    }
}