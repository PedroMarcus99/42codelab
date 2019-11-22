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
    public class TelefoneClienteController : ControllerBase
    {
    [HttpGet]
    public List<TelefoneCliente> Get(int codCliente)
    {
      List<TelefoneCliente> telefoneCliente = new List<TelefoneCliente>();

      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão. 
      {
        conexao.Open();
        telefoneCliente.Add(conexao.ExecuteScalar<TelefoneCliente>($"SELECT * FROM TELEFONE WHERE CODCLIENTE = {codCliente}"));
        conexao.Close();
      }

      return telefoneCliente;
    }

    [HttpPost]
    public void Post(string telefone, int codCliente)
    {
      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        conexao.Execute($@"INSERT TELEFONE ITEM (TELEFONE, CODCLIENTE) VALUES({telefone}, {codCliente}");
        conexao.Close();
      }
    }

    [HttpDelete]
    public void Delete(int codCliente)
    {
      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        conexao.Execute($"DELETE TELEFONE WHERE CODCLIENTE = {codCliente}");
        conexao.Close();
      }
    }
  }
}