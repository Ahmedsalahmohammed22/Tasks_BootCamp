using EF_WF.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_WF
{
    public partial class Form1 : Form
    {
        CompanyContext companyDb;
        public Form1()
        {
            InitializeComponent();
            companyDb = new CompanyContext();
            LoadEmployee();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var employees = companyDb.Employees.Include(d => d.dept).Select(s => new { s.Id, s.Name, s.Salary, s.Hiredate, departmentName = s.dept.Dept_Name }).ToList();
            DGV_Employee.DataSource = employees;
        }
        public void LoadEmployee()
        {
            var employees = companyDb.Employees.Include(d => d.dept).Select(s => new { s.Id, s.Name, s.Salary, s.Hiredate, departmentName = s.dept.Dept_Name }).ToList();
            DGV_Employee.DataSource = employees;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            EmployeeModule employeeModule = new EmployeeModule(this);
            employeeModule.ShowDialog();
        }

        private void DGV_Employee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)DGV_Employee.SelectedRows[0].Cells["Id"].Value;
            var emp = companyDb.Employees.Where(e =>  e.Id == id).Include(d => d.dept).SingleOrDefault();
            EmployeeManagementForm employee = new EmployeeManagementForm(emp , this);
            employee.ShowDialog();
            
        }
    }
}
