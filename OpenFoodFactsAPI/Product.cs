using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFoodFactsAPI
{
    public class NutrientLevels
    {
        public string sugars { get; set; }
        public string salt { get; set; }
        public string fat { get; set; }
        public string saturated_fat { get; set; }
    }

    public class Ingredient
    {
        public string text { get; set; }
        public string id { get; set; }
        public int rank { get; set; }
        public string percent { get; set; }
    }

    public class Nutriments
    {
        public string salt_value { get; set; }
        public string sodium_unit { get; set; }
        public string energy_value { get; set; }
        public string nutrition_score_fr { get; set; }
        public string carbohydrates_value { get; set; }
        public double saturated_fat_serving { get; set; }
        public double fat_serving { get; set; }
        public string fat_value { get; set; }
        public string proteins_unit { get; set; }
        public double sodium_100g { get; set; }
        public string saturated_fat_unit { get; set; }
        public string energy_serving { get; set; }
        public string sodium_value { get; set; }
        public double proteins_serving { get; set; }
        public string nutrition_score_uk { get; set; }
        public double saturated_fat { get; set; }
        public string proteins_value { get; set; }
        public double sodium_serving { get; set; }
        public double salt_serving { get; set; }
        public double sugars_serving { get; set; }
        public string fat_unit { get; set; }
        public double saturated_fat_100g { get; set; }
        public double sodium { get; set; }
        public string nutrition_score_fr_100g { get; set; }
        public string sugars_unit { get; set; }
        public double proteins { get; set; }
        public double sugars_100g { get; set; }
        public double proteins_100g { get; set; }
        public double carbohydrates { get; set; }
        public string saturated_fat_value { get; set; }
        public double carbohydrates_100g { get; set; }
        public string energy_100g { get; set; }
        public double fat_100g { get; set; }
        public string energy { get; set; }
        public string carbohydrates_unit { get; set; }
        public double salt { get; set; }
        public double fat { get; set; }
        public string salt_unit { get; set; }
        public double carbohydrates_serving { get; set; }
        public string sugars_value { get; set; }
        public string energy_unit { get; set; }
        public string nutrition_score_uk_100g { get; set; }
        public double sugars { get; set; }
        public double salt_100g { get; set; }
    }
    
    public class Product : DynamicObject, INotifyPropertyChanged
    {
        // Image_thumb_url
        protected string image_thumb_url;
        public string Image_thumb_url
        {
            get
            {
                return image_thumb_url;
            }
            set
            {
                image_thumb_url = value;
                OnPropertyChanged("Image_thumb_url");
            }
        }

        // Creator
        protected string m_creator;
        public string Creator
        {
            get
            {
                return m_creator;
            }
            set
            {
                m_creator = value;
                OnPropertyChanged("Creator");
            }
        }

        // Informers_tags
        protected string informers_tags;
        public string Informers_tags
        {
            get
            {
                return informers_tags;
            }
            set
            {
                informers_tags = value;
                OnPropertyChanged("Informers_tags");
            }
        }

        // Product_name
        protected string product_name;
        public string Product_name
        {
            get
            {
                return product_name;
            }
            set
            {
                product_name = value;
                OnPropertyChanged("Product_name");
            }
        }

        // Brands
        protected string brands;
        public string Brands
        {
            get
            {
                return brands;
            }
            set
            {
                brands = value;
                OnPropertyChanged("Brands");
            }
        }

        // Id
        protected string id;
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class RootObject
    {
        public string status_verbose { get; set; }
        public string code { get; set; }
        public int status { get; set; }
        public Product product { get; set; }
    }
}
