using ClientSide.ViewBindingModels;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientSide.RequestServices
{
    public class AuthService : Service
    {
        public async Task<HttpResponseMessage> Register(string username, string email, string password)
        {
            var user = new User()
            {
                Username = username,
                Password = password,
                Email = email
            };
            StringContent data = ParseToJson(user);
            HttpResponseMessage response = await this.Client.PostAsync(this.BaseUrl + "auth/register", data);

            return response;

        }

        public async Task<CurrentUserBindingModel> Login(string username , string password)
        {
            var user = new User()
            {
                Username = username,
                Password = password
            };
            StringContent data = ParseToJson(user);
            HttpResponseMessage response = await this.Client.PostAsync(this.BaseUrl + "auth/login", data);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<CurrentUserBindingModel>().ConfigureAwait(false);
                
            }

            return null;

        }

        
    }
}
