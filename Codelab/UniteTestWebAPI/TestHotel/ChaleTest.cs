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
  public class ChaleTest
  {
    ChaleController chale = new ChaleController();
    
    [Fact]
    public void GetTest()
    {
      try
      {
        List<Chale> chaleList = chale.Get(1);
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
        chale.Post(1, "Rua das Quitandas 123", 5, 500, 150); 
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
        chale.Delete(1);
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}
