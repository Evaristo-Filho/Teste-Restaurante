using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Restaurant.DishOptions;

namespace Restaurant
{
    public interface IStarter:IDish
    {

        SaltQuantity saltQuantity
        {
            get;
            set;
        }
    }
}
