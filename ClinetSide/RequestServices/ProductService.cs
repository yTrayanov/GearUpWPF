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

        public async Task<HttpResponseMessage> AddProductToCart(string productId, string userId)
        {
            var obj = new { productId, userId };
            var data = ParseToJson(obj);

            return await Client.PostAsync(BaseUrl + "product/add", data).ConfigureAwait(false);
        }

        public async Task<ICollection<Product>> GetUserProducts(string userId)
        {
            var response = await Client.GetAsync(BaseUrl + "product/user/" + userId).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<ICollection<Product>>();
            }

            return null;
        }

        public async Task<HttpResponseMessage> RemoveProductFromCart(string userId , string productId)
        {
            var data = this.ParseToJson(new { userId, productId });
            return await Client.PostAsync(this.BaseUrl + "product/user/remove", data).ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> DeleteProduct(string productId)
        {
            return await this.Client.DeleteAsync(BaseUrl + "product/remove/" + productId).ConfigureAwait(false);
        }
    }
}
