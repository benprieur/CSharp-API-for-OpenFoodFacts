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

        // Meta data
        int m_page;
        int m_page_size;
        int m_count;

        ObservableCollection<Product> m_products;
        // Product m_product;
        
        ObservableCollection<Tags> m_countries;
        Tags m_country;

        ObservableCollection<Tags> m_informers;
        Tags m_informer;

        ObservableCollection<Tags> m_brands;
        Tags m_brand;

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
            Countries = m_off.get_data_deserialize(Facets.countries);
            Informers = m_off.get_data_deserialize(Facets.informers);
            Brands = m_off.get_data_deserialize(Facets.brands);

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

            Page = m_off.page;
            Page_size = m_off.page_size;
            Count = m_off.count;
        }

        /// <summary>
        /// get_by_facets_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void get_by_facets_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, string> query = new Dictionary<string, string>();

            // Country
            if (m_country != null)
            {
                query.Add(Facet.country.ToString(), m_country.name);
            }

            // Informer
            if (m_informer != null)
            {
                query.Add(Facet.informer.ToString(), m_informer.name);
            }

            // Brand
            if (m_brand != null)
            {
                query.Add(Facet.brand.ToString(), m_brand.name);
            }

            // Request
            Products = m_off.get_by_facets_deserialize(query);
            Page = m_off.page;
            Page_size = m_off.page_size;
            Count = m_off.count;
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

        /// <summary>
        /// Countries (binding)
        /// </summary>
        public ObservableCollection<Tags> Countries
        {
            get
            {
                return m_countries;
            }
            set
            {
                m_countries = value;
                OnPropertyChanged("Countries");
            }
        }

        /// <summary>
        /// Country (binding)
        /// </summary>
        public Tags Country
        {
            get
            {
                return m_country;
            }
            set
            {
                m_country = value;
                OnPropertyChanged("Country");
            }
        }

        /// <summary>
        /// Informers (binding)
        /// </summary>
        public ObservableCollection<Tags> Informers
        {
            get
            {
                return m_informers;
            }
            set
            {
                m_informers = value;
                OnPropertyChanged("Informers");
            }
        }

        /// <summary>
        /// Informer (binding)
        /// </summary>
        public Tags Informer
        {
            get
            {
                return m_informer;
            }
            set
            {
                m_informer = value;
                OnPropertyChanged("Informer");
            }
        }

        /// <summary>
        /// Brands (binding)
        /// </summary>
        public ObservableCollection<Tags> Brands
        {
            get
            {
                return m_brands;
            }
            set
            {
                m_brands = value;
                OnPropertyChanged("Brands");
            }
        }

        /// <summary>
        /// Brand (binding)
        /// </summary>
        public Tags Brand
        {
            get
            {
                return m_brand;
            }
            set
            {
                m_brand = value;
                OnPropertyChanged("Brand");
            }
        }

        /// <summary>
        /// Count (binding)
        /// </summary>
        public int Count
        {
            get
            {
                return m_count;
            }
            set
            {
                m_count = value;
                OnPropertyChanged("Count");
            }
        }

        /// <summary>
        /// Page_size (binding)
        /// </summary>
        public int Page_size
        {
            get
            {
                return m_page_size;
            }
            set
            {
                m_page_size = value;
                OnPropertyChanged("Page_size");
            }
        }

        /// <summary>
        /// Page (binding)
        /// </summary>
        public int Page
        {
            get
            {
                return m_page;
            }
            set
            {
                m_page = value;
                OnPropertyChanged("Page");
            }
        }
    }
}
