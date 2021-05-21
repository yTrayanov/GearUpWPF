using ClientSide.ViewBindingModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

            var response = await Client.PostAsync(BaseUrl + "product/create", data).ConfigureAwait(false);

            return response;
        }

        public async Task<ICollection<Product>> GetAllProducts()
        {
            var response = await Client.GetAsync(BaseUrl + "product/all").ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<ICollection<Product>>();
            }

            return null;
        }
    }
}
