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
    public class TaxController : ControllerBase
    {
        private readonly IClient<IMegaventoryModel> _client;
        private IMegaventoryModel model;

        public TaxController(IClient<IMegaventoryModel> client)
        {
            _client = client;
        }

        [HttpPost]
        [Route("CreateTax")]
        public async Task<IActionResult> CreateTax([FromBody] TaxDto tax)
        {

            try
            {
                var newtax = new mvTax()
                {
                    TaxName = tax.TaxName,
                    TaxDescription = tax.TaxDescription,
                    TaxValue = tax.TaxValue,
                   


                };
                model = new TaxUpdateModel<mvTax>(newtax, "Insert");

                await _client.Insert(model, "/Tax/TaxUpdate");


                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }




        }
    }
}

