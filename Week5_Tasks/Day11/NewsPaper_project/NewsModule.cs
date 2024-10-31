using Newsproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newsproject
{
    public partial class NewsModule : Form
    {
        Form1 _form;
        NewsPaperContext NewsPaperDb;

        public NewsModule(Form1 form)
        {
            InitializeComponent();
            _form = form;
            NewsPaperDb = new NewsPaperContext();
        }

        private void NewsModule_Load(object sender, EventArgs e)
        {
            cb_author.DataSource = NewsPaperDb.authors.ToList();
            cb_author.DisplayMember = "Name";
            cb_author.ValueMember = "Id";

            cb_catalog.DataSource = NewsPaperDb.catalogs.ToList();
            cb_catalog.DisplayMember = "Name";
            cb_catalog.ValueMember = "Id";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            News news = new News()
            {
                Title = txt_title.Text,
                Description = txt_desc.Text,
                Author_id = (int)cb_author.SelectedValue,
                Catalog_id = (int)cb_catalog.SelectedValue,
            };
            NewsPaperDb.news.Add(news);
            NewsPaperDb.SaveChanges();
            MessageBox.Show("Add Successfully");
            Clear();
            _form.LoadNews();
        }
        public void Clear()
        {
            txt_title.Clear();
            txt_desc.Clear();

            cb_author.SelectedIndex = 0;
            cb_catalog.SelectedIndex = 0;


            txt_title.Enabled = true;
            txt_title.Focus();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
