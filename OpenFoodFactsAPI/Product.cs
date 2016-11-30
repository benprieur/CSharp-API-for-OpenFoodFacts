using System.Collections.Generic;
using System.ComponentModel;

namespace OpenFoodFactsAPI
{
    public class Product
    {
        public string product_name { get; set; }
        public string id { get; set; }
        public string creator { get; set; }
        public string image_thumb_url { get; set; }
        public string ingredients_text { get; set; }
        public string correctors { get; set; }
        public string emb_codes_orig { get; set; }
        public string serving_size { get; set; }
        public string image_nutrition_url { get; set; }
        public string complete { get; set; }
        public string image_ingredients_url { get; set; }
        public string no_nutrition_data { get; set; }
        public string image_nutrition_small_url { get; set; }
        public string labels { get; set; }
        public string ingredients_text_en { get; set; }
        public string pnns_groups_1 { get; set; }
        public string brands { get; set; }
        public string ingredients_text_with_allergens_en { get; set; }
        public string expiration_date { get; set; }
        public string generic_name { get; set; }
        public string states { get; set; }
        public string checkers { get; set; }
        public string last_image_t { get; set; }
        public string ingredients_text_with_allergens { get; set; }
        public string lc { get; set; }
        public string additives { get; set; }
        public string last_modified_by { get; set; }
        public string nutrition_grade_fr { get; set; }
        public string image_ingredients_thumb_url { get; set; }
        public string allergens { get; set; }
        public string stores { get; set; }
        public string image_small_url { get; set; }
        public string image_front_small_url { get; set; }
        public string product_name_en { get; set; }
        public string emb_codes { get; set; }
        public string photographers { get; set; }
        public string interface_version_created { get; set; }
        public string interface_version_modified { get; set; }
        public string purchase_places { get; set; }
        public string categories { get; set; }
        public string generic_name_en { get; set; }
        public string editors { get; set; }
        public string _id { get; set; }
        public string origins { get; set; }
        public string traces { get; set; }
        public string image_nutrition_thumb_url { get; set; }
        public string last_modified_t { get; set; }
        public string countries { get; set; }
        public string image_front_thumb_url { get; set; }
        public string image_front_url { get; set; }
        public string rev { get; set; }
        public string quantity { get; set; }
        public string completed_t { get; set; }
        public string image_url { get; set; }
        public string nutrition_grades { get; set; }
        public string packaging { get; set; }
        public string sortkey { get; set; }
        public string serving_quantity { get; set; }
        public string additives_prev { get; set; }
        public string emb_codes_20141016 { get; set; }
        public string nutrition_data_per { get; set; }
        public string code { get; set; }
        public string image_ingredients_small_url { get; set; }
        public string last_editor { get; set; }
        public string created_t { get; set; }
        public string update_key { get; set; }
        public string max_imgid { get; set; }
        public string informers { get; set; }
        public string lang { get; set; }
        public string pnns_groups_2 { get; set; }
        public string ingredients_text_debug { get; set; }
        public string nutrition_score_debug { get; set; }

