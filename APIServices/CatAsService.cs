using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace PetsAsServices.APIServices
{
    public class CatAsService
    { 
        public string ApiKey = Properties.Settings.Default.ApiKey;
        public CatModel GetCaracteristicasPorID(string Id)
        {
            var client = new RestClient("https://api.thecatapi.com/v1/breeds/search?");
            client.AddDefaultParameter("q", Id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-api-key", $"{ApiKey}");
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
            request.AddHeader("x-api-key", $"{ApiKey}");
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
            request.AddHeader("x-api-key", $"{ApiKey}");
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                CatImageModel resultado = JsonConvert.DeserializeObject<CatImageModel>(response.Content.ToString());

                return resultado.url;
            }
            else
                return null;

        }

        public void FavoritarRacaPost(string idImage, string name)
        {
            var client = new RestClient("https://api.thecatapi.com/v1/favourites");
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-api-key", $"{ApiKey}");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"image_id\":\""+ idImage + "\",\"sub_id\":\""+ name +"\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }

        public List<CatFavoritesModel> GetFavorites()
        {
            var client = new RestClient("https://api.thecatapi.com/v1/favourites");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-api-key", "9b045339-3b6e-4560-94c7-74f0a63167e4");
            IRestResponse response = client.Execute(request);

            List<CatFavoritesModel> resultados =
                JsonConvert.DeserializeObject<List<CatFavoritesModel>>(response.Content.ToString());

            return resultados;
        }
    }
}
