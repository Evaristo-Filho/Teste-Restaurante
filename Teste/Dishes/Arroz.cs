using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Pratos
{
    class Arroz : IMainCourse
    {
        public DishOptions.Spice spice
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