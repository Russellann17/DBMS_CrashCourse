using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBMS_CrashCourse
{
    public partial class Customer : UserControl
    {
        CustomerController customerController = new CustomerController();
        public Customer()
        {
            InitializeComponent();
            LoadCustomers();
            dgvCustomer.Enabled = false;
            btnSaveAdd.Enabled = false;
            btnSaveUpdate.Visible = false;
        }
        //Lesson 1 : Data and Information
        private void LoadCustomers()
        {
            DataTable customersTable = customerController.GetCustomers();
            dgvCustomer.DataSource = customersTable;

            dgvCustomer.Columns["CustomerID"].HeaderText = "ID";
            dgvCustomer.Columns["cusName"].HeaderText = "Customer Name";
            dgvCustomer.Columns["cusAddress"].HeaderText = "Address";
            dgvCustomer.Columns["cusContactNum"].HeaderText = "Contact Number";
            dgvCustomer.Columns["cusEmail"].HeaderText = "Email";
        }
        //Lesson 7 : SQL Introduction
        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            string name = txtCusName.Text;
            string address = txtCusAddress.Text;
            string contactNumber = txtCusNum.Text;
            string email = txtCusEmail.Text;

            customerController.AddCustomer(name, address, contactNumber, email);
            LoadCustomers();
        }
        //Lesson 7 : SQL Introduction
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(txtCustomerID.Text);
            string name = txtCusName.Text;
            string address = txtCusAddress.Text;
            string contactNumber = txtCusNum.Text;
            string email = txtCusEmail.Text;

            customerController.UpdateCustomer(customerId, name, address, contactNumber, email);
            LoadCustomers();
        }
        //Lesson 2 : Database Management System
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtCusName.Text = row.Cells["cusName"].Value.ToString();
                txtCusAddress.Text = row.Cells["cusAddress"].Value.ToString();
                txtCusNum.Text = row.Cells["cusContactNum"].Value.ToString();
                txtCusEmail.Text = row.Cells["cusEmail"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            txtCusName.Clear();
            txtCusAddress.Clear();
            txtCusNum.Clear();
            txtCusEmail.Clear();
        }
        private void btnActUpdate_Click(object sender, EventArgs e)
        {
            dgvCustomer.Enabled = true;
            btnSaveUpdate.Visible = true;
            btnSaveAdd.Visible = false;
            ClearFields();
        }
        private void btnActAdd_Click(object sender, EventArgs e)
        {
            dgvCustomer.Enabled = false;
            btnSaveUpdate.Visible = false;
            btnSaveAdd.Visible = true;
            ClearFields();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
