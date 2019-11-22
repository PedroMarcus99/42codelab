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
  public class HospedagemServicoTest
  {
    HospedagemServicoController hospedagemServico = new HospedagemServicoController();

    [Fact]
    public void GetTest()
    {
      try
      {
        List<HospedagemServico> hospedagemServicosList = hospedagemServico.Get(1);
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
        hospedagemServico.Post(1, DateTime.Now, 1);
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
        hospedagemServico.Delete(1, DateTime.Now, 1);
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}
