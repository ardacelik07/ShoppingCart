namespace ShoppingCart.Models
{
    public class mvSalesOrder
    {
      
        public int SalesOrderClientID { get; set; }

        public SalesOrderDetail SalesOrderDetails { get; set; }
        public int SalesOrderInventoryLocationID { get; set; }
    }
}
