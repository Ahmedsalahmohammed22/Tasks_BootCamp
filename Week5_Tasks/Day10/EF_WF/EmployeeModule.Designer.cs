namespace EF_WF
{
    partial class EmployeeModule
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
            label1 = new Label();
            txt_name = new TextBox();
            txt_salary = new TextBox();
            label2 = new Label();
            txt_HireDate = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cb_gender = new ComboBox();
            cb_department = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            btn_save = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 81);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(170, 78);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(216, 23);
            txt_name.TabIndex = 1;
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(170, 124);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(216, 23);
            txt_salary.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 127);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Salary";
            // 
            // txt_HireDate
            // 
            txt_HireDate.Location = new Point(170, 167);
            txt_HireDate.Name = "txt_HireDate";
            txt_HireDate.Size = new Size(216, 23);
            txt_HireDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 170);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "HireDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 217);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // cb_gender
            // 
            cb_gender.FormattingEnabled = true;
            cb_gender.Items.AddRange(new object[] { "F", "M" });
            cb_gender.Location = new Point(170, 214);
            cb_gender.Name = "cb_gender";
            cb_gender.Size = new Size(216, 23);
            cb_gender.TabIndex = 7;
            cb_gender.Text = "Select Gender";
            // 
            // cb_department
            // 
            cb_department.FormattingEnabled = true;
            cb_department.Location = new Point(170, 257);
            cb_department.Name = "cb_department";
            cb_department.Size = new Size(216, 23);
            cb_department.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 260);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Department";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(256, 14);
            label6.Name = "label6";
            label6.Size = new Size(274, 41);
            label6.TabIndex = 10;
            label6.Text = "Add Employee";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.Highlight;
            btn_save.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.Location = new Point(96, 310);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(128, 51);
            btn_save.TabIndex = 11;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Orange;
            btn_cancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancel.Location = new Point(370, 310);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(128, 51);
            btn_cancel.TabIndex = 12;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // EmployeeModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(label6);
            Controls.Add(cb_department);
            Controls.Add(label5);
            Controls.Add(cb_gender);
            Controls.Add(label4);
            Controls.Add(txt_HireDate);
            Controls.Add(label3);
            Controls.Add(txt_salary);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Name = "EmployeeModule";
            Text = "EmployeeModule";
            Load += EmployeeModule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_name;
        private TextBox txt_salary;
        private Label label2;
        private TextBox txt_HireDate;
        private Label label3;
        private Label label4;
        private ComboBox cb_gender;
        private ComboBox cb_department;
        private Label label5;
        private Label label6;
        private Button btn_save;
        private Button btn_cancel;
    }
}