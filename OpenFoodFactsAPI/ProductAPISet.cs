using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;

namespace OpenFoodFactsAPI
{
    public partial class ProductAPI
    {
        public const string URL_SET = "http://world.openfoodfacts.org/cgi/product_jqm2.pl?";
        public const string CODE = "code";
        public const string USER_ID = "user_id";
        public const string PASSWORD = "password";
        
        public string Login { get; set;}
        public string Pwd { get; set; }
        public string Code { get; set; }
        protected Dictionary<string, string> wFacets { get; set; }

        /// <summary>
        /// clear_wfacets
        /// </summary>
        public void clear_wfacets()
        {
            if (wFacets == null)
            {
                wFacets = new Dictionary<string, string>();
            }
            else
            {
                wFacets.Clear();
            }
        }

        /// <summary>
        /// add_wfacet
        /// </summary>
        /// <param name="facet"></param>
        /// <param name="val"></param>
        public void add_wfacet(string facet, string val)
        {
            if (wFacets == null)
            {
                wFacets = new Dictionary<string, string>();
            }
            wFacets.Add(facet, val);
        }

        /// <summary>
        /// set_product
        /// </summary>
        public string set_product()
        {
            try
            { 
                string result = "";
                NameValueCollection collection = new NameValueCollection();
                collection.Add(CODE, Code);
                collection.Add(USER_ID, Login);
                collection.Add(PASSWORD, Pwd);
            
                foreach (var facet in wFacets)
                {
                  collection.Add( facet.Key , facet.Value);
                }

                using (WebClient client = new WebClient())
                {
                    byte[] response =
                    client.UploadValues(URL_SET, collection);
                    result = System.Text.Encoding.UTF8.GetString(response);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
