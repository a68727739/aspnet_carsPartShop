﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// CartModel 的摘要描述
/// </summary>
public class CartModel
{
    public string InsertCart(Cart cart)
    {
        try
        {
            GarageDBEntities1 db = new GarageDBEntities1();
            db.Carts.Add(cart);
            db.SaveChanges();
            return cart.DatePurchased + "was successfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            GarageDBEntities1 db = new GarageDBEntities1();
            //Fetch object from db
            Cart p = db.Carts.Find(id);
            p.DatePurchased = cart.DatePurchased;
            p.ClientID  = cart.ClientID;
            p.Amount = cart.Amount;
            p.IsInCart = cart.IsInCart;
            p.ProductID = cart.ProductID;
            db.SaveChanges();
            return cart.DatePurchased + "was successfully updated";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public string DeleteCart(int id)
    {
        try
        {
            GarageDBEntities1 db = new GarageDBEntities1();
            Cart cart = db.Carts.Find(id);
            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();
            return cart.DatePurchased + "was successfully deleted!!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}