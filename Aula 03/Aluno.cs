using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03
{
    public class Aluno // Classe Aluno
    {
        public Aluno(int codigo, string Nome) //Metodo construtor com parametros
        {
            this.Codigo = codigo;
            this.Nome = Nome;
        }
        public int Codigo { get; set; } //Atributos
        public string? Nome { get; set; }
    }
}
