using OpenFoodFactsAPI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;


namespace WpfOpenFoodFacts
{
    /// <summary>
    /// Logique dinteraction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged, IDisposable
    {
        RequestProduct m_off;
        ObservableCollection<Product> m_products;

        // Implements INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            m_off = new RequestProduct();
            m_products = new ObservableCollection<Product>();

            this.DataContext = this;
        }

        /// <summary>
        /// get_product_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void get_product_Click(object sender, RoutedEventArgs e)
        {
            Product product = m_off.get_product_deserialize(Barcode.Text);
            Products.Clear();
            Products.Add(product);
        }

        /// <summary>
        /// get_by_facets_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void get_by_facets_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, string> query = new Dictionary<string, string>();
            query.Add(Facets.informer.ToString(), "agamitsudo");
            query.Add(Facet.country.ToString(), "italy");
            List<Product> result = m_off.get_by_facets_deserialize(query);
            Products.Clear();
            foreach (Product p in result)
            {
                Products.Add(p);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Products (binding)
        /// </summary>
        public ObservableCollection<Product> Products
        {
            get
            {
                return m_products;
            }
            set
            {
                m_products = value;
                OnPropertyChanged("Products");
            }
        }


    }
}
