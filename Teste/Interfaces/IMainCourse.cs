using Restaurant.DishOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public interface IMainCourse : IDish
    {
        Spice spice
        {
            get;
            set;
        }
    }
}
