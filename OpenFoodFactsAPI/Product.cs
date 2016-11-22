using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;

namespace OpenFoodFactsAPI
{
    public class Product
    {
        public const string PRODUCT_TAG = "product";
        public const string PRODUCTS_TAG = "products";
        public const string PREFIX_URL = "api/v0/product/";

        /// <summary>
        /// get_product
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public string get_product(string barcode)
        {
            return Utils.fetch(PREFIX_URL + barcode);
        }
    }
}