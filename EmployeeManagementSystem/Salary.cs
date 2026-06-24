using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Salary : UserControl
    {
        SqlConnection connect =
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\milen\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public Salary()
        {
            //InitializeComponent();
            //displayEmployee();
            //disableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                //Invoke((MethodInvoker)RefreshData);
                return;
            }


        }
        public void disableFields()
        {

        }
        public void displayEmployee()
        {
            
        }
        private void salary_updateBtn_Click(object sender, EventArgs e)
        {
            
        }

        public void clearFields()
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void salary_clearBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
