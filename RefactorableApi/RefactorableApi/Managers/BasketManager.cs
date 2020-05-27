using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RefactorableApi.DataAccess;
using RefactorableApi.Models;

namespace RefactorableApi.Managers
{
    public class BasketManager : BasketInterface
    {
        public DataAccessInterface bda;
        public BasketManager(DataAccessInterface newBda) { bda = newBda; }


        public BasketContents Get(string basketId)
        {
            try
            {
                return bda.Get(basketId);
            } catch (Exception e)
            {
                throw new Exception($"Caught a(n) {e.GetType()} trying to load a basket.");
            }
        }

        public BasketContents Delete(string basketId, string itemId)
        {
            bda.Delete(basketId, itemId);

            return Get(basketId);
        }
    }
}
