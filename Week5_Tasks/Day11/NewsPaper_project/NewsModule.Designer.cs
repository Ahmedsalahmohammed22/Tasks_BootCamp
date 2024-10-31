namespace Newsproject
{
    partial class NewsModule
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
            Employees = new Label();
            txt_title = new TextBox();
            lbl_title = new Label();
            lbl_description = new Label();
            txt_desc = new TextBox();
            cb_author = new ComboBox();
            lbl_author = new Label();
            cb_catalog = new ComboBox();
            lbl_catalog = new Label();
            btn_cancel = new Button();
            btn_save = new Button();
            SuspendLayout();
            // 
            // Employees
            // 
            Employees.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Employees.Location = new Point(274, 9);
            Employees.Name = "Employees";
            Employees.Size = new Size(243, 39);
            Employees.TabIndex = 3;
            Employees.Text = "Add News";
            Employees.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_title
            // 
            txt_title.Location = new Point(320, 80);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(216, 23);
            txt_title.TabIndex = 4;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(203, 88);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(29, 15);
            lbl_title.TabIndex = 5;
            lbl_title.Text = "Title";
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.Location = new Point(203, 131);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(67, 15);
            lbl_description.TabIndex = 7;
            lbl_description.Text = "Description";
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(320, 123);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(216, 23);
            txt_desc.TabIndex = 6;
            // 
            // cb_author
            // 
            cb_author.FormattingEnabled = true;
            cb_author.Location = new Point(320, 169);
            cb_author.Name = "cb_author";
            cb_author.Size = new Size(216, 23);
            cb_author.TabIndex = 11;
            // 
            // lbl_author
            // 
            lbl_author.AutoSize = true;
            lbl_author.Location = new Point(203, 169);
            lbl_author.Name = "lbl_author";
            lbl_author.Size = new Size(77, 15);
            lbl_author.TabIndex = 10;
            lbl_author.Text = "Author name";
            // 
            // cb_catalog
            // 
            cb_catalog.FormattingEnabled = true;
            cb_catalog.Location = new Point(320, 212);
            cb_catalog.Name = "cb_catalog";
            cb_catalog.Size = new Size(216, 23);
            cb_catalog.TabIndex = 13;
            // 
            // lbl_catalog
            // 
            lbl_catalog.AutoSize = true;
            lbl_catalog.Location = new Point(203, 215);
            lbl_catalog.Name = "lbl_catalog";
            lbl_catalog.Size = new Size(81, 15);
            lbl_catalog.TabIndex = 12;
            lbl_catalog.Text = "Catalog name";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Orange;
            btn_cancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancel.Location = new Point(455, 293);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(128, 51);
            btn_cancel.TabIndex = 15;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.Highlight;
            btn_save.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.Location = new Point(181, 293);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(128, 51);
            btn_save.TabIndex = 14;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // NewsModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(cb_catalog);
            Controls.Add(lbl_catalog);
            Controls.Add(cb_author);
            Controls.Add(lbl_author);
            Controls.Add(lbl_description);
            Controls.Add(txt_desc);
            Controls.Add(lbl_title);
            Controls.Add(txt_title);
            Controls.Add(Employees);
            Name = "NewsModule";
            Text = "NewsModule";
            Load += NewsModule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Employees;
        private TextBox txt_title;
        private Label lbl_title;
        private Label lbl_description;
        private TextBox txt_desc;
        private Label label3;
        private TextBox textBox2;
        private ComboBox cb_author;
        private Label lbl_author;
        private ComboBox cb_catalog;
        private Label lbl_catalog;
        private Button btn_cancel;
        private Button btn_save;
    }
}