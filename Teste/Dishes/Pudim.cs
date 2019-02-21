﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Pratos
{
    public class Pudim : IDessert
    {
        public DishOptions.SugarQuantity sugarQuantity
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
