using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace ClientSide.RequestServices
{
    public class Service
    {
        protected JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };


        protected readonly string BaseUrl = "http://localhost:5000/";

        protected readonly HttpClient Client = new HttpClient();


        protected StringContent ParseToJson(object obj)
        {
            var json = JsonSerializer.Serialize(obj, this.JsonOptions);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            return data;
        }
    }
}
