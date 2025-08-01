using System;

namespace SistemaAcademia.Models
{
    internal interface IAluno
    {
         int Id { get; set; }
         string NomeCompleto { get; set; }
         string Cpf { get; set; }
         string Telefone { get; set; }
         char Sexo { get; set; }
         DateTime DataNascimento { get; set; }
         double Altura { get; set; }
         double Peso { get; set; }
         DateTime DataCadastro { get; set; }
         char Status { get; set; }


    }
}
