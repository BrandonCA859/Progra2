﻿using DataAccess;
using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvProducts : ISvProducts
    {

        private readonly MyDbContext _myDbContext;


        public SvProducts(MyDbContext myDbContext)

        {
            _myDbContext = myDbContext;
        }

        public Products Add(Products products)
        {
            _myDbContext.Products.Add(products);
            _myDbContext.SaveChanges();

            return products;
        }

        public void Delete(int id)
        {
            Products productsFound = _myDbContext.Products.Where(products => products.Id == id).FirstOrDefault();

            _myDbContext.Products.Remove(productsFound);
            _myDbContext.SaveChanges();
        }

        public IEnumerable<Products> GetAll()
        {
            return _myDbContext.Products.ToList();
        }

        public Products GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Products> ListProducts()
        {
            return _myDbContext.Products.ToList();
        }


        public void Update(Products products, int id)
        {
            Products ProductsFound = _myDbContext.Products.Where(Products => Products.Id == id).First();
            ProductsFound.Id = ProductsFound.Id;

            _myDbContext.Products.Update(ProductsFound);
            _myDbContext.SaveChanges();

            return ProductsFound;
        }
    }
}