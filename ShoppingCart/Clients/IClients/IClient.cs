using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShoppingCart.Clients.IClients
{
    public interface IClient<T> where T : class
    {

     

         Task<bool> Insert(T t,string uri);

       
    }
}
