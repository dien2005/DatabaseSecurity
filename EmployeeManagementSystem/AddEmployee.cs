using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace EmployeeManagementSystem
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect =
           new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\milen\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public AddEmployee()
        {
            InitializeComponent();

            //TO DISPLAY THE DATA FROM DATABASE TO YOU DATA GRID VIEW
            //displayEmployeeData();
        }
        public void displayEmployeeData()
        {

        }

        public void RefreshData()
        {
 
        }
        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_importBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void clearFields()
        {

        }
        private void addEmployee_updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_deleteBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
