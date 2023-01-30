namespace ShoppingCart.Models
{
    public class SalesOrderDetail
    {
        public SalesOrderDetail(int salesOrderRowProductID, int salesOrderRowDiscountID, int salesOrderRowTaxID, string salesOrderRowProductSKU, double salesOrderRowQuantity)
        {
            SalesOrderRowProductID = salesOrderRowProductID;
            SalesOrderRowDiscountID = salesOrderRowDiscountID;
            SalesOrderRowTaxID = salesOrderRowTaxID;
            SalesOrderRowProductSKU = salesOrderRowProductSKU;
            SalesOrderRowQuantity = salesOrderRowQuantity;
        }

        public int SalesOrderRowProductID { get; set; }

        public int SalesOrderRowDiscountID { get; set; }

        public int SalesOrderRowTaxID { get; set; }

        public string SalesOrderRowProductSKU { get; set; }

        public double SalesOrderRowQuantity { get; set; }   
    }
}
