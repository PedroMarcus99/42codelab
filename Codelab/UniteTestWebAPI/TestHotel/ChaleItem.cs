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
  public class ChaleItem
  {
    ChaleItemController chaleItem = new ChaleItemController();
    [Fact]
    public void GetTest()
    {
      try
      {
        List<Item> item = chaleItem.Get(1, "Lustre");
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
        chaleItem.Post(1, "Lustre");
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
        chaleItem.Get(1, "Lustre");
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}
