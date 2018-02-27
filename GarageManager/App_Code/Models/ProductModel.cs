using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ProductModel 的摘要描述
/// </summary>
public class ProductModel
{
    public string InsertProduct(Product product)
    {
        try
        {
            GarageDBEntities1 db = new GarageDBEntities1();
            db.Products.Add(product);
            db.SaveChanges();
            return product.Name + "was successfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public string UpdateProduct(int id, Product product)
    {
        try
        {
            GarageDBEntities1 db = new GarageDBEntities1();
            //Fetch object from db
            Product p = db.Products.Find(id);
            p.Name = product.Name;
            p.Price = product.Price;
            p.TypeId = product.TypeId;
            p.Description = product.Description;
            p.Image = product.Image;
            db.SaveChanges();
            return product.Name + "was successfully updated";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public string DeleteProduct(int id)
    {
        try
        {
            GarageDBEntities1 db = new GarageDBEntities1();
            Product product = db.Products.Find(id);
            db.Products.Attach(product);
            db.Products.Remove(product);
            db.SaveChanges();
            return product.Name + "was successfully deleted!!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public Product GetProduct(int id)
    {
        try
        {
            using (GarageDBEntities1 db = new GarageDBEntities1())
            {
                Product product = db.Products.Find(id);
                return product;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
    public List<Product> GetAllProducts()
    {
        try
        {
            using (GarageDBEntities1 db = new GarageDBEntities1())
            {
                List<Product> products = (from x in db.Products
                                          select x).ToList();
                return products;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
    public List<Product> GetProductsByType(int typeId)
    {
        try
        {
            using (GarageDBEntities1 db = new GarageDBEntities1())
            {
                List<Product> products = (from x in db.Products
                                          where x.TypeId == typeId
                                          select x).ToList();
                return products;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}