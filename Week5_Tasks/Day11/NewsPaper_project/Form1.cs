using Newsproject.Models;

namespace Newsproject
{
    public partial class Form1 : Form
    {
        NewsPaperContext NewsPaperDb;
        public Form1()
        {
            InitializeComponent();
            NewsPaperDb = new NewsPaperContext();
        }
        public void LoadNews()
        {
            var news = NewsPaperDb.news.Select(n => new { n.Id, n.Title, n.Description, authorName = n.Author.Name, catalogName = n.Catalog.Name }).ToList();
            DGV_News.DataSource = news;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var news = NewsPaperDb.news.Select(n => new { n.Id, n.Title, n.Description, authorName = n.Author.Name, catalogName = n.Catalog.Name }).ToList();
            DGV_News.DataSource = news;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            NewsModule newsModule = new NewsModule(this);
            newsModule.ShowDialog();
            //EmployeeModule employeeModule = new EmployeeModule(this);
            //employeeModule.ShowDialog();
        }

        private void DGV_News_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)DGV_News.SelectedRows[0].Cells["Id"].Value;
            var emp = NewsPaperDb.news.Where(n => n.Id == id).SingleOrDefault();
            NewsManagment newsManagment = new NewsManagment(emp, this);
            newsManagment.ShowDialog();
        }
    }
}
