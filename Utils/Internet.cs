using System.Net;

namespace ConsultaCEP.Utils{

    struct Internet{
        public static bool isOnline(){
            try
            {
                using (var client = new WebClient())
                //Checking if can open the web page
                using (var stream = client.OpenRead("http://info.cern.ch/hypertext/WWW/TheProject.html"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}