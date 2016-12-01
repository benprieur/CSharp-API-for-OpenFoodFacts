using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace OpenFoodFactsAPI
{
    public partial class ProductAPI
    {
        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="jtoken"></param>
        /// <returns></returns>
        public Product Deserialize(JToken jtoken)
        {
            Product product = new Product();

            var properties = typeof(Product).GetProperties();
            foreach (var prop in properties)
            {
                try
                {
                    string propName = prop.Name;
                    PropertyInfo property = typeof(Product).GetProperty(propName);

                    //////////////////////////////////////////////
                    //
                    // "_tags" => List<string>
                    //
                    //////////////////////////////////////////////

                    if (prop.PropertyType == typeof(List<string>))
                    {
                        try
                        {
                            List<string> result = new List<string>();
                            foreach (string elt in jtoken[propName].Values())
                            {
                                result.Add(elt);
                            }
                            property.SetValue(product, result);
                        }
                        catch (Exception ex)
                        {
                            string message = ex.Message.ToString();
                            property.SetValue(product, null);
                        }
                    }

                    //////////////////////////////////////////////
                    //
                    // "_n" => integer
                    //
                    //////////////////////////////////////////////

                    else if (prop.PropertyType == typeof(int))
                    {
                        try
                        {
                            int result = int.Parse(jtoken[propName].ToString());
                            property.SetValue(product, result);
                        }
                        catch (Exception ex)
                        {
                            string message = ex.Message.ToString();
                            property.SetValue(product, 0);
                        }
                    }

                    //////////////////////////////////////////////
                    //
                    // Nutriments
                    //
                    //////////////////////////////////////////////

                    else if (prop.PropertyType == typeof(Nutriments))
                    {
                        try
                        {
                            Nutriments result = JsonConvert.DeserializeObject<Nutriments>(jtoken[propName].ToString());
                            property.SetValue(product, result);
                        }
                        catch (Exception ex)
                        {
                            string message = ex.Message.ToString();
                            property.SetValue(product, null);
                        }
                    }

                    //////////////////////////////////////////////
                    //
                    // NutrientLevels
                    //
                    //////////////////////////////////////////////

                    else if (prop.PropertyType == typeof(NutrientLevels))
                    {
                        try
                        {
                            NutrientLevels result = JsonConvert.DeserializeObject<NutrientLevels>(jtoken[propName].ToString());
                            property.SetValue(product, result);
                        }
                        catch (Exception ex)
                        {
                            string message = ex.Message.ToString();
                            property.SetValue(product, null);
                        }
                    }

                    //////////////////////////////////////////////
                    //
                    // List<Ingredient>
                    //
                    //////////////////////////////////////////////

                    else if (prop.PropertyType == typeof(List<Ingredient>))
                    {
                        try
                        {
                            List<Ingredient> result = JsonConvert.DeserializeObject<List<Ingredient>>(jtoken[propName].ToString());
                            property.SetValue(product, result);
                        }
                        catch (Exception ex)
                        {
                            string message = ex.Message.ToString();
                            property.SetValue(product, null);
                        }
                    }

                    //////////////////////////////////////////////
                    //
                    // General case
                    //
                    //////////////////////////////////////////////

                    else if (prop.PropertyType == typeof(string))
                    {
                        try
                        {
                            string result = (string)jtoken[propName];
                            property.SetValue(product, result);
                        }
                        catch (Exception ex)
                        {
                            string message = ex.Message.ToString();
                            property.SetValue(product, "");
                        }
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
