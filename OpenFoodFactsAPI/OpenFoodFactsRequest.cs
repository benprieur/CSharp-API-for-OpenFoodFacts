using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;

namespace OpenFoodFactsAPI
{
    public class OpenFoodFactsRequest
    {
        // _MINUS_ stores the character "-" used in EnumerationFields.
        const string _MINUS_ = "-";
        const string _HTTP_ = "http://";
        const string _OFF_ = ".openfoodfacts.org";
        const string _JSON_ = ".json";

        public EnumerationCountries Country;
        public EnumerationLanguages Language;

        public Dictionary<string, string> Criteria;

        /// <summary>
        /// Constructor
        /// </summary>
        public OpenFoodFactsRequest()
        {
            Criteria = new Dictionary<string, string>();
            Country = EnumerationCountries.world;
            Language = EnumerationLanguages.en;
        }

        /// <summary>
        /// ToURL
        /// </summary>
        /// <returns></returns>
        private string ToURL()
        {
            string reqURL = _HTTP_;

            reqURL += Country;
            reqURL += _MINUS_;
            reqURL += Language;

            reqURL += _OFF_;

            foreach (var item in Criteria)
            {
                string parameter = item.Key.Replace(_MINUS_, "-");
                reqURL += "/" + parameter + "/" + item.Value;
            }
            reqURL += _JSON_;

            return reqURL;
        }

        /// <summary>
        /// Add a criteria
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="value"></param>
        public void SetValue(string parameter, string value)
        {
            Criteria.Add(parameter, value);
        }

        /// <summary>
        /// Run
        /// </summary>
        /// <returns></returns>
        public List<Product> Run()
        {
            string sURL = this.ToURL();

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);
            wrGETURL.ContentType = "application/json";
            wrGETURL.Proxy = null;

            string stringJson = "";
            try
            {
                using (HttpWebResponse response = ((HttpWebResponse)wrGETURL.GetResponse()))
                {
                    StreamReader objReader = new StreamReader(response.GetResponseStream());
                    stringJson = objReader.ReadToEnd();
                }

                JObject jproducts = JsonConvert.DeserializeObject<JObject>(stringJson);

                List<Product> products = new List<Product>();
                foreach (JToken jtoken in jproducts["products"])
                {
                    Product product = jtoken.ToObject<Product>();
                    products.Add(product);
                }
                return products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ParseJson
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        private T ParseJson<T>(string json)
        {
            try
            {
                if (!String.IsNullOrEmpty(json))
                {
                    return JsonConvert.DeserializeObject<T>(json);
                }
                else
                {
                    return default(T);
                }
            }
            catch (Exception e)
            {
                string message = e.Message.ToString();
                return default(T);
            }
        }
    }
}