using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;

namespace OpenFoodFactsAPI
{
    public class Product
    {
        public const string PREFIX_URL = "api/v0/product/";
        public const string SLASH = "/";

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
        /// get_product
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