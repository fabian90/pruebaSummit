using prueba.Repository;
using prueba.Model;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using System.Drawing;

namespace prueba.Repository
{
    public class Diccionario : IDiccionario
    {
        public JArray GetMeanings(string palabra)
        {
            try
            {
       
                var client = new RestClient(String.Format("https://api.dictionaryapi.dev/"));
                var request = new RestRequest(string.Format("/api/v2/entries/en/{0}",palabra), Method.Get);
                var response = client.Execute(request);
               List<Dictionary> _meanings = new List<Dictionary>();
                dynamic serializeJsonResponse = JsonConvert.DeserializeObject(response.Content.ToString());
                //var prueba= JsonConvert.DeserializeObject<Dictionary> (Convert.ToString(serializeJsonResponse[0].meanings));
                JArray resultado = serializeJsonResponse[0].meanings[0].definitions;
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
