using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.Tests.Mocks;
using BethanysPieShopStockApp.ViewModels;
using Moq;
using System;
using Xunit;

namespace BethanysPieShopStockApp.Tests
{
    public class PieOverviewViewTests
    {
        [Fact]
        public void Pies_Not_Null_After_Construction()
        {
            var mockNavigationService = new Mock<INavigationService>();
            var mockPieDataService = new MockPieDataService();

            var pieOverviewViewModel = new PieOverviewViewModel(mockPieDataService, mockNavigationService.Object);
            Assert.NotNull(pieOverviewViewModel.Pies);
        }

        [Fact]
        public void Pies_Loaded_After_Load_Command()
        {
            var mockNavigationService = new Mock<INavigationService>();
            var mockPieDataService = new MockPieDataService();

            var pieOverviewViewModel = new PieOverviewViewModel(mockPieDataService, mockNavigationService.Object);
            pieOverviewViewModel.OnLoadCommand();
            var pies = pieOverviewViewModel.Pies;

            Assert.NotNull(pieOverviewViewModel.Pies);
            Assert.Equal(10, pieOverviewViewModel.Pies.Count);
        }
    }
}
