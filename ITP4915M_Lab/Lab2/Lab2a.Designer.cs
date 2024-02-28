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
            this.groupBox_PaymentMethod = new System.Windows.Forms.GroupBox();
            this.rbt_visa = new System.Windows.Forms.RadioButton();
            this.rbt_master = new System.Windows.Forms.RadioButton();
            this.lb_Qty = new System.Windows.Forms.Label();
            this.textBox_Qty = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lb_Result = new System.Windows.Forms.Label();
            this.groupBox_WineList.SuspendLayout();
            this.groupBox_PaymentMethod.SuspendLayout();
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
            this.groupBox_WineList.Size = new System.Drawing.Size(299, 185);
            this.groupBox_WineList.TabIndex = 0;
            this.groupBox_WineList.TabStop = false;
            this.groupBox_WineList.Text = "Wine List";
            // 
            // rbt_RedWine
            // 
            this.rbt_RedWine.AutoSize = true;
            this.rbt_RedWine.Location = new System.Drawing.Point(6, 44);
            this.rbt_RedWine.Name = "rbt_RedWine";
            this.rbt_RedWine.Size = new System.Drawing.Size(211, 33);
            this.rbt_RedWine.TabIndex = 1;
            this.rbt_RedWine.TabStop = true;
            this.rbt_RedWine.Text = "Red Wine ($250)";
            this.rbt_RedWine.UseVisualStyleBackColor = true;
            this.rbt_RedWine.CheckedChanged += new System.EventHandler(this.rbt_RedWine_CheckedChanged);
            // 
            // rbt_WhiteWine
            // 
            this.rbt_WhiteWine.AutoSize = true;
            this.rbt_WhiteWine.Location = new System.Drawing.Point(6, 85);
            this.rbt_WhiteWine.Name = "rbt_WhiteWine";
            this.rbt_WhiteWine.Size = new System.Drawing.Size(227, 33);
            this.rbt_WhiteWine.TabIndex = 2;
            this.rbt_WhiteWine.TabStop = true;
            this.rbt_WhiteWine.Text = "White Wine ($180)";
            this.rbt_WhiteWine.UseVisualStyleBackColor = true;
            this.rbt_WhiteWine.CheckedChanged += new System.EventHandler(this.rbt_WhiteWine_CheckedChanged);
            // 
            // rbt_Beer
            // 
            this.rbt_Beer.AutoSize = true;
            this.rbt_Beer.Location = new System.Drawing.Point(6, 126);
            this.rbt_Beer.Name = "rbt_Beer";
            this.rbt_Beer.Size = new System.Drawing.Size(235, 33);
            this.rbt_Beer.TabIndex = 3;
            this.rbt_Beer.TabStop = true;
            this.rbt_Beer.Text = "Beer 1 dozen ($75)";
            this.rbt_Beer.UseVisualStyleBackColor = true;
            this.rbt_Beer.CheckedChanged += new System.EventHandler(this.rbt_Beer_CheckedChanged);
            // 
            // groupBox_PaymentMethod
            // 
            this.groupBox_PaymentMethod.Controls.Add(this.rbt_master);
            this.groupBox_PaymentMethod.Controls.Add(this.rbt_visa);
            this.groupBox_PaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PaymentMethod.Location = new System.Drawing.Point(332, 12);
            this.groupBox_PaymentMethod.Name = "groupBox_PaymentMethod";
            this.groupBox_PaymentMethod.Size = new System.Drawing.Size(255, 134);
            this.groupBox_PaymentMethod.TabIndex = 1;
            this.groupBox_PaymentMethod.TabStop = false;
            this.groupBox_PaymentMethod.Text = "Payment Method";
            // 
            // rbt_visa
            // 
            this.rbt_visa.AutoSize = true;
            this.rbt_visa.Location = new System.Drawing.Point(6, 44);
            this.rbt_visa.Name = "rbt_visa";
            this.rbt_visa.Size = new System.Drawing.Size(83, 33);
            this.rbt_visa.TabIndex = 0;
            this.rbt_visa.TabStop = true;
            this.rbt_visa.Text = "VISA";
            this.rbt_visa.UseVisualStyleBackColor = true;
            this.rbt_visa.CheckedChanged += new System.EventHandler(this.rbt_visa_CheckedChanged);
            // 
            // rbt_master
            // 
            this.rbt_master.AutoSize = true;
            this.rbt_master.Location = new System.Drawing.Point(6, 85);
            this.rbt_master.Name = "rbt_master";
            this.rbt_master.Size = new System.Drawing.Size(104, 33);
            this.rbt_master.TabIndex = 1;
            this.rbt_master.TabStop = true;
            this.rbt_master.Text = "Master";
            this.rbt_master.UseVisualStyleBackColor = true;
            this.rbt_master.CheckedChanged += new System.EventHandler(this.rbt_master_CheckedChanged);
            // 
            // lb_Qty
            // 
            this.lb_Qty.AutoSize = true;
            this.lb_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Qty.Location = new System.Drawing.Point(317, 158);
            this.lb_Qty.Name = "lb_Qty";
            this.lb_Qty.Size = new System.Drawing.Size(49, 29);
            this.lb_Qty.TabIndex = 2;
            this.lb_Qty.Text = "Qty";
            // 
            // textBox_Qty
            // 
            this.textBox_Qty.Location = new System.Drawing.Point(369, 167);
            this.textBox_Qty.Name = "textBox_Qty";
            this.textBox_Qty.Size = new System.Drawing.Size(100, 20);
            this.textBox_Qty.TabIndex = 3;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.Location = new System.Drawing.Point(475, 152);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(112, 50);
            this.btn_Calculate.TabIndex = 4;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // lb_Result
            // 
            this.lb_Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Result.Location = new System.Drawing.Point(12, 221);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(575, 75);
            this.lb_Result.TabIndex = 5;
            this.lb_Result.Click += new System.EventHandler(this.lb_Result_Click);
            // 
            // Lab2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 316);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.textBox_Qty);
            this.Controls.Add(this.lb_Qty);
            this.Controls.Add(this.groupBox_PaymentMethod);
            this.Controls.Add(this.groupBox_WineList);
            this.Name = "Lab2a";
            this.Text = "Lab2a";
            this.Load += new System.EventHandler(this.Lab2a_Load);
            this.groupBox_WineList.ResumeLayout(false);
            this.groupBox_WineList.PerformLayout();
            this.groupBox_PaymentMethod.ResumeLayout(false);
            this.groupBox_PaymentMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_WineList;
        private System.Windows.Forms.RadioButton rbt_Beer;
        private System.Windows.Forms.RadioButton rbt_WhiteWine;
        private System.Windows.Forms.RadioButton rbt_RedWine;
        private System.Windows.Forms.GroupBox groupBox_PaymentMethod;
        private System.Windows.Forms.RadioButton rbt_master;
        private System.Windows.Forms.RadioButton rbt_visa;
        private System.Windows.Forms.Label lb_Qty;
        private System.Windows.Forms.TextBox textBox_Qty;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lb_Result;
    }
}