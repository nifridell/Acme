using Acme.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acme.Models
{
    public class CustomersService
    {
        private readonly AcmeContext context;
 
        public CustomersService(AcmeContext context)
        {
            this.context = context;
        }

        public Customer[] GetAll()
        {
            return context.Customer.ToArray();
        }

        internal void Add(Customer customer)
        {
            context.Customer.Add(customer);
            context.SaveChanges();
        }
    }
}
