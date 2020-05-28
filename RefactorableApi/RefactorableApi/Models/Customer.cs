using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefactorableApi.Models
{
    public class Customer
    {
        public string Name { get; set; }

        public string Address { set; get; }

        public string HashedPassword { get; set; }

        public string PaymentDetailsReference { set; get; }
    }
}
