﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RefactorableApi.DataAccess;
using RefactorableApi.Exceptions;
using RefactorableApi.Managers;
using RefactorableApi.Models;

namespace RefactorableApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        public BasketInterface basketManager;
        public DataAccessInterface basketDataAccess;

        public BasketController(BasketInterface bi, DataAccessInterface bda)
        {
            basketManager = bi;
            basketDataAccess = bda;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                return Ok(basketManager.Get(id));
            }
            catch (Exception)
            {
                return new StatusCodeResult(400);
            }
            return new StatusCodeResult(500);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(string id, [FromBody] Item newItem)
        {
            return Ok(basketDataAccess.Add(id, newItem));
        }

        [HttpDelete("{id}/{id2}")]
        public IActionResult Delete(string id, string id2)
        {
            try
            {
                basketManager.Delete(id, id2);
            }
            catch (ItemNotInBasketException inibe)
            {
                return BadRequest("That item is not in the Basket");
            }
            return Ok();
        }
    }
}
