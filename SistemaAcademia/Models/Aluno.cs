using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//TODO: Implementar DataAnnotations

namespace SistemaAcademia.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public DateTime DataCadastro { get; set; }
        public char Status { get; set; }

        public Aluno()
        {
            
        }
    }
}