using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RefactorableApi.DataAccess;
using RefactorableApi.Models;
using RefactorableApi.ThirdPartyServices;

namespace RefactorableApi.Managers
{
    public class CheckoutManager : ICheckoutManager
    {
        protected DataAccessInterface cdb;
        protected BasketInterface ba;
        protected PaymentProvider pProv;

        public CheckoutManager(BasketInterface newBasketInterface)
        {
            cdb = new CheckoutDataAccess();
            ba = newBasketInterface;
            pProv = new PaymentProvider();
        }

        public bool MakePayment(string basketId)
        {
            var basket = ba.Get(basketId);

            var cost = CalculateBasketValue(basketId);

            pProv.TakePayment(basketId, cost);

            return true;
        }

        public double CalculateBasketValue(string basketId)
        {
            var value = new double();

            var basket = ba.Get(basketId);

            foreach (Item itemInBasket in basket)
            {
                    if (!itemInBasket.GetVat()) //Item is not exempt from VAT. Don't forget to add it!
                    {
                        var vatRate = cdb.Get(itemInBasket.ID);
                        value = value + (itemInBasket.Price * (1+vatRate));
                        continue;
                    }
                    value = value + itemInBasket.Price;
            }

            return value;
        }
    }
}
