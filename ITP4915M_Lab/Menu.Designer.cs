namespace ITP4915M_Lab
{
    partial class Menu
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
            this.btnLab1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLab1
            // 
            this.btnLab1.Location = new System.Drawing.Point(249, 127);
            this.btnLab1.Name = "btnLab1";
            this.btnLab1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLab1.Size = new System.Drawing.Size(75, 23);
            this.btnLab1.TabIndex = 0;
            this.btnLab1.Text = "Lab1";
            this.btnLab1.UseVisualStyleBackColor = true;
            this.btnLab1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 385);
            this.Controls.Add(this.btnLab1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLab1;
    }
}