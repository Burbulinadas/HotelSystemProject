using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemProgramShell
{
    class Customer
    {
        public System.Int32 CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerMiddleName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public System.Boolean VIP { get; set; }
        public System.Boolean Gender { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public System.Boolean CustomerIDType { get; set; }
        public string CustomerIDNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PreferedLang { get; set; }
        public System.DateTime DateInSystem { get; set; }
    }
}
