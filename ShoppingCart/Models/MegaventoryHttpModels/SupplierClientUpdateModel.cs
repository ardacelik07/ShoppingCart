namespace ShoppingCart.Models.MegaventoryHttpModels
{
    public class SupplierClientUpdateModel<T> : MegaventoryBaseHttpModel<T> where T : class
    {
        public T mvSupplierClient { get; set; }

        public string mvRecordAction { get; set; }

        public SupplierClientUpdateModel(T mvSupplierClient, string mvRecordAction) : base("a4ed21f213aa1ab2@m138534")
        {
            this.mvSupplierClient = mvSupplierClient;
            this.mvRecordAction = mvRecordAction;
        }
    }
}
