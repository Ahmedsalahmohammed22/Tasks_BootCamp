namespace EF_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV_Employee = new DataGridView();
            Employees = new Label();
            button_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Employee).BeginInit();
            SuspendLayout();
            // 
            // DGV_Employee
            // 
            DGV_Employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Employee.Location = new Point(-2, 92);
            DGV_Employee.Name = "DGV_Employee";
            DGV_Employee.RowHeadersWidth = 50;
            DGV_Employee.Size = new Size(800, 208);
            DGV_Employee.TabIndex = 0;
            DGV_Employee.RowHeaderMouseClick += DGV_Employee_RowHeaderMouseClick;
            // 
            // Employees
            // 
            Employees.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Employees.Location = new Point(288, 21);
            Employees.Name = "Employees";
            Employees.Size = new Size(243, 39);
            Employees.TabIndex = 1;
            Employees.Text = "Employees";
            Employees.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Add
            // 
            button_Add.BackColor = SystemColors.HotTrack;
            button_Add.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Add.ForeColor = SystemColors.ActiveCaptionText;
            button_Add.Location = new Point(638, 320);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(137, 50);
            button_Add.TabIndex = 2;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Add);
            Controls.Add(Employees);
            Controls.Add(DGV_Employee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Employee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Employee;
        private Label Employees;
        private Button button_Add;
    }
}
