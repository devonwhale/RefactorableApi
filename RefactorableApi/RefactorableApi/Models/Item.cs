using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefactorableApi.Models
{
    public class Item
    {
        public string ID { get; set; }

        public string Name { get; set;  }

        public double Price { get; set; }

        public bool Vat { set; get; }

        public void SetVat(bool vat) 
        {
            Vat = vat;
        }

        public bool GetVat()
        {
            return Vat;
        }
    }
}
