using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.interfaces;

namespace Zoologico.classes
{
  
        public class ZoologicoClass
        {
            private List<Animal> animals = new List<Animal>();

            public void AdicionarAnimal(Animal animal)
            {
                animals.Add(animal);
            Console.WriteLine($"{animal.Nome} foi adicionado");
            }

            public void ListarAnimais()
        {
            if(animals.Count > 0)
            {
                Console.WriteLine("Animais no Zoologico: ");
                foreach(Animal animal in animals)
                {
                    animal.EmitirSom();
                    Console.WriteLine($"Nome: {animal.Nome}, Idade: {animal.Idade}");
                }

            }
            else
            {
                Console.WriteLine("A lista esta vazia");
            }
        }

        public void AlimentarAnimais()
        {
            Console.WriteLine("Alimentando os animais....");
            foreach (Animal animal in animals)
            {
                if (animal is IAlimentavel alimentavel)
                {
                    alimentavel.Alimentar();
                }
            }
        }


        }
}

