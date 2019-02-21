using Restaurant;
using Restaurant.DishOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class DishVm : IStarter, IMainCourse, IDessert
    {
        public Spice spice
        {
            get;
            set;

        }

        public SugarQuantity sugarQuantity
        {
            get;
            set;
        }

        public SaltQuantity saltQuantity
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public int estimatedTime
        {
            get;
            set;
        }

    }
}