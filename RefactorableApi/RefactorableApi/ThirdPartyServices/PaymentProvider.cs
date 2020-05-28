using System;
using System.Threading;
using System.Threading.Tasks;
using RefactorableApi.DataAccess;
using RefactorableApi.Models;

namespace RefactorableApi.ThirdPartyServices
{
    public class PaymentProvider
    {
        private CustomerDataAccess cda;

        public PaymentProvider()
        {
            cda = new CustomerDataAccess();
        }

        public string TakePayment(string basketId, double cost)
        {
            PaymentRequest PaymentRequest = new PaymentRequest();
            PaymentRequest.AccountReference = cda.Get(basketId).PaymentDetailsReference;
            PaymentRequest.Value = (int)Math.Truncate(cost*100);

            return SpoofTakePayment(PaymentRequest).Result.ToString();
        }

        private async Task<Guid> SpoofTakePayment(PaymentRequest request)
        {
            await Task.Run(() => Thread.Sleep(1000));
            return Guid.NewGuid();
        }
    }
}
