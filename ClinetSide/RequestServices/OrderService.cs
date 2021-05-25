using ClientSide.ViewBindingModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientSide.RequestServices
{
    public class OrderService:Service
    {
        public async Task<HttpResponseMessage> CreateOrder(string address , string addictionalInfo , string productId , string userId)
        {
            var data = ParseToJson(new { address, addictionalInfo, productId });
            return await this.Client.PostAsync(BaseUrl + "order/create/" + userId, data).ConfigureAwait(false);
        }

        public async Task<ICollection<Order>> GetUserOrders(string userId)
        {
            var response = await this.Client.GetAsync(BaseUrl + "order/all/" + userId).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<ICollection<Order>>();
            }

            return null;
        }

        public async Task<Order> GetProductDetails(string productId)
        {
            var response = await this.Client.GetAsync(BaseUrl + "order/60a7c5635c0f204efc211d0a").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Order>();
            }

            return null;
        }
    }
}
