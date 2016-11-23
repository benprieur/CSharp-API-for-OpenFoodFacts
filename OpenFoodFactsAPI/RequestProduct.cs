using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;

namespace OpenFoodFactsAPI
{
    public class RequestProduct
    {
        public const string PREFIX_URL = "api/v0/product/";
        public const string SLASH = "/";
        public const string PRODUCT_TAG = "product";
        public const string PRODUCTS_TAG = "products";

        /// <summary>
        /// get_product
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public string get_product(string barcode)
        {
            return Utils.fetch(PREFIX_URL + barcode);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="jtoken"></param>
        /// <returns></returns>
        public Product Deserialize(JToken jtoken)
        {
            Product product = new Product();

            // creator
            product.Creator = (string)jtoken["creator"];

            // image_thumb_url
            product.Image_thumb_url = (string)jtoken["image_thumb_url"];

            // informers_tags
            product.Informers_tags = string.Join(", ", jtoken["informers_tags"].Values());

            return product;
        }

        /// <summary>
        /// get_product_deserialize
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public Product get_product_deserialize(string barcode)
        {
            string json = get_product(barcode);
            var jObject = JObject.Parse(json);
            JToken jtoken = jObject[PRODUCT_TAG];
            return Deserialize(jtoken);
        }

        /// <summary>
        /// get_by_facets
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public string get_by_facets(Dictionary<string, string> query)
        {
            //Return products for a set of facets.
            string path = "";
            foreach (string key in query.Keys)
            {
                if (path.Length > 0)
                {
                    if (path[path.Length - 1].ToString() != SLASH)
                    {
                        path += SLASH;
                    }
                }
                path += key + SLASH + query[key];
            }
            return Utils.fetch(path);
        }

        /// <summary>
        /// get_by_facets_deserialize
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public List<Product> get_by_facets_deserialize(Dictionary<string, string> query)
        {
            string json = get_by_facets(query);
            var jObject = JObject.Parse(json);
            JToken jtokens = jObject[PRODUCTS_TAG];

            List<Product> products = new List<Product>();
            foreach(JToken jtoken in jtokens)
            {
                Product product = Deserialize(jtoken);
                products.Add(product);   
            }

            return products;
        }
        
        // Get all available additives.
        public string get_additives()
        {
            return Utils.fetch(Facets.additives.ToString());
        }

        // Get all available allergens.
        public string get_allergens()
        {
            return Utils.fetch(Facets.allergens.ToString());
        }

        // Get all available brands.
        public string get_brands()
        {
            return Utils.fetch(Facets.brands.ToString());
        }

        // Get all available categories.
        public string get_categories()
        {
            return Utils.fetch(Facets.categories.ToString());
        }

        // Get all available countries.
        public string get_countries()
        {
            return Utils.fetch(Facets.countries.ToString());
        }

        // Get all available entry_dates.
        public string get_entry_dates()
        {
            return Utils.fetch(Facets.entry_dates.ToString());
        }

        // Get all available ingredients.
        public string get_ingredients()
        {
            return Utils.fetch(Facets.ingredients.ToString());
        }

        // Get all available languages.
        public string get_languages()
        {
            return Utils.fetch(Facets.languages.ToString());
        }

        // Get all available packagings.
        public string get_packagings()
        {
            return Utils.fetch(Facets.packagings.ToString());
        }

        // Get all available packagings.
        public string get_packager_codes()
        {
            return Utils.fetch(Facets.packager_code.ToString());
        }

        // Get all available purchase_places.
        public string get_purchase_places()
        {
            return Utils.fetch(Facets.purchase_places.ToString());
        }

        // Get all available stores.
        public string get_purchase_stores()
        {
            return Utils.fetch(Facets.stores.ToString());
        }

        // Get all available trace types.
        public string get_traces()
        {
            return Utils.fetch(Facets.traces.ToString());
        }

        // Get all available states.
        public string get_states()
        {
            return Utils.fetch(Facets.states.ToString());
        }
    }
}