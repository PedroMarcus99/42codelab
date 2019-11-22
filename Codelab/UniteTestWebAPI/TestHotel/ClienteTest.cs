using WebAPI.Models;
using WebAPI.Controllers;
using System.Collections.Generic;
using Xunit;
using System;
using WebAPI.Controllers;

namespace UnitTest
{
  public class ClienteTest
  {
    ClienteController cliente = new ClienteController();

    [Fact]
    public void GetTest()
    {
      try
      {
        List<Cliente> clienteList = cliente.Get(1); 
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
        cliente.Post(1, "Marcelo", "MG-12.956.098.76", "Rua Santa Maria", "Lourdes", "MG", "21.333-556", new DateTime(12,12,1990));
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
        cliente.Delete(1);
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}
