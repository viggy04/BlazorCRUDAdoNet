using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdoNet.Data
{
    public class CustomerService
    {
        public string Create(CustomerInfo objCustomer)
        {
            CustomerDataAccessLayer objCustomerDAL = new CustomerDataAccessLayer();
            objCustomerDAL.AddCustomer(objCustomer);
            return "Added Successfully";
        }
        public List<CustomerInfo> GetCustomer()
        {
            CustomerDataAccessLayer objCustomerDAL = new CustomerDataAccessLayer();
            List<CustomerInfo> customers = objCustomerDAL.GetAllCustomers().ToList();
            return customers;
        }
        public CustomerInfo GetCustomerByID(int id)
        {
            CustomerDataAccessLayer objCustomerDAL = new CustomerDataAccessLayer();

            CustomerInfo customer = objCustomerDAL.GetCustomerData(id);
            return customer;
        }
        public string UpdateCustomer(CustomerInfo objcustomer)
        {
            CustomerDataAccessLayer objCustomerDAL = new CustomerDataAccessLayer();

            objCustomerDAL.UpdateCustomer(objcustomer);
            return "Update Successfully";
        }
        public string DeleteCustomer(CustomerInfo objcustomer)
        {
            CustomerDataAccessLayer objCustomerDAL = new CustomerDataAccessLayer();

            objCustomerDAL.DeleteCustomer(objcustomer.CustId);
            return "Delete Successfully";
        }


    }
}
