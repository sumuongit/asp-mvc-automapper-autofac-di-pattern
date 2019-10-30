using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace automapper_autofac.Models.ViewModel
{
    public class UserViewModel
    {
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Display(Name = "User Address")]
        public string UserAddress { get; set; }
    }
}