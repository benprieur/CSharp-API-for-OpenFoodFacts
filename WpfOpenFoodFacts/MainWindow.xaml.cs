using OpenFoodFactsAPI;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;

namespace WpfOpenFoodFacts
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFoodFactsRequest off = new OpenFoodFactsRequest();
            off.SetValue(EnumerationTags.informer.ToString(), "agamitsudo");
            off.SetValue(EnumerationTags.brand.ToString(), "Boucheries André");

            List<Product> response = off.Run();
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("ItemCollectionViewSource"));
            itemCollectionViewSource.Source = response;
        }
    }
}
