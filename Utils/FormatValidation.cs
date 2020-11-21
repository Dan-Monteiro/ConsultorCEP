using System;
using System.Text.RegularExpressions;

namespace ConsultaCEP.Utils{

    class FormatValidation{

        public static bool ValidaFormatoCep(string cep){
            
           Regex regex = new Regex("[0-9]{5}-[0-9]{3}");

           return regex.IsMatch(cep);
        }

        public static bool ValidaCep(string cep){
            return cep == "00000-000";
        }
    }
}