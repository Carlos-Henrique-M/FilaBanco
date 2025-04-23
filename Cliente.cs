using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaBanco
{
    
        public class cliente
        {
            public int id; { get; set; }
            public string name { get; set; }
            public int idade { get; set; }
            oioi

        }
        public void Cadastrar()
        {
            Console.WriteLine("Digite o nome");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            this.idade = int.Parse(Console.ReadLine());
        }
    }
}
