﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;
namespace HelloWorld.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            Customer obj = 
                new Customer 
                    { 
                        CustomerCode = "1001", 
                        CustomerName = "Shiv" 
                    };

            return View("Customer",obj);
        }
        public ActionResult Enter()
        {
            return View("EnterCustomer");
        }
        public ActionResult Submit(Customer obj)
        {

            return View("Customer", obj);
        }
    }
}