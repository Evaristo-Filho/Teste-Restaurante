using Restaurant.Pratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public static class Menu
    {
        public static List<IDish> items = new List<IDish>();

        static Menu()
        {
            items.Add(new Pudim() { Id = 1, Name = "Pudim", Price = 10.00M, estimatedTime = 5, Description = "Pudim de leite" });
            items.Add(new Salada() { Id = 2, Name = "Salada", Price = 12.00M, estimatedTime = 10, Description = "Salada Cesar" });
            items.Add(new Arroz() { Id = 3, Name = "Arroz", Price = 20.00M, estimatedTime = 15, Description = "Arroz" });
        }
    }
}
