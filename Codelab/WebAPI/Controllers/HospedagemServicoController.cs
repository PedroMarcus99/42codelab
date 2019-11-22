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
    public class HospedagemServicoController : ControllerBase
    {


    [HttpGet]
    public List<HospedagemServico> Get(int codChale)
    {
      List<HospedagemServico> hospedagemServico = new List<HospedagemServico>();

      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        hospedagemServico.Add(conexao.ExecuteScalar<HospedagemServico>($"SELECT * FROM HOSPEDAGEM_SERVICO WHERE CODCLIENTE = {codChale}"));
        conexao.Close();
      }

      return hospedagemServico;
    }

    [HttpPost]
    public void Post(int codHospedagem, DateTime dataServico, int codServico)
    {
      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        conexao.Execute($@"INSERT INTO HOSPEDAGEM_SERVICO (codHospedagem, dataServico, codServico) 
                                                  VALUES({codHospedagem}, {dataServico}, {codServico})");
        conexao.Close();
      }
    }

    [HttpDelete]
    public void Delete(int codHospedagem, DateTime dataServico, int codServico)
    {
      using (SqlConnection conexao = new SqlConnection()) //TODO: Falta colocar os dados da string de conexão.
      {
        conexao.Open();
        conexao.Execute($"DELETE HOSPEDAGEM_SERVICO WHERE CODHOSPEDAGEM = {codHospedagem} AND DATASERVICO = {dataServico} AND CCODSERVICO = {codServico}");
        conexao.Close();
      }
    }
  }
}