using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using RefactorableApi.Exceptions;
using RefactorableApi.Models;

namespace RefactorableApi.DataAccess
{
    public class BasketDataAccess : DataAccessInterface
    {
        private static List<Item> _spoofBasket;

        public BasketDataAccess()
        {
            SpoofSetup();
        }

        public dynamic Get(string id)
        {
            var bask = SpoofGetItems(id);

            if(bask.Id != id)
            {
                throw new InvalidOperationException("Loaded a basket with the wrong id.");
            }
            else
            {
                return bask;
            }
        }

        public dynamic Add(string id, dynamic newItem)
        {
            SpoofAddItem(id, newItem);
            return Get(id);
        }

        public void Delete(string id, string id2)
        {
            SpoofRemoveItem(id, id2);
        } 

        private void SpoofSetup()
        {
            _spoofBasket = new List<Item> {
                new Item { ID = "1234", Name = "Screwdriver", Price = 7.95d},
                new Item { ID = "8", Name = "Compost", Price = 9.99d},
                new Item { ID = "43", Name = "The Telagraph and Argus", Price = 0.85d},
                new Item { ID = "778", Name = "Freddo (Multipack)", Price = 17.5d}
            };
        }

        private BasketContents SpoofGetItems(string id)
        {
            SpoofErrors(id);
            return new BasketContents(_spoofBasket, id);
        }

        private BasketContents SpoofAddItem(string id, Item item)
        {
            SpoofErrors(id);
            _spoofBasket.Add(item);
            return new BasketContents(_spoofBasket, id);
        }

        private BasketContents SpoofRemoveItem(string basketId, string idToRemove)
        {
            SpoofErrors(basketId);
            SpoofItemErrors(idToRemove);
            _spoofBasket.RemoveAll(x => x.ID == idToRemove);
            return new BasketContents(_spoofBasket, basketId);
        }

        private void SpoofErrors(string id)
        {
            if (id == "DBDead" || id == "1122") throw new DatabaseConnectionException("Error achieving connection to Database");
            if (id == "NFound" || id == "2211") throw new DataNotFoundException("The selected basket does not exist");
        }

        private void SpoofItemErrors(string itemId)
        {
            if (itemId == "ItemNotInBasket" || itemId == "1221") throw new ItemNotInBasketException("The item you are searching for is not in the basket");
        }
    }
}
