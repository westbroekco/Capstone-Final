using CKK.Logic.Models;
using CKK.DB.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.DB.Repositories;

namespace CKK.DB.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        
        private readonly string _shopcart = "ShoppingCartItems";


        public ShoppingCartRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        
        public ShoppingCartItem AddtoCart(int ShoppingCardId, int ProductId, int quantity)
        {
            using(var conn = _connectionFactory.GetConnection) 
            {
                ProductRepository _productRepository = new ProductRepository(_connectionFactory);
                var item = _productRepository.GetById(ProductId);
                var ProductItems = GetProducts(ShoppingCardId).Find(x => x.ProductId == ProductId);

                var shopitem = new ShoppingCartItem()
                {
                    ShoppingCartId = ShoppingCardId,
                    ProductId = ProductId,
                    Quantity = quantity
                };
                
                if (item.Quantity >= quantity) 
                {
                    if (ProductItems != null)
                    {
                        //Product already in cart so update quantity
                        var test = UpdateAsync(shopitem);
                    }
                    else
                    {
                        //New product for the cart so add it
                        var test = AddAsync(shopitem);
                    }
                }
                return shopitem;
            }
        }
        public int ClearCart(int shoppingCartId)
        {
            var sql = $"DELETE FROM {_shopcart} WHERE ShoppingCartId = @ShoppingCartId";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, new { ShoppingCartId = shoppingCartId });
                return 1;
            }
        }
            public int AddAsync(ShoppingCartItem entity)
        {
            var sql = "Insert into ShoppingCartItems (ShoppingCartId,ProductId,Quantity) VALUES (@ShoppingCartId,@ProductId,@Quantity)";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }
        
        public int UpdateAsync(ShoppingCartItem entity)
        {
            var sql = "UPDATE ShoppingCartItems SET ShoppingCartId = @ShoppingCartId, ProductId = @ProductId, Quantity = @Quantity WHERE ShoppingCartId = @ShoppingCartId AND ProductId = @ProductId";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result =  connection.Execute(sql, entity);
                return result;
            }
        }

        public List<ShoppingCartItem> GetProducts(int shoppingCartId)
        {
            using (var conn = _connectionFactory.GetConnection) 
            {
                string sql = @"SELECT * FROM ShoppingCartItems WHERE ShoppingCartId = @ShoppingCartId";
                var result = SqlMapper.Query<ShoppingCartItem>(conn, sql, new { ShoppingCartId = shoppingCartId }).ToList();
                return result;
            }
        }

        public decimal GetTotal(int shoppingCartId)
        {
            using (var conn = _connectionFactory.GetConnection)
            {
                var items = SqlMapper.Query<ShoppingCartItem>(conn, @"SELECT * FROM ShoppingCartItems WHERE dbo.ShoppingCartItems.ShoppingCartId = @ShoppingCartId", new { ShoppingCartId = shoppingCartId }).ToList();
                List<decimal> total = new List<decimal>();
                ProductRepository _productRepository = new ProductRepository(_connectionFactory);

                foreach (var item in items)
                {
                    var product = _productRepository.GetById(item.ProductId);
                    total.Add(product.Price * (decimal)item.Quantity);
                }
               return total.Sum();
               
            }

            //The following is a more simple and clean version if you want to share this with a student
            //var sql = "SELECT SUM(Price * ShoppingCartItems.Quantity) FROM Products JOIN ShoppingCartItems ON ProductId = Products.Id WHERE ShoppingCartId = @shoppingCartId";

            //using (var connection = _connectionFactory.GetConnection)
            //{
            //    connection.Open();
            //    var result = connection.QuerySingleOrDefault<Decimal>(sql, new { ShoppingCartId = shoppingCartId });
            //    return result;
            //}
        }

        public void Ordered(int shoppingCartId)
        {
            using (var conn = _connectionFactory.GetConnection)
            {
                SqlMapper.Execute(conn, $"DELETE FROM {_shopcart} WHERE ShoppingCartId=ShoppingCartId", new { ShoppingCartId = shoppingCartId });
            }
        }
    }
}
