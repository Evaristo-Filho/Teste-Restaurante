using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Pratos
{
    public class Salada : IStarter
    {
        public DishOptions.SaltQuantity saltQuantity
        {
            get;
            set;
        }

        public string Name
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


        public decimal Price
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }
    }
}
