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
                        var cep = InputCep();
                        RunAsync(cep).GetAwaiter().GetResult();
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
            Console.WriteLine("");
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

         static async Task RunAsync(string cep)
        {   

            if(Internet.isOnline())
            {

                Console.WriteLine("Verificando CEP...");
                var result  = await Client.Client.GetEnderecoAsync(cep);

            }else{

                Console.WriteLine("\nNecessário conexão com a internet para realizar esta operação...");

            }
        }

        static string InputCep(){

            Console.WriteLine("Informe o CEP a ser buscado:");
            var cep = Console.ReadLine();

            while(String.IsNullOrEmpty(cep)){
                Console.WriteLine("Necessário informar um CEP!");
                InputCep();
            }

            if(FormatValidation.ValidaFormatoCep(cep) == false){
                Console.WriteLine("Fomato de CEP inválido!");
                InputCep();
            }
            
            if(FormatValidation.ValidaCep(cep) == true){
                Console.WriteLine("CEP inválido!");
                InputCep();
            }

            return cep;
        }
    }
}
