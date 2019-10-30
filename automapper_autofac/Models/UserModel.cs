using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace automapper_autofac.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string PinCode { get; set; }
    }
}