using prueba.Repository;
using System.Net.Http;
using prueba.Model;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace prueba.Repository
{
    public class Conversor : IConversor
    {
        public double GetConversor(double valor)
        {
            try
            {
                var client = new RestClient(String.Format("https://api.coinbase.com/"));
                var request = new RestRequest("/v2/exchange-rates?currency=USD", Method.Get);
                var response = client.Execute(request);
                ConversionD conversor = new ConversionD();
                dynamic serializeJsonResponse = JsonConvert.DeserializeObject(response.Content.ToString());
                conversor.rates = serializeJsonResponse.data.rates;
                string current = conversor.rates["COP"].Value<string>();
                int val;
                bool result = int.TryParse(current, out val);
                double resultado = Convert.ToDouble(current) * valor;
                return (resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
