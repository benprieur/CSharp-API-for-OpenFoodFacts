using OpenFoodFactsAPI;
using System.Collections.Generic;
using System.Windows;


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
            RequestProduct off = new RequestProduct();
            var obj = off.get_product_deserialize(Barcode.Text);
        }

        /// <summary>
        /// get_by_facets_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void get_by_facets_Click(object sender, RoutedEventArgs e)
        {
            RequestProduct off = new RequestProduct();
            Dictionary<string, string> query = new Dictionary<string, string>();
            query.Add(Facets.informer.ToString(), "agamitsudo");
            query.Add(Facet.country.ToString(), "italy");
            var obj = off.get_by_facets_deserialize(query);
        }
    }
}
