using System;
using ConsultaCEP.Entities;
using ConsultaCEP.Client;
using System.Threading.Tasks;
using ConsultaCEP.Utils;

namespace ConsultaCEP
{
    class Program
    {
        static void Main(string[] args)
        {

                var option = Menu();

                while(option != "X"){

                    Int32.TryParse(option, out int task);

                switch(task){
                    case 1:
                        //Console.WriteLine(new Endereco("555-000", "Logradouro madureira", "casa", "Alto da Banana", "Pernambuco", "PE", "555", "123", 81, 12).ToString());
                        RunAsync().GetAwaiter().GetResult();
                    break;
                    default:
                        Console.WriteLine("Opção inválida");
                    break;
                }

                option = Menu();

            }
            Console.WriteLine("\nPrograma Finalizado");
        }

        public static string Menu()
        {
            Console.WriteLine("#-------------------- Menu ----------------------#");
            Console.WriteLine("#                                                #");
            Console.WriteLine("# 1 - Consultar CEP                              #");
            Console.WriteLine("# X - Sair da Aplicação                          #");
            Console.WriteLine("#                                                #");
            Console.WriteLine("#------------------------------------------------#");
            Console.WriteLine("\nInforme a opção para prosseguir: ");
            var option = Console.ReadLine();
            return option.ToUpper();
        }

         static async Task RunAsync()
        {   
            if(Internet.isOnline())
            {

                Console.WriteLine("Verificando CEP...");
                var result  = await Client.Client.GetEnderecoAsync("01001000");

            }else{

                Console.WriteLine("\nNecessário conexão com a internet para realizar esta operação...");

            }
        }
    }
}
