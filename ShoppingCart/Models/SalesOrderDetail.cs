namespace ShoppingCart.Models
{
    public class SalesOrderDetail
    {
        public SalesOrderDetail(int salesOrderRowProductID, int salesOrderRowDiscountID, int salesOrderRowTaxID, string salesOrderRowProductSKU)
        {
            SalesOrderRowProductID = salesOrderRowProductID;
            SalesOrderRowDiscountID = salesOrderRowDiscountID;
            SalesOrderRowTaxID = salesOrderRowTaxID;
            SalesOrderRowProductSKU = salesOrderRowProductSKU;
        }

        public int SalesOrderRowProductID { get; set; }

        public int SalesOrderRowDiscountID { get; set; }

        public int SalesOrderRowTaxID { get; set; }

        public string SalesOrderRowProductSKU { get; set; }
    }
}
