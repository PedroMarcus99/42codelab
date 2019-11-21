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
  public class HospedagemController : ControllerBase
  {
    [HttpGet]
    public List<Hospedagem> Get(int codHospedagem)
    {
      List<Hospedagem> hospedagem = new List<Hospedagem>();

      using (SqlConnection conexao = new SqlConnection())
      {
        conexao.Open();
        hospedagem.Add(conexao.ExecuteScalar<Hospedagem>($"SELECT * FROM HOSPEDAGEM WHERE CODHOSPEDAGEM = {codHospedagem}"));
        conexao.Close();
      }

      return hospedagem;
    }

    [HttpPost]
    public void Post(int codHospedagem, int codChale, string estado, DateTime dataInicio, DateTime dataFim, int qtdPessoas, decimal desconto, decimal valorFinal)
    {
      using (SqlConnection conexao = new SqlConnection())
      {
        conexao.Open();
        conexao.Execute($@"INSERT INTO HOSPEDAGEM (codHospedagem, 
                                                codChale, 
                                                estado,
                                                dataInicio, 
                                                dataFim, 
                                                qtdPessoas, 
                                                desconto, 
                                                valorFinal) 
                        VALUES({codHospedagem}, {codChale}, {estado}, {dataInicio}, {dataFim}, {qtdPessoas}, {desconto}, {valorFinal})");
        conexao.Close();
      }
    }

    [HttpDelete]
    public void Delete(int codHospedagem)
    {
      using (SqlConnection conexao = new SqlConnection())
      {
        conexao.Open();
        conexao.Execute($"DELETE HOSPEDAGEM WHERE CODCLIENTE = { codHospedagem}");
        conexao.Close();
      }
    }
  }
}