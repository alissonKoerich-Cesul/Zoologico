using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.interfaces;

namespace Zoologico.classes
{
    
        public class Mamifero : Animal, IAlimentavel
        {
            public string TipoDePelo { get; set; }

            public Mamifero(string nome, int idade, string tipoDePelo) : base(nome, idade)
            {
                TipoDePelo = tipoDePelo;
            }


            public override void EmitirSom()
            {
                Console.WriteLine($"{Nome} faz som de mamifero");
            }

            public void Alimentar()
            {
                Console.WriteLine($"{Nome} é mamifero e esta sendo alimentado");
            }


        }
    }

