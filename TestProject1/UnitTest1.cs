using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using CKK.Logic.Models;
using Xunit.Sdk;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1ForAddingProduct()
        {
            Customer customer = new Customer();
            Product product = new Product();
            product.SetId(20);
            ShoppingCart item = new ShoppingCart(customer);
            item.AddProduct(product);
            int expected = 20;
            int actual = product.GetId();
            Assert.Equal(expected, actual);
        }
            [Fact]   
         public void Test2ForRemovingProduct()
        { 
            Customer customer = new Customer();
            Product product = new Product();
            product.SetId(20);
            ShoppingCart shoppingCart = new ShoppingCart(customer);
            shoppingCart.AddProduct(product, 10);
            shoppingCart.RemoveProduct(product , 5);
            int expected = 5;
            int actual = shoppingCart.GetProduct(20).GetQuantity();
            Assert.Equal(expected , actual);
        }
        [Fact]
        public void Test3ForTotal()
        {   
            Customer customer = new Customer();
            Product product = new Product();
            product.SetPrice(100);
            ShoppingCart shoppingCart = new ShoppingCart(customer);
            Product product1 = new Product();
            Product product2 = new Product();
            product2.SetPrice(100);
            product1.SetPrice(100);
            decimal expectedtotal = 300;
            shoppingCart.AddProduct(product);
            shoppingCart.AddProduct(product2);
            shoppingCart.AddProduct(product);

            decimal actual = shoppingCart.GetTotal();
            Assert.Equal(expectedtotal, actual);


           

                

            



        }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
           






}
        
        
        
        }

        
    

