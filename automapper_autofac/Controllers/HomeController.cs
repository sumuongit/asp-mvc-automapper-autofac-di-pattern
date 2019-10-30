using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using automapper_autofac.Models;
using automapper_autofac.Models.ViewModel;
using AutoMapper;

namespace automapper_autofac.Controllers
{
    public class HomeController : Controller
    {       
        private readonly IMapper _mapper;

        public HomeController()
        {
           
        }

        public HomeController(IMapper mapper)
        {            
            this._mapper = mapper;
        }
        
        public ActionResult Index()
        {
            var usr = new UserModel
            {
                AddressLine1 = "Uttara, Dhaka",
                AddressLine2 = "Bangladesh",
                FirstName = "Sumon",
                MiddleName = "",
                LastName = "Rahman",
                PinCode = ""
            };

            var usrVm = _mapper.Map<UserViewModel>(usr);
          
            return View(usrVm);
        }
    }
}