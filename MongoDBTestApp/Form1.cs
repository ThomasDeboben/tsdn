namespace MongoDBTestApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using Employee.Data.Entities;
    using Employee.Data.Services;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReadData_Click(object sender, EventArgs evtArgs)
        {
        }

        private void buttonCreateEmployee_Click(object sender, EventArgs e)
        {
            var employee = new Employee();
            employee.Name = "thomas";

            var employeeService = new EmployeeService();
            employeeService.Create(employee);
        }
    }
}
