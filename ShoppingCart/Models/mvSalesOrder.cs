namespace ShoppingCart.Models
{
    public class mvSalesOrder
    {
      
        public int SalesOrderClientID { get; set; }

        public SalesOrderDetail SalesOrderDetails { get; set; }
        public int SalesOrderInventoryLocationID { get; set; }

        public string SalesOrderStatus { get; set; }

        public int SalesOrderTypeId { get; set; }
    }
}
