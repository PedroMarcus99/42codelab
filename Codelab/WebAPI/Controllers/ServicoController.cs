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
    public class ServicoController : ControllerBase
  {

    [HttpGet]
    public List<Servico> Get(int codServico)
    {
      List<Servico> servico = new List<Servico>();

      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        servico.Add(conexao.ExecuteScalar<Servico>($"SELECT * FROM SERVICO WHERE CODSERVICO = {codServico}"));
        conexao.Close();
      }

      return servico;
    }

    [HttpPost]
    public void Post(int codServico, string nomeServico, decimal valorServico)
    {
      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        conexao.Execute($@"INSERT INTO SERVICO (CODSERVICO, NOMESERVICO, VALORSERVICO ) VALUES({codServico}, '{nomeServico}', {valorServico}");
        conexao.Close();
      }
    }

    [HttpDelete]
    public void Delete(int codServico)
    {
      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        conexao.Execute($"DELETE SERVICO WHERE CODSERVICO = {codServico}");
        conexao.Close();
      }
    }
  }
}