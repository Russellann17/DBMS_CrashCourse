using System;
using System.Windows.Forms;

namespace DBMS_CrashCourse
{
    public partial class UpdateCustomer : UserControl
    {
        CustomerController customerController = new CustomerController();
        private Customer parentForm;

        public UpdateCustomer()
        {
            InitializeComponent();
        }
        public void InitializeParentForm(Customer parent)
        {
            parentForm = parent;
        }

        public void SetCustomerData(string customerID, string customerName, string customerAddress, string customerContact, string customerEmail)
        {
            txtCustomerID.Text = customerID;
            txtCusName.Text = customerName;
            txtCusAddress.Text = customerAddress;
            txtCusNum.Text = customerContact;
            txtCusEmail.Text = customerEmail;
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
        }

        //Lesson 7 : SQL Introduction
        private void btnSave_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txtCustomerID.Text);
            string name = txtCusName.Text;
            string address = txtCusAddress.Text;
            string contactNumber = txtCusNum.Text;
            string email = txtCusEmail.Text;

            customerController.UpdateCustomer(customerId, name, address, contactNumber, email);

            MessageBox.Show("Customer updated successfully!");

            parentForm.LoadCustomers();
            this.Visible = false;
        }
    }
}
