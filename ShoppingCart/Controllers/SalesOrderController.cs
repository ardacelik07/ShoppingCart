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
    public class SalesOrderController : ControllerBase
    {
        private readonly IClient<IMegaventoryModel> _client;
        private IMegaventoryModel model;

        public SalesOrderController(IClient<IMegaventoryModel> client)
        {
            _client = client;
        }

        [HttpPost]
        [Route("CreateSalesOrder")]
        public async Task<IActionResult> CreateSalesOrder([FromBody] SalesOrderDto SalesOrder)
        {

            try
            {
                var newSalesOrder = new mvSalesOrder()
                {
                    SalesOrderClientID = SalesOrder.SalesOrderClientID,
                    SalesOrderTypeId= SalesOrder.SalesOrderTypeId,
                    SalesOrderDetails = new SalesOrderDetail(SalesOrder.SalesOrderRowDiscountID, SalesOrder.SalesOrderRowProductID, SalesOrder.SalesOrderRowTaxID,SalesOrder.SalesOrderRowProductSKU,SalesOrder.SalesOrderRowQuantity),
                    

                         SalesOrderStatus= SalesOrder.SalesOrderStatus,
   
                    SalesOrderInventoryLocationID = SalesOrder.SalesOrderInventoryLocationID,
                  


                };
                model = new SalesOrderUpdateModel<mvSalesOrder>(newSalesOrder, "Insert");

                await _client.Insert(model, "/SalesOrder/SalesOrderUpdate");


                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }




        }
    }
}

