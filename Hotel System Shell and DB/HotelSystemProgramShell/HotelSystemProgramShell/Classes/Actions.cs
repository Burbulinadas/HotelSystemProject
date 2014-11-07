using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemProgramShell.Classes
{
    class Actions
    {
        public static void AddCustomer(Customer customer)
        {
            Customers cust = new Customers();
            cust.CustomerNo = customer.CustomerNo;
            cust.CustomerName = customer.CustomerName;
            cust.CustomerSurname = customer.CustomerSurname;
            cust.CustomerMiddleName = customer.CustomerMiddleName;
            cust.DateOfBirth = customer.DateOfBirth;
            cust.VIP = customer.VIP;
            cust.Gender = customer.Gender;
            cust.Address1 = customer.Address1;
            cust.Address2 = customer.Address2;
            cust.City = customer.City;
            cust.Region = customer.Region;
            cust.Country = customer.Country;
            cust.PostalCode = customer.PostalCode;
            cust.CustomerIDType = customer.CustomerIDType;
            cust.CustomerIDNo = customer.CustomerIDNumber;
            cust.Phone = customer.Phone;
            cust.Email = customer.Email;
            cust.PreferedLang = customer.PreferedLang;
            cust.DateInSystem = DateTime.Now;
            CommonData.Context.Customers.Add(cust);
            CommonData.Context.SaveChanges();
        }
    }
}
