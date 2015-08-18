using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week8.Day2_HW.Models
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
        public int user_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string url { get; set; }
        public MainImage MainImage { get; set; }

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
        public string type { get; set; }
        public Pagination pagination { get; set; }
    }
}