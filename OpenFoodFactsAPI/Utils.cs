using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace OpenFoodFactsAPI
{
    public class Utils
    {
        public const string API_URL = "http://world.openfoodfacts.org/";
        public const string JSON_EXTENSION = ".json";
        public const string APP_JSON = "application/json";

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string fetch(string path)
        {
            //Fetch data at a given path assuming that target match a json file and is
            //located on the OFF API.

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(API_URL + path + JSON_EXTENSION);
            wrGETURL.ContentType = APP_JSON;
            wrGETURL.Proxy = null;

            string stringJson = "";
            try
            {
                using (HttpWebResponse response = ((HttpWebResponse)wrGETURL.GetResponse()))
                {
                    StreamReader objReader = new StreamReader(response.GetResponseStream());
                    stringJson = objReader.ReadToEnd();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
            return stringJson;
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
