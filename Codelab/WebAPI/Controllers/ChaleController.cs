using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChaleController : ControllerBase
    {

    [HttpGet]
    public List<Chale> Get(int codChale)
    {
      List<Chale> chale = new List<Chale>();

      using (SqlConnection conexao = new SqlConnection())
      {
        conexao.Open();
        chale.Add(conexao.ExecuteScalar<Chale>($"SELECT * FROM CLIENTE WHERE CODCLIENTE = {codChale}"));
        conexao.Close();
      }

      return chale;
    }

    [HttpPost]
    public void Post(int codChale, string localizacao, int capacidade, decimal valorAltaEstacao, decimal valorBaixaEstacao)
    {
      using (SqlConnection conexao = new SqlConnection())
      {
        conexao.Open();
        conexao.Execute($@"INSERT INTO CHALE (codChale,
                                                localizacao, 
                                                capacidade, 
                                                valorAltaEstacao, 
                                                valorBaixaEstacao) 
                        VALUES({codChale}, {localizacao}, {capacidade}, {valorAltaEstacao}, {valorBaixaEstacao})");
        conexao.Close();
      }
    }

    [HttpDelete]
    public void Delete(int codChale)
    {
      using (SqlConnection conexao = new SqlConnection())
      {
        conexao.Open();
        conexao.Execute($"DELETE CHALE WHERE CODCHALE = {codChale}");
        conexao.Close();
      }
    }
  }
}