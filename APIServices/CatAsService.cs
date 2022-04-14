using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace PetsAsServices.APIServices
{
    public class CatAsService
    {
        public CatModel GetCaracteristicasPorID(string Id)
        {
            var client = new RestClient("https://api.thecatapi.com/v1/breeds/search?");
            client.AddDefaultParameter("q", Id);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<CatModel> resultados = JsonConvert.DeserializeObject<List<CatModel>>(response.Content.ToString());
                return resultados[0];
            }
            else
                return null;
        }

        public List<CatModel> GetCaracteristicas()
        {
            var client = new RestClient("https://api.thecatapi.com/v1/breeds");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<CatModel> resultados = JsonConvert.DeserializeObject<List<CatModel>>(response.Content.ToString());
                
                return resultados;
            }
            else
                return null;
        }

        public string GetImagePorId(string Id)
        {
            var client = new RestClient($"https://api.thecatapi.com/v1/images/{Id}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                CatImageModel resultado = JsonConvert.DeserializeObject<CatImageModel>(response.Content.ToString());

                return resultado.url;
            }
            else
                return null;

        }
    }
}
