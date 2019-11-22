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
  public class HospedagemTest
  {
    HospedagemController hospedagem = new HospedagemController();

    [Fact]
    public void GetTest()
    {
      try
      {
        List<Hospedagem> hospedagemLista = hospedagem.Get(1);
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
        hospedagem.Post(1, 1, "Conservado", DateTime.Now, DateTime.Now.AddDays(1), 2, 10m, 500m);
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
        hospedagem.Delete(1);
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}
