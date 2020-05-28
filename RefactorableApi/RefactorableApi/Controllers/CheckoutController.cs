using System;
using Microsoft.AspNetCore.Mvc;
using RefactorableApi.DataAccess;
using RefactorableApi.Exceptions;
using RefactorableApi.Managers;
using RefactorableApi.Models;

namespace RefactorableApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        public ICheckoutManager coManager;

        public CheckoutController(ICheckoutManager icm)
        {
            coManager = icm;
        }

        [HttpPut("{id}")]
        public IActionResult MakePayment(string id)
        {
            try
            {
                return Ok(coManager.MakePayment(id));
            }
            catch (Exception)
            {
                return new StatusCodeResult(400);
            }
            return new StatusCodeResult(500);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            // We don't want people to be able to do this.
            return Ok();
        }
    }
}
