using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;
using SportsStore.ViewModels;


namespace SportsStore.Controllers
{
    public class HomeController:Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;

        public HomeController(IStoreRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index(int productPage=1) 
            => View( new ProductsListViewModel {
                Products = 
                repository.Products
                    .OrderBy(p=>p.ProductID )
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
    }
}