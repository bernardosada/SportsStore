using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRespository repository;
        public ProductController(IProductRespository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Products);
    }
}