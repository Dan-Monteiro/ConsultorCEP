using System;
using ConsultaCEP.Entities;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

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
                var stringRes = await response.Content.ReadAsStringAsync();
                endereco = JsonSerializer.Deserialize<Endereco>(stringRes);
            }

            return endereco;
        }
    }
}