using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ShoppingCart.Models.MegaventoryHttpModels
{
    public class ProductUpdateModel<T>: MegaventoryBaseHttpModel<T> where T : class
    {

      

         


        public T mvProduct { get; set; }

        public string mvRecordAction { get; set; }

        public ProductUpdateModel(T mvProduct, string mvRecordAction):base("a4ed21f213aa1ab2@m138534")
        {
            this.mvProduct = mvProduct;
            this.mvRecordAction = mvRecordAction;
        }



    }
}
