using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RefactorableApi.DataAccess;
using RefactorableApi.Models;

namespace RefactorableApi.Managers
{
    public class CheckoutManager : ICheckoutManager
    {
        protected DataAccessInterface cdb;
        protected BasketInterface ba;

        public CheckoutManager(BasketInterface newBasketInterface)
        {
            cdb = new CheckoutDataAccess();
            ba = newBasketInterface;
        }

        public bool MakePayment(string basketId)
        {
            var basket = ba.Get(basketId);

            var cost = CalculateBasketValue(basket);

            return true;
        }

        public double CalculateBasketValue(BasketContents basket)
        {
            return 17.5;
        }
    }
}
