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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(86, 121);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(266, 50);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(85, 121);
            this.listBox2.TabIndex = 1;
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(164, 48);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 2;
            this.btn_right.Text = "-->";
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(164, 94);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 3;
            this.btn_left.Text = "<--";
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(248, 198);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(103, 50);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear Cart";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(113, 198);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(103, 50);
            this.btn_count.TabIndex = 5;
            this.btn_count.Text = "Count Shop + Cart";
            this.btn_count.UseVisualStyleBackColor = true;
            // 
            // Lab3c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 289);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Lab3c";
            this.Text = "Lab3c";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_count;
    }
}