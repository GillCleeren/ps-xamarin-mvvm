using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShopStockApp.Tests.Mocks
{
    public class MockPieDataService : IPieDataService
    {
        private List<Pie> mockPies = new List<Pie>()
        {
            new Pie { PieName = "Apple Pie", Price = 12.95, Description = "Our famous apple pies!", InStock = true },
            new Pie { PieName = "Blueberry Cheese Cake", Price = 18.95, Description = "You'll love it!", InStock = false },
            new Pie { PieName = "Cheese Cake", Price = 18.95, Description = "Plain cheese cake. Plain pleasure.", InStock = true},
            new Pie { PieName = "Cherry Pie", Price = 15.95, Description = "A summer classic!", InStock = false },
            new Pie { PieName = "Christmas Apple Pie", Price = 13.95, Description = "Happy holidays with this pie!" , InStock = true},
            new Pie { PieName = "Cranberry Pie", Price = 17.95, Description = "A Christmas favorite", InStock = true  },
            new Pie { PieName = "Peach Pie", Price = 15.95, Description = "Sweet as peach", InStock = true },
            new Pie { PieName = "Pumpkin Pie", Price = 12.95, Description = "Our Halloween favorite", InStock = false},
            new Pie { PieName = "Rhubarb Pie", Price = 15.95, Description = "My God, so sweet!", InStock = false},
            new Pie { PieName = "Strawberry Pie", Price = 15.95, Description = "Our delicious strawberry pie!",InStock = true },
         };

        public List<Pie> GetAllPies()
        {
            return mockPies;
        }

        public void AddPie(Pie pie)
        {
            pie.Id = Guid.NewGuid();

            mockPies.Add(pie);
        }

        public void UpdatePie(Pie pie)
        {
            var oldPie = mockPies.Where(p => p.Id == pie.Id).FirstOrDefault();
            oldPie.PieName = pie.PieName;
            oldPie.Price = pie.Price;
            oldPie.Description = pie.Description;
            oldPie.InStock = pie.InStock;
        }
    }
}
