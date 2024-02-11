using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MiniStore.DataAccess.Data;
using MiniStore.DataAccess.Repository.IRepository;
using MiniStore.Models;

namespace MiniStore.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price100 = obj.Price100;
                objFromDb.Description = obj.Description;
                objFromDb.CatId = obj.CatId;
                objFromDb.Size = obj.Size;
                //objFromDb.Image1 = obj.Image1;
                //objFromDb.Image2 = obj.Image2;
                //objFromDb.Image3 = obj.Image3;
                objFromDb.ProductImages = obj.ProductImages;
                objFromDb.Char_Class = obj.Char_Class;
                objFromDb.Char_Race = obj.Char_Race;

                //Comment out below?

                //if (obj.Image1 != null)                   ************************
                //{
                //    objFromDb.Image1 = obj.Image1;
                //}
            }
        }
    }
}
