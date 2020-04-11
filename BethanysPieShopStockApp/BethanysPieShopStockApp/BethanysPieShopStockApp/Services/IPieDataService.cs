using BethanysPieShopStockApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShopStockApp.Services
{
    public interface IPieDataService
    {
        List<Pie> GetAllPies();

        void AddPie(Pie pie);

        void UpdatePie(Pie pie);
       
    }
}
