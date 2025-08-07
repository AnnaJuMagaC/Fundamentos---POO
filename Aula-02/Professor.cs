using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    //Classe Professor que herda da Classe Pessoa
    public class Professor : Pessoa
    {
        public string? Especialidade { get; set; }
        public int? Registro { get; set; }
        public double? Salario { get; set; }


        //Sobrecarga do metodo Apresentar da classe Pessoa
        public override void Apresentar() //Overrid faz a sobrearga em classes filhas
        {
            //Sobrecarga do metodo Apresentar da classe Pessoa
            base.Apresentar(); //Chama o metodo Apresentar da classe base (Pessoa)
            Console.WriteLine($"Sou especialista em é {Especialidade}, meu registro é {Registro} e meu salário é {Salario}."); //Adiciona informações específicas da classe Professor
        }
    }
}

