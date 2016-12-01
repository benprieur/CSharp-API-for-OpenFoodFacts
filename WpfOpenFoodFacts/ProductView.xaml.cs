using OpenFoodFactsAPI;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfOpenFoodFacts
{
    /// <summary>
    /// Logique d'interaction pour ProductView.xaml
    /// </summary>
    public partial class ProductView : Window
    {
        public const string _URL = "_url";
        public const string TYPE_IMG = "type_img";
         
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

                ////////////////////////////////////////////
                //
                // typeof(string)
                //
                /////////////////////////////////////////////
                if (prop.PropertyType == typeof(string))
                {
                    object val = property.GetValue(Product);
                    string result = (string)val;

                    TextBlock tb = new TextBlock();
                    tb.FontWeight = FontWeights.Bold;
                    tb.TextWrapping = TextWrapping.Wrap;
                    tb.Text = propName + ": ";
                    wp1.Children.Add(tb);

                    // Type
                    string type = "";
                    if (propName.Length > _URL.Length)
                    {
                        if (propName.Substring(propName.Length - _URL.Length) == _URL)
                        {
                            type = TYPE_IMG;
                        }
                    }
                    
                    // Image
                    if (type == TYPE_IMG)
                    {
                        Image imgVal = new Image();
                        imgVal.Width = 125;
                        imgVal.Source = new BitmapImage(new Uri(result));
                        wp1.Children.Add(imgVal);
                    }
                    else
                    {
                        if (propName != "product_name")
                        {
                            TextBlock tbVal = new TextBlock();
                            tbVal.TextWrapping = TextWrapping.Wrap;
                            tbVal.MaxWidth = 250;
                            tbVal.Text = result;
                            wp1.Children.Add(tbVal);
                        }
                        else
                        {
                            TextBox tbVal = new TextBox();
                            tbVal.Foreground = Brushes.Red;
                            tbVal.BorderBrush = Brushes.Red;
                            tbVal.TextWrapping = TextWrapping.Wrap;
                            tbVal.MaxWidth = 250;
                            tbVal.Text = result;
                            wp1.Children.Add(tbVal);
                        }
                    }
                }
                ////////////////////////////////////////////
                //
                // typeof(int)
                //
                ////////////////////////////////////////////
                else if (prop.PropertyType == typeof(int))
                {
                    object val = property.GetValue(Product);
                    string result = val.ToString();

                    TextBlock tb = new TextBlock();
                    tb.FontWeight = FontWeights.Bold;
                    tb.TextWrapping = TextWrapping.Wrap;
                    tb.Text = propName + ": ";
                    wp2.Children.Add(tb);

                    TextBlock tbVal = new TextBlock();
                    tbVal.TextWrapping = TextWrapping.Wrap;
                    tbVal.MaxWidth = 250;
                    tbVal.Text = result;
                    wp2.Children.Add(tbVal);
                }
                ////////////////////////////////////////////
                //
                // typeof(List<string>)
                //
                ////////////////////////////////////////////
                else if (prop.PropertyType == typeof(List<string>))
                {
                    List<string> val = (List<string>)property.GetValue(Product);
                    string result = string.Join(",", val.ToArray());

                    TextBlock tb = new TextBlock();
                    tb.FontWeight = FontWeights.Bold;
                    tb.TextWrapping = TextWrapping.Wrap;
                    tb.Text = propName + ": ";
                    wp3.Children.Add(tb);

                    TextBlock tbVal = new TextBlock();
                    tbVal.TextWrapping = TextWrapping.Wrap;
                    tbVal.MaxWidth = 250;
                    tbVal.Text = result;
                    wp3.Children.Add(tbVal);
                }
                ////////////////////////////////////////////
                //
                // typeof(NutrientLevels)
                //
                ////////////////////////////////////////////
                else if (prop.PropertyType == typeof(NutrientLevels))
                {
                    NutrientLevels nutrientLevels = (NutrientLevels)property.GetValue(Product);
                    var propertiesNL = typeof(NutrientLevels).GetProperties();
                    foreach (var propNL in propertiesNL)
                    {
                        TextBlock tb = new TextBlock();
                        tb.FontWeight = FontWeights.Bold;
                        tb.TextWrapping = TextWrapping.Wrap;
                        tb.Text = propNL.Name + ": ";
                        wp4.Children.Add(tb);

                        var val = propNL.GetValue(nutrientLevels);
                        string result = (string)val;
                        TextBlock tbVal = new TextBlock();
                        tbVal.TextWrapping = TextWrapping.Wrap;
                        tbVal.MaxWidth = 250;
                        tbVal.Text = result;
                        wp4.Children.Add(tbVal);
                    }
                }
                ////////////////////////////////////////////
                //
                // typeof(Nutriments)
                //
                ////////////////////////////////////////////
                else if (prop.PropertyType == typeof(Nutriments))
                {
                    Nutriments nutrientLevels = (Nutriments)property.GetValue(Product);
                    var propertiesNL = typeof(Nutriments).GetProperties();
                    foreach (var propNL in propertiesNL)
                    {
                        TextBlock tb = new TextBlock();
                        tb.FontWeight = FontWeights.Bold;
                        tb.TextWrapping = TextWrapping.Wrap;
                        tb.Text = propNL.Name + ": ";
                        wp5.Children.Add(tb);

                        var val = propNL.GetValue(nutrientLevels);
                        string result = (string)val;
                        TextBlock tbVal = new TextBlock();
                        tbVal.TextWrapping = TextWrapping.Wrap;
                        tbVal.MaxWidth = 250;
                        tbVal.Text = result;
                        wp5.Children.Add(tbVal);
                    }
                }

            }
        }

        /// <summary>
        /// Save_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
