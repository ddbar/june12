using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace NorthwindSystem.UnitTests.CRUD
{
  class CRUD_Products
  {
  private static IEnumerable<object[]> _CurrentProducts = null;
    public static IEnumerable<object[]> CurrentProducts
    {
      get
      {
        if (_CurrentProducts == null) ;
        {

          var controller = new NorthwindManager();
          var temp = new List<object[]>();
          foreach (Product company in controller.ListProducts())
          {
            temp.Add(new object[] { company });
          }

        }
        return _CurrentProducts;

      }  
    

    


  }
}
