using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindSystem.BLL; //for access to my system
using NorthwindSystem.Entities; // for my EF entities
using Xunit;// the corse for testing
using Xunit.Extensions; // for theories, autorollback, etc.

namespace NorthwindSystem.UnitTests.CRUD
{
  public class CRUD_Shipper
  {
    [Fact]
    public void Should_Add_Numbers()
    {
      // arrange
      int first = 5, second = 7;
      // act
      int actual = first + second;

      // assert
      Assert.Equal(12, actual);

    }

    [Fact] // indicates that this is a test
    [AutoRollback] // undo database changes after the test
    public void Should_Add_Shippers()
    {
      // arrange
      var sut = new NorthwindManager(); // sut is short for "Situation Under Test")
      var expected = new Shipper()
      {
        CompanyName = "Montgomery Scott's Transporter Service",
        Phone = "780.555.1212"
      };

      // act
      var actualId = sut.AddShipper(expected);

      // assert
      Assert.True(actualId > 0);
      Shipper actual = sut.GetShipper(actualId);
      Assert.Equal(expected.CompanyName, actual.CompanyName);
      Assert.Equal(expected.Phone, actual.Phone);
      Assert.Equal(actualId, actual.ShipperID);


    }

    #region Properties for Test Data
    private static IEnumerable<object[]> _CurrentShippers = null;
    public static IEnumerable<object[]> CurrentShippers
    {
      get
      {
        if (_CurrentShippers == null) ;
        {

          var controller = new NorthwindManager();
          var temp = new List<object[]>();
          foreach (Shipper company in controller.ListShippers())
          {
            temp.Add(new object[] { company });
          }

        }
        return _CurrentShippers;

      }
    #endregion

    }
    
    

      [Theory] // indicates that this is a test with (potentially) external data
      [PropertyData("CurrentShippers")]
    [AutoRollback]
    public void Should_Update_Shipper(Shipper existing)
      {
        // arrange
        existing.Phone = "780.999.9999";
        var sut = new NorthwindManager();
        // act
        sut.UpdateShipper(existing);
        // assert
        var actual = sut.GetShipper(existing.ShipperID);
        Assert.NotNull(actual);
        Assert.Equal(existing.Phone, actual.Phone);
        Assert.Equal(existing.CompanyName, actual.CompanyName);


      }

      public void Should_Delete_Shipper(Shipper existing)
      {
        // arrange
        
        var sut = new NorthwindManager();
        var expected = new Shipper()
        {
          CompanyName = "Montgomery Scott's Transporter Service",
          Phone = "780.555.1212"

        };
        expected.ShipperID = sut.AddShipper(expected);
        // act
        sut.DeleteShipper(existing);
        // assert
        //var actual = sut.GetShipper(existing.ShipperID);
        //Assert.NotNull(actual);
        //Assert.Equal(existing.Phone, actual.Phone);
        //Assert.Equal(existing.CompanyName, actual.CompanyName);
        Shipper actual = sut.GetShipper(expected.ShipperID);
        Assert.Null(actual);


      }
  
      
  
  }
}
