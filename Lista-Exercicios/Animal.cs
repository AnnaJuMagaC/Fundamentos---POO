using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios
{
    public class Animal
    {
        public string? Especie { get; set; }
        public virtual void EmitirSom()
        {
            Console.WriteLine($"O animal da espécie {Especie} está emitindo um som.");
        }
    }
}
