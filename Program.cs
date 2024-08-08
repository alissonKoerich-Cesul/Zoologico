using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZoologicoClass zoologico = new ZoologicoClass();

            while (true)
            {
                Console.WriteLine("Selecione a Opção:");
                Console.WriteLine("1. Adicionar Mamifero");
                Console.WriteLine("2. Adicionar Ave");
                Console.WriteLine("3. Listar animais");
                Console.WriteLine("4. Alimentar animais");
                Console.WriteLine("5. Sair");

                string opcao = Console.ReadLine();

                if(opcao == "5")
                {
                    break;
                }
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do mamifero: ");
                        string nomeMamifero = Console.ReadLine();

                        Console.WriteLine("Digite a idade do mamifero: ");
                        int idadeMamifero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o tipo de pelo do mamifero: ");
                        string tipoDePelo = Console.ReadLine();


                        Mamifero mamifero = new Mamifero(nomeMamifero, idadeMamifero, tipoDePelo);

                        zoologico.AdicionarAnimal(mamifero);

                        break;

                    case "2":

                        Console.WriteLine("Digite o nome da ave: ");
                        string nomeAve = Console.ReadLine();

                        Console.WriteLine("Digite a idade da ave: ");
                        int idadeAve = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a envergadura das asas do animal:");
                        double envergadura = double.Parse(Console.ReadLine());


                        Ave ave = new Ave(nomeAve, idadeAve, envergadura);

                        zoologico.AdicionarAnimal(ave);
                        
                        break;

                    case "3":

                        zoologico.ListarAnimais();

                        break;

                    case "4":
                        zoologico.AlimentarAnimais();

                        break;

                    default:
                        Console.WriteLine("Opcao desconhecida");

                        break;
                }
            }
        }
            }
    }
    


