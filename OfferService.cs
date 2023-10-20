using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSampleProject.Models
{
    public class OfferService
    {

        public OfferService()
        {
            AddAllProductsToInventory();
        }
        List<Product> Inventory { get; set; }

        void AddAllProductsToInventory()
        {
            Inventory = new List<Product>();

            Inventory.Add(new Product() { ProductName = "P1", Price = 1000, Description = "P1 desc" });
            Inventory.Add(new Product() { ProductName = "P2", Price = 200, Description = "P2 desc" });
            Inventory.Add(new Product() { ProductName = "P3", Price = 400, Description = "P3 desc" });
            Inventory.Add(new Product() { ProductName = "P4", Price = 700, Description = "P4 desc" });
            Inventory.Add(new Product() { ProductName = "P5", Price = 600, Description = "P5 desc" });
            Inventory.Add(new Product() { ProductName = "P6", Price = 800, Description = "P6 desc" });
        }

        public List<Product> GetAllProducts()
        {
            return Inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            List<Offer> lstOffers = new List<Offer>();

            lstOffers.Add( new Offer() 
            { 
                OfferName = "ComboPackage1", 
                Products = new List<Product>() { Inventory[0], Inventory[2], Inventory[3] }
            });

            lstOffers.Add(new Offer()
            {
                OfferName = "ComboPackage2",
                Products = new List<Product>() { Inventory[4], Inventory[5], Inventory[1] }
            });
            lstOffers.Add(new Offer()
            {
                OfferName = "ComboPackage3",
                Products = new List<Product>() { Inventory[2], Inventory[5], Inventory[4] }
            });

            lstOffers.Add(new Offer()
            {
                OfferName = "ComboPackage4",
                Products = new List<Product>() { Inventory[5], Inventory[2], Inventory[3] }
            });

            return lstOffers;
        }
         
    }
}