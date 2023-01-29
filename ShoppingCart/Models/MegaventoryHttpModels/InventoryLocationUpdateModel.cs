namespace ShoppingCart.Models.MegaventoryHttpModels
{
    public class InventoryLocationUpdateModell<T> : MegaventoryBaseHttpModel<T> where T : class
    {
        public T mvInventoryLocation { get; set; }

        public string mvRecordAction { get; set; }

        public InventoryLocationUpdateModell(T mvInventoryLocation, string mvRecordAction) : base("a4ed21f213aa1ab2@m138534")
        {
            this.mvInventoryLocation = mvInventoryLocation;
            this.mvRecordAction = mvRecordAction;
        }



    }
}

