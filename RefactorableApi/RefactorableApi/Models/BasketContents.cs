using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefactorableApi.Models
{
    public class BasketContents : List<Item>
    {
        public BasketContents(IEnumerable<Item> items, string id) : base(items)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
