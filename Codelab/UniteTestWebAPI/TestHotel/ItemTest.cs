using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using WebAPI.Controllers;
using WebAPI.Models;

namespace UnitTest
{
  public class ItemTest
  {
    ItemController item = new ItemController();

    [Fact]
    public void GetTest()
    {
      try
      {
        List<Item> itemLista = item.Get("Toalha");
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }

    [Fact]
    public void PostTest()
    {
      try
      {
        item.Post("Toalha", "Item utilizado para secar o corpo");
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }

    [Fact]
    public void DeleteTest()
    {
      try
      {
        item.Delete("Toalha");
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}
