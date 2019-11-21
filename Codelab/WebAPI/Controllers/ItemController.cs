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
    public class ItemController : ControllerBase
    {

    [HttpGet]
    public List<Item> Get(string nomeItem)
    {
      List<Item> item = new List<Item>();

      using (SqlConnection conexao = new SqlConnection())
      {
        conexao.Open();
        item.Add(conexao.ExecuteScalar<Item>($"SELECT * FROM ITEM WHERE NOMEITEM = {nomeItem}"));
        conexao.Close();
      }

      return item;
    }

    [HttpPost]
    public void Post(string nomeItem, string descricao)
    {
      using (SqlConnection conexao = new SqlConnection())
      {
        conexao.Open();
        conexao.Execute($@"INSERT INTO ITEM (nomeItem, descricao) VALUES({nomeItem}, {descricao}");
        conexao.Close();
      }
    }

    [HttpDelete]
    public void Delete(string nomeItem)
    {
      using (SqlConnection conexao = new SqlConnection())
      {
        conexao.Open();
        conexao.Execute($"DELETE ITEM WHERE CODCHALE = {nomeItem}");
        conexao.Close();
      }
    }
  }
}