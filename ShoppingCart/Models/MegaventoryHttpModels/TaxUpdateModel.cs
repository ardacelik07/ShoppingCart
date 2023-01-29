namespace ShoppingCart.Models.MegaventoryHttpModels
{
    public class TaxUpdateModel<T> : MegaventoryBaseHttpModel<T> where T : class
    {
        public T mvTax { get; set; }

        public string mvRecordAction { get; set; }

        public TaxUpdateModel(T mvTax, string mvRecordAction) : base("a4ed21f213aa1ab2@m138534")
        {
            this.mvTax = mvTax;
            this.mvRecordAction = mvRecordAction;
        }
    }
}
