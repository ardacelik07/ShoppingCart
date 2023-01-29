using System.Net.Http;

namespace ShoppingCart.Clients.ConcreteClient
{
    public class BaseClient
    {
        public static readonly HttpClient client = new HttpClient();

       
    }
}
