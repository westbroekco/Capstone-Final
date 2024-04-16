﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.DB.Interfaces;
using Dapper;
using System.Data;
using CKK.Logic.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;


namespace CKK.DB.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public ProductRepository(IConnectionFactory Conn)
        {
            _connectionFactory = Conn;
        }
        public async Task<int> AddAsync(Product entity)
        {
            var sql = "Insert into Products (Price,Quantity,Name) VALUES (@Price,@Quantity,@Name)";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }
        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM Products WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { Id = id });
                return result;
            }
        }

        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {

            var sql = "SELECT * FROM Products";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = await connection.QueryAsync<Product>(sql);
                return result.ToList();
            }
        }
        public List<Product> GetAll()
        {

            var sql = "SELECT * FROM Products";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Query<Product>(sql);
                return result.ToList();
            }
        }
        public async Task<Product> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM Products WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Product>(sql, new { Id = id });
                return result;
            }
        }

        public Product GetById(int id)
        {
            var sql = "SELECT * FROM Products WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.QuerySingleOrDefault<Product>(sql, new { Id = id });
                return result;
            }
        }


        public async Task<IReadOnlyList<Product>> GetByNameAsync(string name)
        {
            var sql = "SELECT * FROM Products WHERE Name = @Name";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = await connection.QueryAsync<Product>(sql, new { Name = name });
                return result.ToList();
            }
        }
        public async Task<int> UpdateAsync(Product entity)
        {
            var sql = "UPDATE Products SET Price = @Price, Quantity = @Quantity, Name = @Name WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }

        public int Update(Product entity)
        {
            var sql = "UPDATE Products SET Price = @Price, Quantity = @Quantity, Name = @Name WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }
    }
}
