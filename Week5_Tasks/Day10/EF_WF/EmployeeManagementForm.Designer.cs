namespace EF_WF
{
    partial class EmployeeManagementForm
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
            btn_delete = new Button();
            btn_edit = new Button();
            label6 = new Label();
            cb_department = new ComboBox();
            label5 = new Label();
            cb_gender = new ComboBox();
            label4 = new Label();
            txt_HireDate = new TextBox();
            label3 = new Label();
            txt_salary = new TextBox();
            label2 = new Label();
            txt_name = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.OliveDrab;
            btn_delete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(322, 321);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(128, 51);
            btn_delete.TabIndex = 25;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = SystemColors.Highlight;
            btn_edit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(78, 321);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(128, 51);
            btn_edit.TabIndex = 24;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(269, 25);
            label6.Name = "label6";
            label6.Size = new Size(274, 41);
            label6.TabIndex = 23;
            label6.Text = "Employee Managment";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cb_department
            // 
            cb_department.FormattingEnabled = true;
            cb_department.Location = new Point(183, 268);
            cb_department.Name = "cb_department";
            cb_department.Size = new Size(216, 23);
            cb_department.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 271);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 21;
            label5.Text = "Department";
            // 
            // cb_gender
            // 
            cb_gender.FormattingEnabled = true;
            cb_gender.Items.AddRange(new object[] { "F", "M" });
            cb_gender.Location = new Point(183, 225);
            cb_gender.Name = "cb_gender";
            cb_gender.Size = new Size(216, 23);
            cb_gender.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 228);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 19;
            label4.Text = "Gender";
            // 
            // txt_HireDate
            // 
            txt_HireDate.Location = new Point(183, 178);
            txt_HireDate.Name = "txt_HireDate";
            txt_HireDate.Size = new Size(216, 23);
            txt_HireDate.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 181);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 17;
            label3.Text = "HireDate";
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(183, 135);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(216, 23);
            txt_salary.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 138);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 15;
            label2.Text = "Salary";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(183, 89);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(216, 23);
            txt_name.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 92);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // EmployeeManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
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
            Name = "EmployeeManagementForm";
            Text = "EmployeeManagementForm";
            Load += EmployeeManagementForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete;
        private Button btn_edit;
        private Label label6;
        private ComboBox cb_department;
        private Label label5;
        private ComboBox cb_gender;
        private Label label4;
        private TextBox txt_HireDate;
        private Label label3;
        private TextBox txt_salary;
        private Label label2;
        private TextBox txt_name;
        private Label label1;
    }
}