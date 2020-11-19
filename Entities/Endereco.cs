using System;
using System.Reflection;

namespace ConsultaCEP.Entities{

    class Endereco
    {
        private string Cep { get; set; }
        private string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public int Ddd { get; set; }
        public int Siafi { get; set; }
        public Endereco(string cep, string logradouro, string complemento, string bairro, string localidade, string uf, string ibge, string gia, int ddd, int siafi ){
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
            return $"[CEP: {Cep} \nLogradouro: {Logradouro} \nComplemento: {Complemento}\nBairro: {Bairro}\nLocalidade: {Localidade}\nUF: {Uf}\n IBGE: {Ibge}\nGia: {Gia}\nDDD: {Ddd}\nSiafi: {Siafi}].";
        }
    }
}