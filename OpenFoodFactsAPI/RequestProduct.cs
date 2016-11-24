using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace OpenFoodFactsAPI
{
    public class RequestProduct
    {
        public const string PREFIX_URL = "api/v0/product/";
        public const string SLASH = "/";
        public const string PRODUCT_TAG = "product";
        public const string PRODUCTS_TAG = "products";
        public const string TAGS = "tags";

        public int page { get; set; }
        public int page_size { get; set; }
        public int count { get; set; }

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

            // product_name
            try
            {
                product.Product_name = (string)jtoken["product_name"];
            }
            catch
            {
                product.Product_name = "";
            }
            // id
            try
            {
                product.Id = (string)jtoken["id"];
            }
            catch
            {
                product.Id = "";
            }
            // creator
            try
            {
                product.Creator = (string)jtoken["creator"];
            }
            catch
            {
                product.Creator = "";
            }
            // image_thumb_url
            try
            { 
                product.Image_thumb_url = (string)jtoken["image_thumb_url"];
            }
            catch
            {
                product.Image_thumb_url = "";
            }
            // informers_tags
            try
            {
                product.Informers_tags = string.Join(", ", jtoken["informers_tags"].Values());
            }
            catch
            {
                product.Informers_tags = "";
            }
            // brands
            try
            { 
                product.Brands = string.Join(", ", jtoken["brands_tags"].Values());
            }
            catch
            {
                product.Brands = "";
            }

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
        public ObservableCollection<Product> get_by_facets_deserialize(Dictionary<string, string> query)
        {
            string json = get_by_facets(query);

            var jObject = JObject.Parse(json);

            // page
            try
            {
                page = (int)jObject["page"];
            }
            catch
            {
                page = -1;
            }
            // page_size
            try
            {
                page_size = (int)jObject["page_size"];
            }
            catch
            {
                page = -1;
            }
            // count
            try
            {
                count = (int)jObject["count"];
            }
            catch
            {
                page = -1;
            }

            JToken jtokens = jObject[PRODUCTS_TAG];
            
            ObservableCollection<Product> products = new ObservableCollection<Product>();
            foreach(JToken jtoken in jtokens)
            {
                Product product = Deserialize(jtoken);
                products.Add(product);   
            }

            return products;
        }

        // Get all available data.
        /// <summary>
        /// get_data
        /// </summary>
        /// <param name="facet"></param>
        /// <returns></returns>
        public string get_data(Facets facet)
        {
            return Utils.fetch(facet.ToString());
        }

        // Get all data countries.
        /// <summary>
        /// get_data_deserialize
        /// </summary>
        /// <param name="facet"></param>
        /// <returns></returns>
        public ObservableCollection<Tags> get_data_deserialize(string facet)
        {
            string json = Utils.fetch(facet);

            var jObject = JObject.Parse(json);
            JToken jtokens = jObject[TAGS];

            ObservableCollection<Tags> countries = new ObservableCollection<Tags>();
            foreach (JToken jtoken in jtokens)
            {
                Tags country = JsonConvert.DeserializeObject<Tags>(jtoken.ToString());
                countries.Add(country);
            }

            return countries;
        }

        /// <summary>
        /// FacetConvert
        /// </summary>
        /// <param name="facets"></param>
        /// <returns></returns>
        public Facet FacetConvert(Facets facets)
        {
            switch (facets)
            {
                case Facets.additives:
                    return Facet.additive;
                case Facets.allergens:
                    return Facet.allergen;
                case Facets.brands:
                    return Facet.brand;
                case Facets.categories:
                    return Facet.category;
                case Facets.countries:
                    return Facet.country;
                case Facets.contributors:
                    return Facet.contributor;
                case Facets.codes:
                    return Facet.code;
                case Facets.entry_dates:
                    return Facet.entry_date;
                case Facets.ingredients:
                    return Facet.ingredient;
                case Facets.labels:
                    return Facet.label;
                case Facets.languages:
                    return Facet.language;
                case Facets.nutrition_grade:
                    return Facet.nutrition_grade;
                case Facets.packagings:
                    return Facet.packaging;
                case Facets.packager_codes:
                    return Facet.packager_code;
                case Facets.photographers:
                    return Facet.photographer;
                case Facets.informers:
                    return Facet.informer;
                case Facets.purchase_places:
                    return Facet.purchase_place;
                case Facets.states:
                    return Facet.state;
                case Facets.stores:
                    return Facet.store;
                case Facets.traces:
                    return Facet.trace;
            }
            throw new Exception("This value is not relevant: " + facets.ToString());
        }
    }
}