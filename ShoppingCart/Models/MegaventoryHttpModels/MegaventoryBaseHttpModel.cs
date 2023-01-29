namespace ShoppingCart.Models.MegaventoryHttpModels
{
    public class MegaventoryBaseHttpModel<T> : IMegaventoryModel where T : class
    {
        public MegaventoryBaseHttpModel(string apikey)
        {
            this.apikey = apikey;
        }

        public string apikey  { get; set; }



    }
}
