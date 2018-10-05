using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.Models;
using Acme.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Acme.Controllers
{
    public class CustomerController : Controller
    {
        CustomersService service;

        public CustomerController(CustomersService service)
        {
            this.service = service;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(service.GetAll());
        }

        [Route("create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create(Customer customer)
        { 
            if (!ModelState.IsValid)
                return View(customer);

            service.Add(customer);

            return RedirectToAction(nameof(Index));
        }
    }
}