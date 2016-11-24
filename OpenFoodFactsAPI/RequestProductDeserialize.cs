using Newtonsoft.Json.Linq;
using System;
using System.Reflection;

namespace OpenFoodFactsAPI
{
    public enum DesValue
    {
        product_name,
        id,
        creator,
        image_thumb_url,
        informers_tags,
        brands_tags,
        ingredients_text
    };

    public partial class RequestProduct
    {
        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="jtoken"></param>
        /// <returns></returns>
        public Product Deserialize(JToken jtoken)
        {
            Product product = new Product();

            var enumValues = Enum.GetValues(typeof(DesValue));
            foreach (var des in enumValues)
            {
                try
                {
                    string desValue = des.ToString();
                    string result = "";

                    // Here we get the property to set.
                    /* string propertyName = desValue[0].ToString().ToUpper() +
                                          desValue.Substring(1); */

                    PropertyInfo property = typeof(Product).GetProperty(desValue);

                    // Here we get the value to set.
                    // Join
                    if (desValue.IndexOf("_tags") > -1)
                    {
                        result = string.Join(", ", jtoken[desValue].Values());
                    }
                    // Simple
                    else
                    {
                        result = (string)jtoken[desValue];
                    }

                    // Here we set the value.
                    try
                    {
                        property.SetValue(product, result);
                    }
                    catch
                    {
                        property.SetValue(product, "");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message.ToString());
                }
            }
            return product;
        }
    }
}
