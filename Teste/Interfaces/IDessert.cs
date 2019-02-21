using Restaurant.DishOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public interface IDessert : IDish
    {
        SugarQuantity sugarQuantity
        {
            get;
            set;
        }
    }
}
