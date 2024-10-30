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
    public partial class EmployeeManagementForm : Form
    {
        Employee _employee;
        Form1 _form;
        CompanyContext companyDb;

        public EmployeeManagementForm(Employee employee, Form1 form)
        {
            InitializeComponent();
            companyDb = new CompanyContext();
            _employee = employee;
            _form = form;

        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            cb_department.DataSource = companyDb.Departments.ToList();
            cb_department.DisplayMember = "Dept_Name";
            cb_department.ValueMember = "ID";

            txt_name.Text = _employee.Name;
            txt_salary.Text = _employee.Salary.ToString();
            txt_HireDate.Text = _employee.Hiredate.ToString();
            //MessageBox.Show(cb_gender.Items.Contains("M").ToString());
            cb_gender.SelectedIndex = cb_gender.Items.IndexOf(_employee.Gender.Trim().ToUpper());
            //cb_gender.SelectedItem = _employee.Gender;
            cb_department.SelectedValue = _employee.dept_id;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var emp = companyDb.Employees.Where(e => e.Id == _employee.Id).SingleOrDefault();
            emp.Name = txt_name.Text;
            emp.Salary = decimal.Parse(txt_salary.Text);
            emp.Hiredate = DateOnly.Parse(txt_HireDate.Text);
            emp.Gender = cb_gender.Text;
            emp.dept_id = (int)cb_department.SelectedValue;

            companyDb.SaveChanges();
            MessageBox.Show("Edit Successfully");
            this.Dispose();
            _form.LoadEmployee();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var emp = companyDb.Employees.Where(e => e.Id == _employee.Id).SingleOrDefault();
            companyDb.Employees.Remove(emp);
            companyDb.SaveChanges();
            MessageBox.Show("Delete Successfully");
            this.Dispose();
            _form.LoadEmployee();

        }
    }
}