        public List<string> informers_tags { get; set; }
        public List<string> brands_tags { get; set; }
        public List<string> entry_dates_tags { get; set; }
        public List<string> traces_tags { get; set; }
        public List<string> correctors_tags { get; set; }
        public List<string> labels_tags { get; set; }
        public List<string> ingredients_that_may_be_from_palm_oil_tags { get; set; }
        public List<string> emb_codes_tags { get; set; }
        public List<string> nutrition_grades_tags { get; set; }
        public List<string> last_image_dates_tags { get; set; }
        public List<string> pnns_groups_2_tags { get; set; }
        public List<string> categories_prev_tags { get; set; }
        public List<string> last_edit_dates_tags { get; set; }
        public List<string> purchase_places_tags { get; set; }
        public List<string> editors_tags { get; set; }
        public List<string> origins_tags { get; set; }
        public List<string> additives_old_tags { get; set; }
        public List<string> codes_tags { get; set; }
        public List<string> languages_tags { get; set; }
        public List<string> cities_tags { get; set; }
        public List<string> nutrient_levels_tags { get; set; }
        public List<string> additives_debug_tags { get; set; }
        public List<string> photographers_tags { get; set; }
        public List<string> labels_prev_tags { get; set; }
        public List<string> ingredients_n_tags { get; set; }
        public List<string> states_tags { get; set; }
        public List<string> additives_tags { get; set; }
        public List<string> unknown_nutrients_tags { get; set; }
        public List<string> allergens_tags { get; set; }
        public List<string> pnns_groups_1_tags { get; set; }
        public List<string> categories_debug_tags { get; set; }
        public List<string> stores_tags { get; set; }
        public List<string> ingredients_from_palm_oil_tags { get; set; }
        public List<string> labels_debug_tags { get; set; }
        public List<string> categories_tags { get; set; }
        public List<string> countries_tags { get; set; }
        public List<string> ingredients_tags { get; set; }
        public List<string> packaging_tags { get; set; }
        public List<string> checkers_tags { get; set; }
        public List<string> additives_prev_tags { get; set; }
        public List<string> states_hierarchy { get; set; }
        public List<string> categories_hierarchy { get; set; }
        public List<string> traces_hierarchy { get; set; }
        public List<string> allergens_hierarchy { get; set; }
        public List<string> countries_hierarchy { get; set; }
        public List<string> labels_hierarchy { get; set; }
        public List<string> languages_hierarchy { get; set; }
        public List<string> labels_prev_hierarchy { get; set; }
        public List<string> categories_prev_hierarchy { get; set; }
        public List<string> _keywords { get; set; }
        public List<string> ingredients_debug { get; set; }
        public List<string> ingredients_ids_debug { get; set; }

        public int unique_scans_n { get; set; }
        public int ingredients_from_or_that_may_be_from_palm_oil_n { get; set; }
        public int ingredients_from_palm_oil_n { get; set; }
        public int additives_n { get; set; }
        public int ingredients_n { get; set; }
        public int additives_tags_n { get; set; }
        public int ingredients_that_may_be_from_palm_oil_n { get; set; }
        public int new_additives_n { get; set; }
        public int scans_n { get; set; }
        public int additives_prev_n { get; set; }
        public int additives_old_n { get; set; }

        public Nutriments nutriments { get; set; }
        public NutrientLevels nutrient_levels { get; set; }

        public List<Ingredient> ingredients { get; set; }
    }

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
        public string saturated_fat_serving { get; set; }
        public string fat_serving { get; set; }
        public string fat_value { get; set; }
        public string proteins_unit { get; set; }
        public string sodium_100g { get; set; }
        public string saturated_fat_unit { get; set; }
        public string energy_serving { get; set; }
        public string sodium_value { get; set; }
        public string proteins_serving { get; set; }
        public string nutrition_score_uk { get; set; }
        public string saturated_fat { get; set; }
        public string proteins_value { get; set; }
        public string sodium_serving { get; set; }
        public string salt_serving { get; set; }
        public string sugars_serving { get; set; }
        public string fat_unit { get; set; }
        public string saturated_fat_100g { get; set; }
        public string sodium { get; set; }
        public string nutrition_score_fr_100g { get; set; }
        public string sugars_unit { get; set; }
        public string proteins { get; set; }
        public string sugars_100g { get; set; }
        public string proteins_100g { get; set; }
        public string carbohydrates { get; set; }
        public string saturated_fat_value { get; set; }
        public string carbohydrates_100g { get; set; }
        public string energy_100g { get; set; }
        public string fat_100g { get; set; }
        public string energy { get; set; }
        public string carbohydrates_unit { get; set; }
        public string salt { get; set; }
        public string fat { get; set; }
        public string salt_unit { get; set; }
        public string carbohydrates_serving { get; set; }
        public string sugars_value { get; set; }
        public string energy_unit { get; set; }
        public string nutrition_score_uk_100g { get; set; }
        public string sugars { get; set; }
        public string salt_100g { get; set; }
    }
}
