using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Clients.IClients;
using ShoppingCart.Models.Dtos;
using ShoppingCart.Models.MegaventoryHttpModels;
using ShoppingCart.Models;
using System.Threading.Tasks;
using System;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierClientController : ControllerBase
    {
        private readonly IClient<IMegaventoryModel> _client;
        private IMegaventoryModel model;

        public SupplierClientController(IClient<IMegaventoryModel> client)
        {
            _client = client;
        }

        [HttpPost]
        [Route("CreateSupplierClient")]
        public async Task<IActionResult> CreateSupplierClient([FromBody] SupplierClientDto SupplierClient)
        {

            try
            {
                var supplierClient = new mvSupplierClient()
                {
                    SupplierClientId = SupplierClient.SupplierClientId,
                    SupplierClientName = SupplierClient.SupplierClientName,
                    SupplierClientPhone1 = SupplierClient.SupplierClientPhone1,
                    SupplierClientShippingAddress1 = SupplierClient.SupplierClientShippingAddress1,
                    SupplierClientIM = SupplierClient.SupplierClientIM


                };
                model = new SupplierClientUpdateModel<mvSupplierClient>(supplierClient, "Insert");

                await _client.Insert(model, "/SupplierClient/SupplierClientUpdate");


                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }




        }
    }
}

