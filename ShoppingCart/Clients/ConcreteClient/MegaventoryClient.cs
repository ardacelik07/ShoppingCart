using Microsoft.Extensions.Configuration;
using ShoppingCart.Clients.IClients;
using System.Net.Http;
using System.Transactions;
using System.Configuration;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text;
using System.Net.Http.Headers;
using System;
using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.Json;
using System.Security.Policy;
using System.Net.Http.Formatting;
using static System.Net.Mime.MediaTypeNames;





namespace ShoppingCart.Clients.ConcreteClient
{
    public class MegaventoryClient<T> :  BaseClient, IClient<T> where T : class
    {


        
        public MegaventoryClient(IHttpClientFactory clientFactory) {


            

        }
       
        public  async Task<bool> Insert(T t,string uri)
        {
        
            
            try
            {
                var response = await client.PostAsJsonAsync("https://api.megaventory.com/v2017a" + uri, t);
              var contents = await response.Content.ReadAsStringAsync();
              System.Diagnostics.Debug.WriteLine(contents);
              return true;

            }
            catch {}
            {
                return false;
            } 


        }

      
    }
}
