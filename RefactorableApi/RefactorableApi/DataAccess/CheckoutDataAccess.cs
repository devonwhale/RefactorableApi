using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefactorableApi.DataAccess
{
    public class CheckoutDataAccess : DataAccessInterface
    {
        /// <summary>
        /// Saves that a transaction has happened
        /// </summary>
        /// <param name="id">Seems to be required</param>
        /// <param name="newItem">The transaction id we want to keep a record of.</param>
        /// <returns>Nothing</returns>
        public dynamic Add(string id, dynamic newItem)
        {
            SpoofPaymentSave(newItem);

            return null;
        }

        /// <summary>
        /// Shouldn't ever be called
        /// </summary>
        /// <param name="id">Shouldn't ever be used</param>
        /// <param name="id2">Shouldn't ever be used</param>
        public void Delete(string id, string id2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the VAT rate for a provided item ID
        /// </summary>
        /// <param name="id">The item ID</param>
        /// <returns>Something</returns>
        public dynamic Get(string id)
        {
            var rate = SpoofVatLookup(id);
            if (rate > 1 && rate < 100) rate = rate / 100;
            return rate;
        }

        private double SpoofVatLookup(string id) //Yes I know id isn't used but it looks more realistic...
        {
            return 20;
        }

        private void SpoofPaymentSave(string transactionId)
        {
            // Record of payment saved!
        }
    }
}
