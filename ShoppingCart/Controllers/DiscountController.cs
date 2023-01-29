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
    public class DiscountController : ControllerBase
    {
        private readonly IClient<IMegaventoryModel> _client;
        private IMegaventoryModel model;

        public DiscountController(IClient<IMegaventoryModel> client)
        {
            _client = client;
        }

        [HttpPost]
        [Route("CreateDiscount")]
        public async Task<IActionResult> CreateDiscount([FromBody] mvDiscountDto mvDiscountDto)
        {

            try
            {
                var newDiscount = new mvDiscount()
                {
                    DiscountName = mvDiscountDto.DiscountName,
                    DiscountDescription = mvDiscountDto.DiscountDescription,
                    DiscountValue = mvDiscountDto.DiscountValue,
                   


                };
                model = new DiscountUpdateModel<mvDiscount>(newDiscount, "Insert");

                await _client.Insert(model, "/Discount/DiscountUpdate");


                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }




        }
    }
}

