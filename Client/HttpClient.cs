using System;
using ConsultaCEP.Entities;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsultaCEP.Client {

    class Client{
        private static HttpClient client = new HttpClient();

        public static async Task<Endereco> GetEnderecoAsync(string value)
        {   
            
            client.BaseAddress = new Uri("https://viacep.com.br/ws/");

            Endereco endereco = null;

            HttpResponseMessage response = await client.GetAsync(value + "/json");

            if (response.IsSuccessStatusCode)
            {
                var algo = await response.Content.ReadAsStringAsync();
            }

            return endereco;
        }
    }
}