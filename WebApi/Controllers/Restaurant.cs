using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Restaurant.Pratos;
using Restaurant.DishOptions;
using Restaurant;
using WebApi.Models;


namespace WebApi.Controllers
{
    public class RestaurantController : ApiController
    {

        [HttpGet]
        public string teste()
        {
            return "Teste";
        }

        [HttpGet]
        public List<IDish> Menu()
        {
            return Restaurant.Menu.items;
        }


        public void createOrder([FromBody]DishVm[] dishes)
        {
            var dishList = dishes.ToList<IDish>();
            var attendant = new Attendant();
            var estimatedTime = attendant.placeOrder(dishList);
        }
    }
}