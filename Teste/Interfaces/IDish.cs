using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public interface IDish
    {
        int Id
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }

        Decimal Price
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        int estimatedTime { get; set; }
    }
}
