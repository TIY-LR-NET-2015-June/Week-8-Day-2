using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MikesEtsyProject.Models
{

    public class MainImage
    {
        public int listing_image_id { get; set; }
        public object hex_code { get; set; }
        public object red { get; set; }
        public object green { get; set; }
        public object blue { get; set; }
        public object hue { get; set; }
        public object saturation { get; set; }
        public object brightness { get; set; }
        public object is_black_and_white { get; set; }
        public object creation_tsz { get; set; }
        public int listing_id { get; set; }
        public object rank { get; set; }
        public string url_75x75 { get; set; }
        public string url_170x135 { get; set; }
        public string url_570xN { get; set; }
        public string url_fullxfull { get; set; }
        public object full_height { get; set; }
        public object full_width { get; set; }
    }

    public class Result
    {
        public int listing_id { get; set; }
        public string state { get; set; }
        public int user_id { get; set; }
        public int category_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int creation_tsz { get; set; }
        public int ending_tsz { get; set; }
        public int original_creation_tsz { get; set; }
        public int last_modified_tsz { get; set; }
        public string price { get; set; }
        public string currency_code { get; set; }
        public int quantity { get; set; }
        public List<string> tags { get; set; }
        public List<string> category_path { get; set; }
        public List<int> category_path_ids { get; set; }
        public List<string> materials { get; set; }
        public int shop_section_id { get; set; }
        public object featured_rank { get; set; }
        public int state_tsz { get; set; }
        public string url { get; set; }
        public int views { get; set; }
        public int num_favorers { get; set; }
        public object shipping_template_id { get; set; }
        public int processing_min { get; set; }
        public int processing_max { get; set; }
        public string who_made { get; set; }
        public string is_supply { get; set; }
        public string when_made { get; set; }
        public object item_weight { get; set; }
        public object item_weight_units { get; set; }
        public object item_length { get; set; }
        public object item_width { get; set; }
        public object item_height { get; set; }
        public string item_dimensions_unit { get; set; }
        public bool is_private { get; set; }
        public object recipient { get; set; }
        public object occasion { get; set; }
        public List<string> style { get; set; }
        public bool non_taxable { get; set; }
        public bool is_customizable { get; set; }
        public bool is_digital { get; set; }
        public string file_data { get; set; }
        public string language { get; set; }
        public bool has_variations { get; set; }
        public int taxonomy_id { get; set; }
        public List<string> taxonomy_path { get; set; }
        public bool used_manufacturer { get; set; }
        public MainImage MainImage { get; set; }
    }

    public class Params
    {
        public string limit { get; set; }
        public string offset { get; set; }
        public object page { get; set; }
        public object keywords { get; set; }
        public string sort_on { get; set; }
        public string sort_order { get; set; }
        public object min_price { get; set; }
        public object max_price { get; set; }
        public object color { get; set; }
        public int color_accuracy { get; set; }
        public object tags { get; set; }
        public object category { get; set; }
        public object location { get; set; }
        public object lat { get; set; }
        public object lon { get; set; }
        public object region { get; set; }
        public string geo_level { get; set; }
        public string accepts_gift_cards { get; set; }
        public string translate_keywords { get; set; }
    }

    public class Pagination
    {
        public int effective_limit { get; set; }
        public int effective_offset { get; set; }
        public int next_offset { get; set; }
        public int effective_page { get; set; }
        public int next_page { get; set; }
    }

    public class RootObject
    {
        public int count { get; set; }
        public List<Result> results { get; set; }
        public Params @params { get; set; }
        public string type { get; set; }
        public Pagination pagination { get; set; }
    }

}
