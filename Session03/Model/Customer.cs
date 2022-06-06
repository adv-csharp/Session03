using Session03.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Model
{
    public class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public DateTime DOB { get; set; }
        public string DOBJalali { get => DOB.ToJalali();  }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

    }
}
