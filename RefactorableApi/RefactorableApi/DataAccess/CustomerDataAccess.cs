using System;
using RefactorableApi.Models;

namespace RefactorableApi.DataAccess
{
    public class CustomerDataAccess : DataAccessInterface
    {
        public dynamic Add(string id, dynamic newItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public dynamic Get(string id)
        {
            return SpoofLoadCustomer(id);
        }

        private Customer SpoofLoadCustomer(string basketId)
        {
            return new Customer
            {
                Name = "Bob Smith",
                Address = "123 Fake Street",
                HashedPassword = "U3VwM3JTM2N1cjNQYXNzd29yZA==",
                PaymentDetailsReference = Guid.NewGuid().ToString()
            };
        }
    }
}
