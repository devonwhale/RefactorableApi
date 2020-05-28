using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefactorableApi.Models
{
    /// <summary>
    /// Copied from the WirePay spec
    /// </summary>
    public class PaymentRequest
    {
        public string AccountReference { get; set; }

        /// <summary>
        /// WirePay want the value in pence
        /// </summary>
        public int Value { get; set; }
    }
}
