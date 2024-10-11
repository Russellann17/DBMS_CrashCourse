using System;
using System.Windows.Forms;

namespace DBMS_CrashCourse
{
    public partial class AddCustomer : UserControl
    {
        CustomerController customerController = new CustomerController();
        private Customer parentForm;

        public AddCustomer()
        {
            InitializeComponent();
        }
        public void InitializeParentForm(Customer parent)
        {
            parentForm = parent;
        }

        private void ClearFields()
        {
            txtCusName.Clear();
            txtCusAddress.Clear();
            txtCusNum.Clear();
            txtCusEmail.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ClearFields();
        }
        // Lesson 7: SQL Introduction
        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            string name = txtCusName.Text;
            string address = txtCusAddress.Text;
            string contactNumber = txtCusNum.Text;
            string email = txtCusEmail.Text;

            
            customerController.AddCustomer(name, address, contactNumber, email);
            MessageBox.Show("Customer added successfully!");

            parentForm.LoadCustomers();

            ClearFields();
            this.Visible = false;
        }
    }
}
