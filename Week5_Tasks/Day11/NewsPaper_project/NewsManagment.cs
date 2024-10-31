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
    public partial class NewsManagment : Form
    {
        News _news;
        Form1 _form;
        NewsPaperContext NewsPaperDb;
        public NewsManagment(News news, Form1 form)
        {
            InitializeComponent();
            NewsPaperDb = new NewsPaperContext();
            _form = form;
            _news = news;
        }

        private void NewsManagment_Load(object sender, EventArgs e)
        {
            cb_author.DataSource = NewsPaperDb.authors.ToList();
            cb_author.DisplayMember = "Name";
            cb_author.ValueMember = "Id";

            cb_catalog.DataSource = NewsPaperDb.catalogs.ToList();
            cb_catalog.DisplayMember = "Name";
            cb_catalog.ValueMember = "Id";

            txt_title.Text = _news.Title;
            txt_desc.Text = _news.Description;
            cb_author.SelectedValue = _news.Author_id;
            cb_catalog.SelectedValue = _news.Catalog_id;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var news = NewsPaperDb.news.Where(n => n.Id == _news.Id).SingleOrDefault();
            if (news != null)
            {
                news.Title = txt_title.Text;
                news.Description = txt_desc.Text;
                news.Author_id = (int)cb_author.SelectedValue;
                news.Catalog_id = (int)cb_catalog.SelectedValue;

                NewsPaperDb.SaveChanges();
                MessageBox.Show("Edit Successfully");
                this.Dispose();
                _form.LoadNews();


            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var news = NewsPaperDb.news.Where(n => n.Id == _news.Id).SingleOrDefault();
            NewsPaperDb.news.Remove(news);
            NewsPaperDb.SaveChanges();
            MessageBox.Show("Delete Successfully");
            this.Dispose();
            _form.LoadNews();
        }
    }
}
