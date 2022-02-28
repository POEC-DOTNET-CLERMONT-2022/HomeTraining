using System.Diagnostics;
using System.Threading.Tasks;
using Auth0.OidcClient;
using Ipme.Hometraining.Models;

namespace WPFClient.Services
{
    public class UserAuth0Service
    {
        public Auth0Client client { get; private set; }

        public UserAuth0Service()
        {
            Auth0ClientOptions clientOptions = new Auth0ClientOptions
            {
                Domain = "dev-2hpu-3au.eu.auth0.com",
                ClientId = "b4JWfGG0VDABmp4R0bK2ShZtNCnOcTLE"
            };

            client = new Auth0Client(clientOptions);
            clientOptions.PostLogoutRedirectUri = clientOptions.RedirectUri;
        }

        public async Task Login()
        {
            var loginResult = await client.LoginAsync();
            if (loginResult.IsError)
            {
                Debug.WriteLine($"An error occurred during login: {loginResult.Error}");
            }
        }

        public async Task Logout()
        {
            await client.LogoutAsync();
        }

    }
}
