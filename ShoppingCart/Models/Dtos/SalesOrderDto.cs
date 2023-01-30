namespace ShoppingCart.Models.Dtos
{
    public class SalesOrderDto
    {
     
          public int SalesOrderClientID { get; set; }
     
        public int SalesOrderRowProductID { get; set; }

        public int SalesOrderRowDiscountID { get; set; }

        public int SalesOrderRowTaxID { get; set; }
        public int SalesOrderInventoryLocationID { get; set; }
        public string SalesOrderRowProductSKU { get; set; }

        public double SalesOrderRowQuantity { get; set; }

        public string SalesOrderStatus { get; set; }

        public int SalesOrderTypeId { get; set; }
    }
}
