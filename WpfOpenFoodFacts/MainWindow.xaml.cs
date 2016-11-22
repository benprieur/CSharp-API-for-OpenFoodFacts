using OpenFoodFactsAPI;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Data;

namespace WpfOpenFoodFacts
{
    /// <summary>
    /// Logique dinteraction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// get_product_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void get_product_Click(object sender, RoutedEventArgs e)
        {
            Product off = new Product();
            string json = off.get_product(Barcode.Text);
        }

        /// <summary>
        /// get_by_facets_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void get_by_facets_Click(object sender, RoutedEventArgs e)
        {
            Product off = new Product();
            Dictionary<string, string> query = new Dictionary<string, string>();
            query.Add(Facets.informer.ToString(), "agamitsudo");
            query.Add(Facet.country.ToString(), "italy");
            string json = off.get_by_facets(query);
        }
    }
}
