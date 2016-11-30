using OpenFoodFactsAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace WpfOpenFoodFacts
{
    /// <summary>
    /// Logique d'interaction pour ProductView.xaml
    /// </summary>
    public partial class ProductView : Window
    {
        public Product Product { get; set;}

        public ProductView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var properties = typeof(Product).GetProperties();

            foreach (var prop in properties)
            {
                string propName = prop.Name;
                PropertyInfo property = typeof(Product).GetProperty(propName);

                if (prop.PropertyType == typeof(string))
                {
                    object val = property.GetValue(Product);
                    string result = (string)val;

                    TextBlock tb = new TextBlock();
                    tb.FontWeight = FontWeights.Bold;
                    tb.Text = propName + ": ";
                    wp1.Children.Add(tb);

                    TextBox tbVal = new TextBox();
                    tbVal.TextWrapping = TextWrapping.Wrap;
                    tbVal.MaxWidth = 250;
                    tbVal.Text = result;
                    wp1.Children.Add(tbVal);
                }
                else if (prop.PropertyType == typeof(int))
                {
                    object val = property.GetValue(Product);
                    string result = val.ToString();

                    TextBlock tb = new TextBlock();
                    tb.FontWeight = FontWeights.Bold;
                    tb.Text = propName + ": ";
                    wp2.Children.Add(tb);

                    TextBox tbVal = new TextBox();
                    tbVal.TextWrapping = TextWrapping.Wrap;
                    tbVal.MaxWidth = 250;
                    tbVal.Text = result;
                    wp2.Children.Add(tbVal);
                }
                else if (prop.PropertyType == typeof(int))
                {
                    object val = property.GetValue(Product);
                    string result = val.ToString();

                    TextBlock tb = new TextBlock();
                    tb.FontWeight = FontWeights.Bold;
                    tb.Text = propName + ": ";
                    wp2.Children.Add(tb);

                    TextBox tbVal = new TextBox();
                    tbVal.TextWrapping = TextWrapping.Wrap;
                    tbVal.MaxWidth = 250;
                    tbVal.Text = result;
                    wp2.Children.Add(tbVal);
                }
                else if (prop.PropertyType == typeof(List<string>))
                {
                    List<string> val = (List<string>)property.GetValue(Product);
                    string result = string.Join(",", val.ToArray());

                    TextBlock tb = new TextBlock();
                    tb.FontWeight = FontWeights.Bold;
                    tb.Text = propName + ": ";
                    wp3.Children.Add(tb);

                    TextBox tbVal = new TextBox();
                    tbVal.TextWrapping = TextWrapping.Wrap;
                    tbVal.MaxWidth = 250;
                    tbVal.Text = result;
                    wp3.Children.Add(tbVal);
                }
                else if (prop.PropertyType == typeof(NutrientLevels))
                {
                    NutrientLevels nutrientLevels = (NutrientLevels)property.GetValue(Product);
                    var propertiesNL = typeof(NutrientLevels).GetProperties();
                    foreach (var propNL in propertiesNL)
                    {
                        TextBlock tb = new TextBlock();
                        tb.FontWeight = FontWeights.Bold;
                        tb.Text = propNL.Name + ": ";
                        wp4.Children.Add(tb);

                        var val = propNL.GetValue(nutrientLevels);
                        string result = (string)val;
                        TextBox tbVal = new TextBox();
                        tbVal.TextWrapping = TextWrapping.Wrap;
                        tbVal.MaxWidth = 250;
                        tbVal.Text = result;
                        wp4.Children.Add(tbVal);
                    }
                }
                else if (prop.PropertyType == typeof(Nutriments))
                {
                    Nutriments nutrientLevels = (Nutriments)property.GetValue(Product);
                    var propertiesNL = typeof(Nutriments).GetProperties();
                    foreach (var propNL in propertiesNL)
                    {
                        TextBlock tb = new TextBlock();
                        tb.FontWeight = FontWeights.Bold;
                        tb.Text = propNL.Name + ": ";
                        wp5.Children.Add(tb);

                        var val = propNL.GetValue(nutrientLevels);
                        string result = (string)val;
                        TextBox tbVal = new TextBox();
                        tbVal.TextWrapping = TextWrapping.Wrap;
                        tbVal.MaxWidth = 250;
                        tbVal.Text = result;
                        wp5.Children.Add(tbVal);
                    }
                }

            }
        }
    }
}
