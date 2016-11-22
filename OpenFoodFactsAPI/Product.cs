using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFoodFactsAPI
{
    public class LanguagesCodes
    {
        public int fr { get; set; }
    }

    public class NutrientLevels
    {
        public string sugars { get; set; }
        public string salt { get; set; }
        public string fat { get; set; }
        public string __invalid_name__saturated_fat { get; set; }
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
        public string __invalid_name__nutrition_score_fr { get; set; }
        public string carbohydrates_value { get; set; }
        public double __invalid_name__saturated_fat_serving { get; set; }
        public double fat_serving { get; set; }
        public string fat_value { get; set; }
        public string proteins_unit { get; set; }
        public double sodium_100g { get; set; }
        public string __invalid_name__saturated_fat_unit { get; set; }
        public string energy_serving { get; set; }
        public string sodium_value { get; set; }
        public double proteins_serving { get; set; }
        public string __invalid_name__nutrition_score_uk { get; set; }
        public double __invalid_name__saturated_fat { get; set; }
        public string proteins_value { get; set; }
        public double sodium_serving { get; set; }
        public double salt_serving { get; set; }
        public double sugars_serving { get; set; }
        public string fat_unit { get; set; }
        public double __invalid_name__saturated_fat_100g { get; set; }
        public double sodium { get; set; }
        public string __invalid_name__nutrition_score_fr_100g { get; set; }
        public string sugars_unit { get; set; }
        public double proteins { get; set; }
        public double sugars_100g { get; set; }
        public double proteins_100g { get; set; }
        public double carbohydrates { get; set; }
        public string __invalid_name__saturated_fat_value { get; set; }
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
        public string __invalid_name__nutrition_score_uk_100g { get; set; }
        public double sugars { get; set; }
        public double salt_100g { get; set; }
    }

    public class Languages
    {
        public int __invalid_name__en_french { get; set; }
    }

    public class Product
    {
        public List<string> categories_tags { get; set; }
        public List<string> packaging_tags { get; set; }
        public List<object> countries_debug_tags { get; set; }
        public List<object> ingredients_that_may_be_from_palm_oil_tags { get; set; }
        public int ingredients_that_may_be_from_palm_oil_n { get; set; }
        public int last_image_t { get; set; }
        public List<string> purchase_places_tags { get; set; }
        public string allergens { get; set; }
        public string brands { get; set; }
        public string interface_version_modified { get; set; }
        public int additives_n { get; set; }
        public List<object> manufacturing_places_tags { get; set; }
        public string stores { get; set; }
        public List<string> _keywords { get; set; }
        public string nutrition_score_debug { get; set; }
        public string packaging { get; set; }
        public List<string> categories_next_hierarchy { get; set; }
        public List<string> debug_param_sorted_langs { get; set; }
        public List<object> emb_codes_tags { get; set; }
        public string code { get; set; }
        public int ingredients_from_palm_oil_n { get; set; }
        public List<string> languages_hierarchy { get; set; }
        public int completed_t { get; set; }
        public string image_thumb_url { get; set; }
        public List<string> brands_tags { get; set; }
        public List<object> checkers_tags { get; set; }
        public int complete { get; set; }
        public string creator { get; set; }
        public string ingredients_text { get; set; }
        public List<string> additives_old_tags { get; set; }
        public string product_name { get; set; }
        public List<string> ingredients_debug { get; set; }
        public List<string> allergens_hierarchy { get; set; }
        public string emb_codes { get; set; }
        public string product_name_fr { get; set; }
        public int created_t { get; set; }
        public List<object> nutrition_data_per_debug_tags { get; set; }
        public List<string> pnns_groups_1_tags { get; set; }
        public List<object> lang_debug_tags { get; set; }
        public string additives_prev { get; set; }
        public string generic_name { get; set; }
        public string quantity { get; set; }
        public string purchase_places { get; set; }
        public string ingredients_text_debug { get; set; }
        public string max_imgid { get; set; }
        public List<string> allergens_tags { get; set; }
        public string id { get; set; }
        public LanguagesCodes languages_codes { get; set; }
        public List<object> ingredients_text_fr_debug_tags { get; set; }
        public int serving_quantity { get; set; }
        public string image_ingredients_thumb_url { get; set; }
        public List<string> nutrition_grades_tags { get; set; }
        public List<object> packaging_debug_tags { get; set; }
        public string pnns_groups_1 { get; set; }
        public List<object> cities_tags { get; set; }
        public List<string> entry_dates_tags { get; set; }
        public string image_nutrition_small_url { get; set; }
        public List<string> ingredients_n_tags { get; set; }
        public List<string> additives_debug_tags { get; set; }
        public string lang { get; set; }
        public int __invalid_name__fruits_vegetables_nuts_100g_estimate { get; set; }
        public NutrientLevels nutrient_levels { get; set; }
        public List<string> pnns_groups_2_tags { get; set; }
        public string last_editor { get; set; }
        public List<object> labels_hierarchy { get; set; }
        public string labels { get; set; }
        public string image_front_thumb_url { get; set; }
        public int additives_prev_n { get; set; }
        public int sortkey { get; set; }
        public List<object> labels_tags { get; set; }
        public List<object> labels_prev_tags { get; set; }
        public List<object> emb_codes_debug_tags { get; set; }
        public string _id { get; set; }
        public List<string> ingredients_tags { get; set; }
        public string origins { get; set; }
        public List<string> correctors_tags { get; set; }
        public List<string> additives_prev_tags { get; set; }
        public List<object> stores_debug_tags { get; set; }
        public List<object> origins_debug_tags { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public List<string> states_tags { get; set; }
        public string ingredients_text_with_allergens { get; set; }
        public int additives_old_n { get; set; }
        public List<object> traces_debug_tags { get; set; }
        public List<string> nutrient_levels_tags { get; set; }
        public List<object> purchase_places_debug_tags { get; set; }
        public string link { get; set; }
        public List<string> countries_hierarchy { get; set; }
        public string image_url { get; set; }
        public string emb_codes_orig { get; set; }
        public string image_small_url { get; set; }
        public string nutrition_grades { get; set; }
        public List<string> ingredients_ids_debug { get; set; }
        public string ingredients_n { get; set; }
        public List<object> serving_size_debug_tags { get; set; }
        public string image_ingredients_small_url { get; set; }
        public string last_modified_by { get; set; }
        public List<string> traces_hierarchy { get; set; }
        public List<object> product_name_fr_debug_tags { get; set; }
        public string countries { get; set; }
        public List<object> expiration_date_debug_tags { get; set; }
        public int nutrition_score_warning_no_fiber { get; set; }
        public Nutriments nutriments { get; set; }
        public List<object> labels_next_hierarchy { get; set; }
        public string states { get; set; }
        public List<object> manufacturing_places_debug_tags { get; set; }
        public List<string> categories_next_tags { get; set; }
        public List<object> labels_prev_hierarchy { get; set; }
        public string no_nutrition_data { get; set; }
        public string expiration_date { get; set; }
        public List<string> last_image_dates_tags { get; set; }
        public List<string> photographers_tags { get; set; }
        public string serving_size { get; set; }
        public List<string> categories_hierarchy { get; set; }
        public List<string> countries_tags { get; set; }
        public string additives { get; set; }
        public List<object> link_debug_tags { get; set; }
        public List<string> traces_tags { get; set; }
        public string categories { get; set; }
        public List<string> last_edit_dates_tags { get; set; }
        public string image_nutrition_thumb_url { get; set; }
        public List<object> labels_next_tags { get; set; }
        public int last_modified_t { get; set; }
        public string image_front_small_url { get; set; }
        public List<object> generic_name_fr_debug_tags { get; set; }
        public string image_ingredients_url { get; set; }
        public List<object> ingredients_from_palm_oil_tags { get; set; }
        public string pnns_groups_2 { get; set; }
        public List<string> codes_tags { get; set; }
        public string traces { get; set; }
        public string manufacturing_places { get; set; }
        public string interface_version_created { get; set; }
        public string image_front_url { get; set; }
        public string ingredients_text_with_allergens_fr { get; set; }
        public List<object> origins_tags { get; set; }
        public string nutrition_data_per { get; set; }
        public List<string> editors_tags { get; set; }
        public List<object> categories_debug_tags { get; set; }
        public string image_nutrition_url { get; set; }
        public string nutrition_grade_fr { get; set; }
        public string generic_name_fr { get; set; }
        public string lc { get; set; }
        public int rev { get; set; }
        public List<string> additives_tags { get; set; }
        public List<object> unknown_nutrients_tags { get; set; }
        public int ingredients_from_or_that_may_be_from_palm_oil_n { get; set; }
        public List<string> languages_tags { get; set; }
        public List<object> brands_debug_tags { get; set; }
        public string ingredients_text_fr { get; set; }
        public List<string> states_hierarchy { get; set; }
        public List<object> quantity_debug_tags { get; set; }
        public string update_key { get; set; }
        public List<object> labels_debug_tags { get; set; }
        public List<string> stores_tags { get; set; }
        public Languages languages { get; set; }
        public List<string> informers_tags { get; set; }
    }

    public class RootObject
    {
        public string status_verbose { get; set; }
        public string code { get; set; }
        public int status { get; set; }
        public Product product { get; set; }
    }
}
