namespace ITP4915M_Lab.Lab2
{
    partial class Lab2a
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
            this.groupBox_WineList = new System.Windows.Forms.GroupBox();
            this.rbt_RedWine = new System.Windows.Forms.RadioButton();
            this.rbt_WhiteWine = new System.Windows.Forms.RadioButton();
            this.rbt_Beer = new System.Windows.Forms.RadioButton();
            this.groupBox_WineList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_WineList
            // 
            this.groupBox_WineList.Controls.Add(this.rbt_Beer);
            this.groupBox_WineList.Controls.Add(this.rbt_WhiteWine);
            this.groupBox_WineList.Controls.Add(this.rbt_RedWine);
            this.groupBox_WineList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_WineList.Location = new System.Drawing.Point(12, 12);
            this.groupBox_WineList.Name = "groupBox_WineList";
            this.groupBox_WineList.Size = new System.Drawing.Size(459, 316);
            this.groupBox_WineList.TabIndex = 0;
            this.groupBox_WineList.TabStop = false;
            this.groupBox_WineList.Text = "Wine List";
            // 
            // rbt_RedWine
            // 
            this.rbt_RedWine.AutoSize = true;
            this.rbt_RedWine.Location = new System.Drawing.Point(17, 60);
            this.rbt_RedWine.Name = "rbt_RedWine";
            this.rbt_RedWine.Size = new System.Drawing.Size(211, 33);
            this.rbt_RedWine.TabIndex = 1;
            this.rbt_RedWine.TabStop = true;
            this.rbt_RedWine.Text = "Red Wine ($250)";
            this.rbt_RedWine.UseVisualStyleBackColor = true;
            // 
            // rbt_WhiteWine
            // 
            this.rbt_WhiteWine.AutoSize = true;
            this.rbt_WhiteWine.Location = new System.Drawing.Point(17, 101);
            this.rbt_WhiteWine.Name = "rbt_WhiteWine";
            this.rbt_WhiteWine.Size = new System.Drawing.Size(227, 33);
            this.rbt_WhiteWine.TabIndex = 2;
            this.rbt_WhiteWine.TabStop = true;
            this.rbt_WhiteWine.Text = "White Wine ($180)";
            this.rbt_WhiteWine.UseVisualStyleBackColor = true;
            // 
            // rbt_Beer
            // 
            this.rbt_Beer.AutoSize = true;
            this.rbt_Beer.Location = new System.Drawing.Point(17, 142);
            this.rbt_Beer.Name = "rbt_Beer";
            this.rbt_Beer.Size = new System.Drawing.Size(235, 33);
            this.rbt_Beer.TabIndex = 3;
            this.rbt_Beer.TabStop = true;
            this.rbt_Beer.Text = "Beer 1 dozen ($75)";
            this.rbt_Beer.UseVisualStyleBackColor = true;
            // 
            // Lab2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_WineList);
            this.Name = "Lab2a";
            this.Text = "Lab2a";
            this.groupBox_WineList.ResumeLayout(false);
            this.groupBox_WineList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_WineList;
        private System.Windows.Forms.RadioButton rbt_Beer;
        private System.Windows.Forms.RadioButton rbt_WhiteWine;
        private System.Windows.Forms.RadioButton rbt_RedWine;
    }
}