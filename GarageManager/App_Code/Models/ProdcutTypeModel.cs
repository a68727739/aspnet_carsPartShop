﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ProdcutTypeModel 的摘要描述
/// </summary>
public class ProdcutTypeModel
{
    public string InsertProductType(ProductType productType)
    {
        try
        {
            GarageDBEntities1 db = new GarageDBEntities1();
            db.ProductTypes.Add(productType);
            db.SaveChanges();
            return productType.Name + "was successfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public string UpdateProductType(int id, ProductType productType)
    {
        try
        {
            GarageDBEntities1 db = new GarageDBEntities1();
            //Fetch object from db
            ProductType p = db.ProductTypes.Find(id);
            p.Name = productType.Name;

            db.SaveChanges();
            return productType.Name + "was successfully updated";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public string DeleteProductType(int id)
    {
        try
        {
            GarageDBEntities1 db = new GarageDBEntities1();
            ProductType productType = db.ProductTypes.Find(id);
            db.ProductTypes.Attach(productType);
            db.ProductTypes.Remove(productType);
            db.SaveChanges();
            return productType.Name + "was successfully deleted!!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}