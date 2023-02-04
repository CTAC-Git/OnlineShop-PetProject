using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductsRepository productsRepository;
        private readonly IWishListsRepository wishListsRepository;
        public ProductController(IProductsRepository productsRepository, IWishListsRepository wishListsRepository)
        {
            this.productsRepository = productsRepository;
            this.wishListsRepository = wishListsRepository;
        }

        [HttpGet("GetAll")]
        public async Task<List<Product>> Index()
        {
            var products = await productsRepository.GetAllAsync();
            await wishListsRepository.IsWishAsync(products, Constants.UserId);
            return products;
        }

        [HttpGet("TryGetById")]
        public async Task<Product> TryGetById(Guid id)
        {
            var product = await productsRepository.TryGetByIdAsync(id);
            return product;
        }

        [HttpGet("SearchProducts")]
        public async Task<List<Product>?> Search(string request)
        {
            if(request == null) { return null; }
            var products = await productsRepository.SearchAsync(request);
            if (products == null || products.Count == 0)
                return null;
            return products;
        }
    }
}
