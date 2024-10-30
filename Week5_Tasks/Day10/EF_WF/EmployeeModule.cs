using EF_WF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_WF
{
    public partial class EmployeeModule : Form
    {
        Form1 _form;
        CompanyContext companyDb;

        public EmployeeModule(Form1 form)
        {
            InitializeComponent();
            companyDb = new CompanyContext();
            _form = form;
        }
        private void EmployeeModule_Load(object sender, EventArgs e)
        {
            cb_department.DataSource = companyDb.Departments.ToList();
            cb_department.DisplayMember = "Dept_Name";
            cb_department.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Name = txt_name.Text,
                Salary = int.Parse(txt_salary.Text),
                Hiredate = DateOnly.Parse(txt_HireDate.Text),
                Gender = cb_gender.SelectedItem.ToString(),
                dept_id = (int)cb_department.SelectedValue

            };
            companyDb.Employees.Add(employee);
            companyDb.SaveChanges();
            MessageBox.Show("Add Successfully");
            Clear();
            _form.LoadEmployee();

        }
        public void Clear()
        {
            txt_name.Clear();
            txt_salary.Clear();
            txt_HireDate.Clear();
            cb_gender.SelectedItem = 0;
            cb_department.SelectedIndex = 0;

            txt_name.Enabled = true;
            txt_name.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
