using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using WebAPI.Models;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ClienteController : ControllerBase
  {
    [HttpGet]
    public List<Cliente> Get(int codCliente)
    {
      List<Cliente> cliente = new List<Cliente>();

      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        cliente.Add(conexao.ExecuteScalar<Cliente>($"SELECT * FROM CLIENTE WHERE CODCLIENTE = {codCliente}"));
        conexao.Close();
      }

      return cliente;
    }

    [HttpPost]
    public void Post(int codCliente, string nomeClinte, string rgCliente, string enderecoCliente, string bairroCliente, 
                     string estadoCliente, string cepCliente, DateTime dataNascimentoCliente)
    {
      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        conexao.Execute($@"INSERT INTO CLIENTE (codCliente, 
                                                nomeCliente, 
                                                rgCliente,
                                                enderecoCliente,
                                                bairroCliente,
                                                cidadeCliente,
                                                estadoCliente,
                                                CEPCliente,
                                                nascimentoCliente) 
                        VALUES({codCliente}, {nomeClinte}, {rgCliente}, {enderecoCliente}, {bairroCliente}, {estadoCliente}, {cepCliente}, {dataNascimentoCliente})");
        conexao.Close();
      }
    }

    [HttpDelete]
    public void Delete(int codCliente) 
    {
      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        conexao.Execute($"DELETE CLIENTE WHERE CODCLIENTE = {codCliente}");
        conexao.Close();
      }
    }
  }
}