namespace Newsproject
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
            DGV_News = new DataGridView();
            Employees = new Label();
            button_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_News).BeginInit();
            SuspendLayout();
            // 
            // DGV_News
            // 
            DGV_News.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_News.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_News.Location = new Point(12, 85);
            DGV_News.Name = "DGV_News";
            DGV_News.Size = new Size(776, 201);
            DGV_News.TabIndex = 0;
            DGV_News.RowHeaderMouseDoubleClick += DGV_News_RowHeaderMouseDoubleClick;
            // 
            // Employees
            // 
            Employees.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Employees.Location = new Point(278, 23);
            Employees.Name = "Employees";
            Employees.Size = new Size(243, 39);
            Employees.TabIndex = 2;
            Employees.Text = "News";
            Employees.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Add
            // 
            button_Add.BackColor = SystemColors.HotTrack;
            button_Add.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Add.ForeColor = SystemColors.ActiveCaptionText;
            button_Add.Location = new Point(651, 319);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(137, 50);
            button_Add.TabIndex = 3;
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
            Controls.Add(DGV_News);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_News).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_News;
        private Label Employees;
        private Button button_Add;
    }
}
