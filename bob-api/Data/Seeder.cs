﻿using bob_api.Models;

namespace bob_api.Data
{
    public class Seeder
    {
        private List<Product> _products = [];
        private List<Category> _categories = [];
        private List<Order> _orders = [];
        private List<ProductsOrder> _productsOrders = [];
        private List<ProductCategory> _productCategory = [];
        private List<Rating> _ratings = [];
        private List<User> _users = [];
        private List<Wishlist> _wishlists = [];

        public Seeder()
        {

            //Category
            Category Boy = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "Boy",
            };
            Category Girl = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "Girl"
            };
            Category BTS = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "BTS",
            };
            Category StrayKids = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "StrayKids",
            };
            Category BigBang = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "BigBang",
            };
            Category Ateez = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "Ateez",
            };
            Category Blackpink = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "Blackpink",
            };
            Category RedVelvet = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "Red Velvet",
            };
            Category LE_SSERAFIM = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "LE SSERAFIM.",
            };
            Category GIDLE = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "(G)I-DLE.",
            };

            Category LightStickProducts = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "LightStick"
            };
            Category JewelryProducts = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "Jewelry"
            };
            Category MerchProducts = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "Merch",
            };

            _categories.Add(Girl);
            _categories.Add(Boy);
            _categories.Add(BTS);
            _categories.Add(StrayKids);
            _categories.Add(BigBang);
            _categories.Add(Ateez);
            _categories.Add(Blackpink);
            _categories.Add(RedVelvet);
            _categories.Add(LE_SSERAFIM);
            _categories.Add(GIDLE);
            _categories.Add(LightStickProducts);
            _categories.Add(JewelryProducts);
            _categories.Add(MerchProducts);

            //Products

            Product product1 = new Product()
            {
                Id = Guid.NewGuid(),
                Title = "TestBoy",
                Price = 10,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Image = "",
                Stock = 10,

            };
            //product1.Categories.Add(LightStickProducts);
            //product1.Categories.Add(Boy);
            //product1.Categories.Add(BTS);

            Product product2 = new Product()
            {
                Id = Guid.NewGuid(),
                Price = 15,
                Title = "Test2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Image = "",
                Stock = 10,
            };
            //product1.Categories.Add(LightStickProducts);
            //product1.Categories.Add(Girl);
            //product1.Categories.Add(RedVelvet);

            Product product3 = new Product()
            {
                Id = Guid.NewGuid(),
                Price = 11,
                Title = "Test3",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Image = "",
                Stock = 10,
            };
            //product1.Categories.Add(LightStickProducts);
            //product1.Categories.Add(Boy);
            //product1.Categories.Add(BigBang);

            Product product4 = new Product()
            {
                Id = Guid.NewGuid(),
                Price = 10,
                Title = "Test4",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Image = "",
                Stock = 10,
            };
            //product1.Categories.Add(LightStickProducts);
            //product1.Categories.Add(Girl);
            //product1.Categories.Add(Blackpink);

            _products.Add(product1);
            _products.Add(product2);
            _products.Add(product3);
            _products.Add(product4);


            ProductCategory productCategory1 = new ProductCategory()
            {
                ProductId = product1.Id,
                CategoryId = Girl.Id,
            };
            ProductCategory productCategory2 = new ProductCategory()
            {
                ProductId = product2.Id,
                CategoryId = Girl.Id,
            };
            ProductCategory productCategory3 = new ProductCategory()
            {
                ProductId = product3.Id,
                CategoryId = Girl.Id,
            };            
            ProductCategory productCategory4 = new ProductCategory()
            {
                ProductId = product1.Id,
                CategoryId = BTS.Id,
            };

            _productCategory.Add(productCategory1);
            _productCategory.Add(productCategory2);
            _productCategory.Add(productCategory3);
            _productCategory.Add(productCategory4);
            //User
            User user1 = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Test",
                LastName = "Test",
                Email = "test@test.no",
                Password = "password",
            };
            _users.Add(user1);

            //Order
            Order order = new Order()
            {
                Id = Guid.NewGuid(),
                UserId = user1.Id,
                status = "Pending"
            };
            _orders.Add(order);

            //Ratings

            Rating rating1 = new Rating()
            {
                Id = Guid.NewGuid(),
                Review = "This product was straight garbage cuh",
                RatingValue = 2,
                UserId = user1.Id,
                ProductId = product1.Id,

            };

            Rating rating2 = new Rating()
            {
                Id = Guid.NewGuid(),
                Review = "This product was straight fire blud",
                RatingValue = 5,
                UserId = user1.Id,
                ProductId = product2.Id,

            };
            _ratings.Add(rating1);
            _ratings.Add(rating2);

            //ProductsOrder

            ProductsOrder productsOrder = new ProductsOrder()
            {
                ProductId = product1.Id,
                OrderId = order.Id,
                Quantity = 1,
            };

            ProductsOrder productsOrder2 = new ProductsOrder()
            {
                ProductId = product2.Id,
                OrderId = order.Id,
                Quantity = 3,
            };

            _productsOrders.Add(productsOrder);
            _productsOrders.Add(productsOrder2);


        }
        


        public List<Product> Products { get { return _products; } }
        public List<Category> Categories { get { return _categories; } }
        public List<Order> Orders { get { return _orders; } }
        public List<ProductsOrder> ProductsOrder { get { return _productsOrders; } }
        public List<ProductCategory> ProductCategory { get { return _productCategory; } }
        public List<Rating> Ratings { get { return _ratings; } }
        public List<User> Users { get { return _users; } }
        public List<Wishlist> Wishlists { get { return _wishlists; } }
    }
}
