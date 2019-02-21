using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public static class Kitchen
    {
        private static List<IDish> queue = new List<IDish>();
        private static TimeSpan kitchenTimer = new TimeSpan();

        public static TimeSpan placeOrder(List<IDish> order)
        {
            int estimatedTime = 0;
            foreach (var dish in order)
            {
                queue.Add(dish);
                estimatedTime += dish.estimatedTime;
            }
           kitchenTimer= kitchenTimer.Add(new TimeSpan(0,estimatedTime,0));
            return kitchenTimer;
        }

    }
}
