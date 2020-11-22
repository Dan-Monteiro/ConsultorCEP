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
                       searchCep();
                    break;
                    default:
                        CustomConsole.WriteError("Opção inválida");
                    break;
                }

                option = Menu();

            }

            Console.WriteLine("\nPrograma Finalizado");

        }

        public static string Menu()
        {
            CustomConsole.WriteLine("");
            CustomConsole.WriteLine("#-------------------- Menu ----------------------#");
            CustomConsole.WriteLine("#                                                #");
            CustomConsole.WriteLine("# 1 - Consultar CEP                              #");
            CustomConsole.WriteLine("# X - Sair da Aplicação                          #");
            CustomConsole.WriteLine("#                                                #");
            CustomConsole.WriteLine("#------------------------------------------------#");
            CustomConsole.WriteLine("\nInforme a opção para prosseguir:");
            var option = Console.ReadLine();
            return option.ToUpper();
        }

        public static void searchCep()
        {

            var cep = InputCep();

            try{
                RunAsync(cep).GetAwaiter().GetResult();
            }catch(Exception e){
                CustomConsole.WriteError("Uma exceção ocorreu:" + e.Message);
            }

        }

         static async Task RunAsync(string cep)
        {   

            CustomConsole.WriteLine("Checando conexão...");

            if(Internet.isOnline())
            {

                CustomConsole.WriteLine("Verificando CEP...");
                var result  = await Client.Client.GetEnderecoAsync(cep);
                CustomConsole.DefaultWriteLine("Resultado:\n" + result.ToString());

            }else{

                CustomConsole.WriteError("\nNecessário conexão com a internet para realizar esta operação...");

            }
        }

        static string InputCep(){

            CustomConsole.WriteLine("Informe o CEP a ser buscado:");
            var cep = Console.ReadLine();

            while(String.IsNullOrEmpty(cep)){
                CustomConsole.WriteError("Necessário informar um CEP!");
                InputCep();
            }

            if(FormatValidation.ValidaFormatoCep(cep) == false){
                CustomConsole.WriteError("Fomato de CEP inválido!");
                InputCep();
            }
            
            if(FormatValidation.ValidaCep(cep) == true){
                CustomConsole.WriteError("CEP inválido!");
                InputCep();
            }

            return cep;
        }
    }
}
