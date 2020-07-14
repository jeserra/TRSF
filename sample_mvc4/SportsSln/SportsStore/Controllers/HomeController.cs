using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;

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

        public IActionResult Index(int productsPage= 1) 
            => View(repository.Products
                    .OrderBy(p=>p.ProductID )
                    .Skip((productsPage-1) * PageSize)
                    .Take(PageSize));

            
    }
}