using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RefactorableApi.Models;

namespace RefactorableApi.Managers
{
    public interface ICheckoutManager
    {
        bool MakePayment(string basketId);

        double CalculateBasketValue(string basketId);
    }
}
