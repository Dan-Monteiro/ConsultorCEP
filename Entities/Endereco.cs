using System.Text.Json.Serialization;

namespace ConsultaCEP.Entities{

    class Endereco
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; }
        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }
        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }
        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }
        [JsonPropertyName("localidade")]
        public string Localidade { get; set; }
        [JsonPropertyName("uf")]
        public string Uf { get; set; }
        [JsonPropertyName("ibge")]
        public string Ibge { get; set; }
        [JsonPropertyName("gia")]
        public string Gia { get; set; }
        [JsonPropertyName("ddd")]
        public string Ddd { get; set; }
        [JsonPropertyName("siafi")]
        public string Siafi { get; set; }

        public Endereco(){
            //Leave empty for json serialization
        }

        public Endereco(string cep, string logradouro, string complemento, string bairro, string localidade, string uf, string ibge, string gia, string ddd, string siafi ){
            Cep = cep;
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Localidade = localidade;
            Uf = uf;
            Ibge = ibge;
            Gia = gia;
            Ddd = ddd;
            Siafi = siafi;
        }

        public override string ToString(){
            return $"[\nCEP: {Cep} \nLogradouro: {Logradouro} \nComplemento: {Complemento}\nBairro: {Bairro}\nLocalidade: {Localidade}\nUF: {Uf}\nIBGE: {Ibge}\nGia: {Gia}\nDDD: {Ddd}\nSiafi: {Siafi}\n]";
        }
    }
}