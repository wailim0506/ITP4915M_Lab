namespace ITP4915M_Lab.Lab2
{
    partial class Lab2c
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lb_Delete = new System.Windows.Forms.Label();
            this.lb_Message = new System.Windows.Forms.Label();
            this.lst_Student = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 14;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(214, 60);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add an Item";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lb_Delete
            // 
            this.lb_Delete.AutoSize = true;
            this.lb_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Delete.Location = new System.Drawing.Point(211, 134);
            this.lb_Delete.Name = "lb_Delete";
            this.lb_Delete.Size = new System.Drawing.Size(140, 13);
            this.lb_Delete.TabIndex = 12;
            this.lb_Delete.Text = "[Double click to delete]";
            // 
            // lb_Message
            // 
            this.lb_Message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Message.Location = new System.Drawing.Point(12, 208);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(413, 63);
            this.lb_Message.TabIndex = 11;
            // 
            // lst_Student
            // 
            this.lst_Student.FormattingEnabled = true;
            this.lst_Student.Location = new System.Drawing.Point(12, 12);
            this.lst_Student.Name = "lst_Student";
            this.lst_Student.Size = new System.Drawing.Size(166, 147);
            this.lst_Student.TabIndex = 10;
            this.lst_Student.Click += new System.EventHandler(this.lst_Student_Click);
            this.lst_Student.DoubleClick += new System.EventHandler(this.lst_Student_DoubleClick);
            // 
            // Lab2c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 290);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lb_Delete);
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.lst_Student);
            this.Name = "Lab2c";
            this.Text = "Lab2c";
            this.Load += new System.EventHandler(this.Lab2c_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lb_Delete;
        private System.Windows.Forms.Label lb_Message;
        private System.Windows.Forms.ListBox lst_Student;
    }
}