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
    public class ChaleItemController : ControllerBase
    {

    [HttpGet]
    public List<Item> Get(int codChale, string nomeItem)
    {
      List<Item> item = new List<Item>();

      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        item.Add(conexao.ExecuteScalar<Item>($"SELECT * FROM CHALE_ITEM WHERE CODCHALE = {codChale} AND NOMEITEM = '{nomeItem}'"));
        conexao.Close();
      }

      return item;
    }

    [HttpPost]
    public void Post(int codChale, string nomeItem)
    {
      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        conexao.Execute($@"INSERT INTO CHALE_ITEM (nomeItem, descricao) VALUES({codChale}, {nomeItem}");
        conexao.Close();
      }
    }

    [HttpDelete]
    public void Delete(int codChale, string nomeItem)
    {
      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        conexao.Execute($"DELETE CHALE_ITEM WHERE CODCHALE = {codChale} AND NOMEITEM = '{nomeItem}'");
        conexao.Close();
      }
    }
  }
}