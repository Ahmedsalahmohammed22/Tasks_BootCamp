namespace Newsproject
{
    partial class NewsManagment
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
            cb_catalog = new ComboBox();
            lbl_catalog = new Label();
            cb_author = new ComboBox();
            lbl_author = new Label();
            lbl_description = new Label();
            txt_desc = new TextBox();
            lbl_title = new Label();
            txt_title = new TextBox();
            Employees = new Label();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(471, 293);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(128, 51);
            btn_delete.TabIndex = 26;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = SystemColors.Highlight;
            btn_edit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(197, 293);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(128, 51);
            btn_edit.TabIndex = 25;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // cb_catalog
            // 
            cb_catalog.FormattingEnabled = true;
            cb_catalog.Location = new Point(336, 212);
            cb_catalog.Name = "cb_catalog";
            cb_catalog.Size = new Size(216, 23);
            cb_catalog.TabIndex = 24;
            // 
            // lbl_catalog
            // 
            lbl_catalog.AutoSize = true;
            lbl_catalog.Location = new Point(219, 215);
            lbl_catalog.Name = "lbl_catalog";
            lbl_catalog.Size = new Size(81, 15);
            lbl_catalog.TabIndex = 23;
            lbl_catalog.Text = "Catalog name";
            // 
            // cb_author
            // 
            cb_author.FormattingEnabled = true;
            cb_author.Location = new Point(336, 169);
            cb_author.Name = "cb_author";
            cb_author.Size = new Size(216, 23);
            cb_author.TabIndex = 22;
            // 
            // lbl_author
            // 
            lbl_author.AutoSize = true;
            lbl_author.Location = new Point(219, 169);
            lbl_author.Name = "lbl_author";
            lbl_author.Size = new Size(77, 15);
            lbl_author.TabIndex = 21;
            lbl_author.Text = "Author name";
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.Location = new Point(219, 131);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(67, 15);
            lbl_description.TabIndex = 20;
            lbl_description.Text = "Description";
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(336, 123);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(216, 23);
            txt_desc.TabIndex = 19;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(219, 88);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(29, 15);
            lbl_title.TabIndex = 18;
            lbl_title.Text = "Title";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(336, 80);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(216, 23);
            txt_title.TabIndex = 17;
            // 
            // Employees
            // 
            Employees.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Employees.Location = new Point(304, 9);
            Employees.Name = "Employees";
            Employees.Size = new Size(243, 39);
            Employees.TabIndex = 16;
            Employees.Text = "News Managment";
            Employees.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NewsManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(cb_catalog);
            Controls.Add(lbl_catalog);
            Controls.Add(cb_author);
            Controls.Add(lbl_author);
            Controls.Add(lbl_description);
            Controls.Add(txt_desc);
            Controls.Add(lbl_title);
            Controls.Add(txt_title);
            Controls.Add(Employees);
            Name = "NewsManagment";
            Text = "NewsManagment";
            Load += NewsManagment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete;
        private Button btn_edit;
        private ComboBox cb_catalog;
        private Label lbl_catalog;
        private ComboBox cb_author;
        private Label lbl_author;
        private Label lbl_description;
        private TextBox txt_desc;
        private Label lbl_title;
        private TextBox txt_title;
        private Label Employees;
    }
}