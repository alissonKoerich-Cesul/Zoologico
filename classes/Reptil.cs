using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.classes
{


    public class Reptil : Animal
    {
        public string TipoEscama { get; set; }

        public Reptil(string nome, int idade, string tipoEscama) : base(nome, idade)
        {
            TipoEscama = tipoEscama;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"O {Nome} esta fazendo som");
        }

    } }
