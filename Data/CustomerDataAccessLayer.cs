using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace BlazorAdoNet.Data
{
    public class CustomerDataAccessLayer
    {
        string ConString = "Data Source=MSI-INDIA-IS000\\SQLEXPRESS;Initial Catalog=Blazor;Integrated Security=True";

        public IEnumerable<CustomerInfo> GetAllCustomers()
            // To view all Customers details
        {
            List<CustomerInfo> lstCustomer = new List<CustomerInfo>();
            using (SqlConnection con = new SqlConnection(ConString))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblCustomer;",con);
                //cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    CustomerInfo Customer = new CustomerInfo();
                    Customer.CustId = (int)rdr["CustId"];
                    Customer.Name = rdr["Name"].ToString();
                    Customer.City = rdr["City"].ToString();
                    Customer.Country = rdr["Country"].ToString();
                    Customer.Gender = rdr["Gender"].ToString();
                    lstCustomer.Add(Customer);
                }
                con.Close();
            }
            return lstCustomer;
        }

        //To Add Customer 
        public void AddCustomer(CustomerInfo Customer)
        {
            using(SqlConnection con = new SqlConnection(ConString))
            {
                SqlCommand cmd = new SqlCommand("spAddCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@City", Customer.City);
                cmd.Parameters.AddWithValue("@Country", Customer.Country);
                cmd.Parameters.AddWithValue("@Gender", Customer.Gender);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        //Tu Update Customer records
        public void UpdateCustomer(CustomerInfo Customer)
        {
            using(SqlConnection con = new SqlConnection(ConString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateCust",con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustId", Customer.CustId);
                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@City", Customer.City);
                cmd.Parameters.AddWithValue("@Country", Customer.Country);
                cmd.Parameters.AddWithValue("@Gender", Customer.Gender);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        //Get details of particular customer 
        public CustomerInfo GetCustomerData(int? id)
        {
            CustomerInfo Customer = new CustomerInfo();
            using(SqlConnection con = new SqlConnection(ConString))
            {
                SqlCommand cmd = new SqlCommand("spGetCustById", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustId", id);
                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Customer.CustId = Convert.ToInt32(rdr["CustId"]);
                    Customer.Name = rdr["Name"].ToString();
                    Customer.City = rdr["City"].ToString();
                    Customer.Country = rdr["Country"].ToString();
                    Customer.Gender = rdr["Gender"].ToString();
                    
                }
                con.Close(); // Pasted this here earlier it was after sqlread line

            }
            return Customer;
        }


        //To delete record of particular customer
        public void DeleteCustomer(int? id)
        {
            using(SqlConnection con = new SqlConnection(ConString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteCust", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



    }

}
 