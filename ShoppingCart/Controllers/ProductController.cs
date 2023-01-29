using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Clients.IClients;
using ShoppingCart.Models;
using System.Threading.Tasks;
using System;
using ShoppingCart.Models.Dtos;
using ShoppingCart.Models.MegaventoryHttpModels;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IClient<IMegaventoryModel> _client;
        private IMegaventoryModel model;

        public ProductController(IClient<IMegaventoryModel> client)
        {
            _client = client;
        }

        [HttpPost]
        [Route("CreateProduct")]
        public async Task<IActionResult> CreateProduct([FromBody] ProductDto product)
        {

            try
            {
                var NewProduct = new mvProduct()
                {
                    ProductSKU = product.ProductSKU,
                   ProductDescription= product.ProductDescription,
                   ProductPurchasePrice= product.ProductPurchasePrice,
                   ProductSellingPrice= product.ProductSellingPrice,


                };
                model = new ProductUpdateModel<mvProduct>(NewProduct,"Insert");

                await _client.Insert(model,"/Product/ProductUpdate");


                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }




        }
    }
}
