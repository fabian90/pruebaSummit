using Newtonsoft.Json.Linq;
using prueba.Model;
namespace prueba.Repository
{
    public interface IDiccionario
    {
        JArray GetMeanings(string palabra);

    }
}
