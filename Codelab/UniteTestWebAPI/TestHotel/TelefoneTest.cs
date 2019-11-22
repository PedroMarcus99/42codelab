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
  public class TelefoneTest
  {
    TelefoneClienteController telefoneClienteController = new TelefoneClienteController();
    [Fact]    
    public void GetTest()
    {
      
      try
      {
        int codCliente = 10;
        List<TelefoneCliente> telefoneCliente = telefoneClienteController.Get(codCliente); 
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
        telefoneClienteController.Post("2222-2222", 10);
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
        telefoneClienteController.Delete(10);
      }
      catch (Exception ex) 
      {
        throw new Exception(ex.Message);
      }
    }
  }
}
