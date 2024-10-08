using System;
using System.Data;
using System.Data.SqlClient;

namespace DBMS_CrashCourse
{
    class CustomerController
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kentu\\source\\repos\\DBMS_CrashCourse\\DBMS_CrashCourse.mdf;Integrated Security=True;Connect Timeout=30";
        
        //Lesson 7 : SQL Introduction - Using SQL INSERT Statement to add data to the database
        public void AddCustomer(string name, string address, string contactNumber, string email)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Customer (cusName, cusAddress, cusContactNum, cusEmail) VALUES (@Name, @Address, @ContactNumber, @Email)";
                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue ("@Email", email);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Lesson 7 : SQL Introduction - Using SQL Update Statement to update existing data
        public void UpdateCustomer(int customerId, string name, string address, string contactNumber, string email)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Customer SET cusName = @Name, cusAddress = @Address, cusContactNum = @ContactNumber, cusEmail = @Email WHERE CustomerID = @CustomerID";
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@Email", email);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Lesson 5 : Relational Data Models 
        public DataTable GetCustomers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customer";
                using( SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable customerTable = new DataTable();
                        adapter.Fill(customerTable);
                        return customerTable;
                    }
                }
            }
        }
    }
}
