namespace ShoppingCart.Models.Dtos
{
    public class ProductDto
    {
        public string ProductSKU { get; set; }

        public string ProductDescription { get; set; }

        public double ProductSellingPrice { get; set; }

        public double ProductPurchasePrice { get; set; }
    }
}
