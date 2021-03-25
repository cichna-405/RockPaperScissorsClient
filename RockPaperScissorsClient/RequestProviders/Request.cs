using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsClient.RequestProviders
{
    class Request
    {
        public static string Send(RequestBodyJson json, string url = "http://localhost:8000/status")
        {
            var data = new StringContent(JsonConvert.SerializeObject(json), Encoding.UTF8, "application/json");
            var client = new HttpClient();

            var response = Task.Run(async () => await client.PostAsync(url, data)).Result;
            string result = response.Content.ReadAsStringAsync().Result;

            return result;
        }

        public static string Send(string json, string url = "http://localhost:8000/status")
        {
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient();

            var response = Task.Run(async () => await client.PostAsync(url, data)).Result;
            string result = response.Content.ReadAsStringAsync().Result;

            return result;
        }

        public static string Login(string username, string password)
        {
            var credentials = new
            {
                username = username,
                password = password
            };
            dynamic response = JsonConvert.DeserializeObject(Send(JsonConvert.SerializeObject(credentials), "http://localhost:8000/login"));
            
            return response.token;
        }
    }
}
