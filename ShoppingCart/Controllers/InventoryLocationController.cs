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
    public class InventoryLocationController : ControllerBase
    {
        private readonly IClient<IMegaventoryModel> _client;
        private IMegaventoryModel model;

        public InventoryLocationController(IClient<IMegaventoryModel> client)
        {
            _client = client;
        }

        [HttpPost]
        [Route("CreateInventoryLocation")]
        public async Task<IActionResult> CreateInventoryLocation([FromBody] InventoryLocationDto InventoryLocationDto)
        {

            try
            {
                var newInventoryLocation = new mvInventoryLocation()
                {
                    InventoryLocationAbbreviation = InventoryLocationDto.Abbreviation,
                    InventoryLocationName = InventoryLocationDto.Name,
                    InventoryLocationAddress = InventoryLocationDto.Address,
                   


                };
                model = new InventoryLocationUpdateModell<mvInventoryLocation>(newInventoryLocation, "Insert");

                await _client.Insert(model, "/InventoryLocation/InventoryLocationUpdate");


                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }




        }
    }
}

