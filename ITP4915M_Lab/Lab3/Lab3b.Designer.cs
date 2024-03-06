namespace ITP4915M_Lab.Lab3
{
    partial class Lab3b
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
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_InterestRate = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_YeartoReach = new System.Windows.Forms.Label();
            this.lb_Value10Year = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(164, 11);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(105, 20);
            this.txt_Amount.TabIndex = 0;
            // 
            // txt_InterestRate
            // 
            this.txt_InterestRate.Location = new System.Drawing.Point(164, 71);
            this.txt_InterestRate.Name = "txt_InterestRate";
            this.txt_InterestRate.Size = new System.Drawing.Size(105, 20);
            this.txt_InterestRate.TabIndex = 1;
            this.txt_InterestRate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(13, 116);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(256, 23);
            this.btn_Calculate.TabIndex = 2;
            this.btn_Calculate.Text = "Start Calculation";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interest Rate\r\n(Annual)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year to reach\r\n$1M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Value after 10\r\nyears";
            // 
            // lb_YeartoReach
            // 
            this.lb_YeartoReach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_YeartoReach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_YeartoReach.Location = new System.Drawing.Point(164, 216);
            this.lb_YeartoReach.Name = "lb_YeartoReach";
            this.lb_YeartoReach.Size = new System.Drawing.Size(105, 25);
            this.lb_YeartoReach.TabIndex = 8;
            // 
            // lb_Value10Year
            // 
            this.lb_Value10Year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Value10Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Value10Year.Location = new System.Drawing.Point(164, 161);
            this.lb_Value10Year.Name = "lb_Value10Year";
            this.lb_Value10Year.Size = new System.Drawing.Size(105, 25);
            this.lb_Value10Year.TabIndex = 9;
            // 
            // Lab3b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 264);
            this.Controls.Add(this.lb_Value10Year);
            this.Controls.Add(this.lb_YeartoReach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txt_InterestRate);
            this.Controls.Add(this.txt_Amount);
            this.Name = "Lab3b";
            this.Text = "Lab3b";
            this.Load += new System.EventHandler(this.Lab3b_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_InterestRate;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_YeartoReach;
        private System.Windows.Forms.Label lb_Value10Year;
    }
}