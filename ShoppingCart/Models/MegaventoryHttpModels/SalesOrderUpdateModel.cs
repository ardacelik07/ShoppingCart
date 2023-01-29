﻿namespace ShoppingCart.Models.MegaventoryHttpModels
{
    public class SalesOrderUpdateModel<T> : MegaventoryBaseHttpModel<T> where T : class
    {
        public T mvSalesOrder { get; set; }

        public string mvRecordAction { get; set; }

        public string SalesOrderStatus { get; set; }

        public SalesOrderUpdateModel(T mvSalesOrder, string mvRecordAction, string salesOrderStatus) : base("a4ed21f213aa1ab2@m138534")
        {
            this.mvSalesOrder = mvSalesOrder;
            this.mvRecordAction = mvRecordAction;
            SalesOrderStatus = salesOrderStatus;
        }
    }
}
