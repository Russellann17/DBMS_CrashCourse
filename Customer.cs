using System;
using System.Data;
using System.Windows.Forms;

namespace DBMS_CrashCourse
{
    public partial class Customer : UserControl
    {
        CustomerController customerController = new CustomerController();
       
        public Customer()
        {
            InitializeComponent();
            LoadCustomers();

            dgvCustomer.CellClick += dgvCustomer_CellClick;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            updateCustomer1.Visible = false;
            updateCustomer1.InitializeParentForm(this);

            addCustomer1.Visible = false;
            addCustomer1.InitializeParentForm(this);
        }

        // Lesson 1: Data and Information
        public void LoadCustomers()
        {
            DataTable customersTable = customerController.GetCustomers();
            dgvCustomer.DataSource = customersTable;

            dgvCustomer.Columns["CustomerID"].HeaderText = "ID";
            dgvCustomer.Columns["cusName"].HeaderText = "Customer Name";
            dgvCustomer.Columns["cusAddress"].HeaderText = "Address";
            dgvCustomer.Columns["cusContactNum"].HeaderText = "Contact Number";
            dgvCustomer.Columns["cusEmail"].HeaderText = "Email";
        }

        // Lesson 2 : Database Management System
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];

                string customerID = row.Cells[0].Value.ToString();
                string customerName = row.Cells[1].Value.ToString();
                string customerAddress = row.Cells[2].Value.ToString();
                string customerContact = row.Cells[3].Value.ToString();
                string customerEmail = row.Cells[4].Value.ToString();

                updateCustomer1.SetCustomerData(customerID, customerName, customerAddress, customerContact, customerEmail);

                updateCustomer1.Visible = true;
            }
        }
        private void btnActAdd_Click(object sender, EventArgs e)
        {
            updateCustomer1.Visible = false;
            addCustomer1.Visible = true;
        }

        //Lesson 4 : User Interface Design
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            DataTable filteredCustomers = customerController.SearchCustomers(searchTerm);

            dgvCustomer.DataSource = filteredCustomers;
        }

    }
}
