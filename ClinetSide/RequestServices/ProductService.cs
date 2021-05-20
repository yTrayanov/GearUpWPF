using ClientSide.ViewBindingModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientSide.RequestServices
{
    public class ProductService : Service
    {
        public async Task<HttpResponseMessage> CreateProduct(string productName , string productImageUrl , decimal productPrice)
        {
            Product product = new Product()
            {
                Name = productName,
                Price = productPrice,
                Image = productImageUrl
            };

            var data = ParseToJson(product);

            var response = await Client.PostAsync(BaseUrl + "product/create", data);

            return response;
        }
    }
}
