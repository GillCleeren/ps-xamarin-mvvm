using BethanysPieShopStockApp.Models;
using System.Collections.Generic;

namespace BethanysPieShopStockApp.Services
{
    public class PieDataService
    {
        public PieDataService()
        {

        }

        public List<Pie> GetAllPies() 
        {
            return PieRepository.Pies;
        }

        public void AddPie(Pie pie)
        {
            PieRepository.AddPie(pie);
        }

        public void UpdatePie(Pie pie)
        {
            PieRepository.UpdatePie(pie);
        }
    }
}
