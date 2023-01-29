namespace ShoppingCart.Models.MegaventoryHttpModels
{
    public class DiscountUpdateModel<T> : MegaventoryBaseHttpModel<T> where T : class
    {
        public T mvDiscount { get; set; }

        public string mvRecordAction { get; set; }

        public DiscountUpdateModel(T mvDiscount, string mvRecordAction) : base("a4ed21f213aa1ab2@m138534")
        {
            this.mvDiscount = mvDiscount;
            this.mvRecordAction = mvRecordAction;
        }
    }
}
