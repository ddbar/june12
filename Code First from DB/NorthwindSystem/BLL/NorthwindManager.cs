﻿using NorthwindSystem.DAL;
using NorthwindSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity; // for some of the EF extension methods
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindSystem.BLL
{
    // This is the primary public access into the NorthwindSystem's data
    [DataObject]
    public partial class NorthwindManager
    {
      #region Shippers

      public IList<Shipper> ListShippers()
      {
        using (var context = new NWContext())
        {
          return context.Shippers.ToList();
        }



      }

      public IList<Product> ListProducts()
      {
        using (var context = new NWContext())
        {
          return context.Products.ToList();

        }


      }

      public Shipper GetShipper(int shipperId)
      {
        //throw new NotImplementedException("v.2.0");
        using (var context = new NWContext())
        {

          return context.Shippers.Find(shipperId);

          //context.Shippers.Add(info);
          //context.SaveChanges();
          //return info.ShipperID;
        }
      }
public int AddShipper(Shipper info)
     {
       using (var context = new NWContext())
       { 
       
         
         context.Shippers.Add(info);
         context.SaveChanges();
         return info.ShipperID;
     }
        
    
    }
    



      #endregion

      #region Legacy Code

      public List<Employee> GetEmployees()
        {
            using (var context = new NWContext())
            {
                var result = context.Employees;
                return result.ToList();
            }
        }

        // TODO: Create a method called GetOrders() that will return a list of Order objects from the database.
        public List<Order> GetOrders()
        {
            using (var context = new NWContext())
            {
                var result = context.Orders;
                return result.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Region> GetRegions()
        {
            using (var context = new NWContext())
            {
                var result = 
                    context.Regions
                           .Include(item => item.Territories)
                           .OrderBy(item => item.RegionDescription);

                return result.ToList();
               


     
            
            }
        }

        public List<Product> GetProducts()
        {
          using (var context = new NWContext())
          {
            var result = context.Products;
            return result.ToList();
          }
        }

        public void UpdateShipper(Shipper info)
        {
          //throw new NotImplementedException();
          //todo: give this to the new guy - i'm on holidays :) :)
          // http://stackoverflow.com/questions/15336248/entity-framework-5-updating-a-record
          
          using (var context = new NWContext())
          {
            context.Shippers.Attach(info);
            context.Entry(info).State = EntityState.Modified;
            context.SaveChanges();
          }

        }

        public void UpdateShipper(Product info)
        {
          //throw new NotImplementedException();
          //todo: give this to the new guy - i'm on holidays :) :)
          // http://stackoverflow.com/questions/15336248/entity-framework-5-updating-a-record

          using (var context = new NWContext())
          {
            context.Products.Attach(info);
            context.Entry(info).State = EntityState.Modified;
            context.SaveChanges();
          }

        }





        public void DeleteShipper(Shipper info)
        {
          using (var context = new NWContext())
          {
            var found = context.Shippers.Find(info.ShipperID);
            if (found != null)
            {
              context.Shippers.Remove(found);
              context.SaveChanges();


            }

          }
        }

        public void DeleteShipper(Product info)
        {
          using (var context = new NWContext())
          {
            var found = context.Products.Find(info.ProductID);
            if (found != null)
            {
              context.Products.Remove(found);
              context.SaveChanges();


            }

          }
        }


     #endregion
    
    }
}
