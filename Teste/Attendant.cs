using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Restaurant.DishOptions;

namespace Restaurant
{
    public class Attendant
    {
        private List<IDish> order = new List<IDish>();

        public void placeStart(IStarter dish, SaltQuantity salt)
        {
            dish.saltQuantity = salt;
            placeDish(dish);
        }
        public void placeMain(IMainCourse dish, Spice spice)
        {
            dish.spice = spice;
            placeDish(dish);
        }
        public void placeDesert(IDessert dish, SugarQuantity sugar)
        {
            dish.sugarQuantity = sugar;
            placeDish(dish);
        }

        private void placeDish(IDish dish)
        {
            order.Add(dish);
        }

        public TimeSpan PlaceOrder()
        {
            return Kitchen.placeOrder(order);
        }

        public TimeSpan placeOrder(List<IDish> dishes)
        {
            return Kitchen.placeOrder(dishes);
        }
    }
}
