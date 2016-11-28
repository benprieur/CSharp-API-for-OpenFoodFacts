using OpenFoodFactsAPI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
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

        // Combo choices
        List<string> m_comboFacets;

        // First criteria value
        ObservableCollection<Tags> m_tags1;
        Tags m_tag1;

        // Second criteria value
        ObservableCollection<Tags> m_tags2;
        Tags m_tag2;

        bool m_isActive;

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
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
            InitializeComponent();

            m_isActive = true;

            m_off = new RequestProduct();
            ComboFacets = Enum.GetNames(typeof(Facets)).ToList();
            Products = new ObservableCollection<Product>();
            this.DataContext = this;
        }

        /// <summary>
        /// get_product_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void get_product_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                Product product = m_off.get_product_deserialize(Barcode.Text);
                Products.Clear();
                Products.Add(product);

                Page = m_off.page;
                Page_size = m_off.page_size;
                Count = m_off.count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// get_by_facets_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void get_by_facets_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, string> query = new Dictionary<string, string>();

            // Tag1
            if (m_tag1 != null)
            {
                string value1 = Combo1.SelectedValue.ToString();
                Facets fs = (Facets)Enum.Parse(typeof(Facets), value1, true);
                Facet f = m_off.FacetConvert(fs);
                query.Add(f.ToString(), m_tag1.name);
            }

            // Tag2
            if (m_tag2 != null)
            {
                string value2 = Combo2.SelectedValue.ToString();
                Facets fs = (Facets)Enum.Parse(typeof(Facets), value2, true);
                Facet f = m_off.FacetConvert(fs);
                query.Add(f.ToString(), m_tag2.name);
            }

            // Page
            m_off.page = Page;

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
        /// Tags1 (binding)
        /// </summary>
        public ObservableCollection<Tags> Tags1
        {
            get
            {
                return m_tags1;
            }
            set
            {
                m_tags1 = value;
                OnPropertyChanged("Tags1");
            }
        }

        /// <summary>
        /// Tag1 (binding)
        /// </summary>
        public Tags Tag1
        {
            get
            {
                return m_tag1;
            }
            set
            {
                m_tag1 = value;
                OnPropertyChanged("Tag1");
            }
        }

        /// <summary>
        /// Tags2 (binding)
        /// </summary>
        public ObservableCollection<Tags> Tags2
        {
            get
            {
                return m_tags2;
            }
            set
            {
                m_tags2 = value;
                OnPropertyChanged("Tags2");
            }
        }

        /// <summary>
        /// Tag1 (binding)
        /// </summary>
        public Tags Tag2
        {
            get
            {
                return m_tag2;
            }
            set
            {
                m_tag2 = value;
                OnPropertyChanged("Tag2");
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

        /// <summary>
        /// ComboFacets (binding)
        /// </summary>
        public List<string> ComboFacets
        {
            get
            {
                return m_comboFacets;
            }
            set
            {
                m_comboFacets = value;
                OnPropertyChanged("ComboFacets");
            }
        }

        /// <summary>
        /// IsActive (binding)
        /// </summary>
        public bool IsWindowActive
        {
            get
            {
                return m_isActive;
            }
            set
            {
                m_isActive = value;
                OnPropertyChanged("IsWindowActive");
            }
        }

        /// <summary>
        /// EventMgt_Combo1Selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void EventMgt_Combo1Selection(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selection = (string)Combo1.SelectedValue;

            // async call
            IsWindowActive = false;
            ObservableCollection<Tags> result = await Task.Run(() =>
            {
                return m_off.get_data_deserialize(selection);
            });
            Tags1 = result;
            autoCompleteBox1.Text = "";
            IsWindowActive = true;
        }

        /// <summary>
        /// EventMgt_Combo2Selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void EventMgt_Combo2Selection(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selection = (string)Combo2.SelectedValue;

            // async call
            IsWindowActive = false;
            ObservableCollection<Tags> result = await Task.Run(() =>
            {
                return m_off.get_data_deserialize(selection);
            });
            Tags2 = result;
            autoCompleteBox2.Text = "";
            IsWindowActive = true;
        }
    }
}