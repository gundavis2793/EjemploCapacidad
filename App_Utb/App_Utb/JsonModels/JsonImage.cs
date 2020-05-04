﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.JsonModels
{
    public class ImageJson
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public DateTime date_gmt { get; set; }
        public Guid guid { get; set; }
        public DateTime modified { get; set; }
        public DateTime modified_gmt { get; set; }
        public string slug { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string link { get; set; }
        public Title title { get; set; }
        public int author { get; set; }
        public string comment_status { get; set; }
        public string ping_status { get; set; }
        public string template { get; set; }
        public object[] meta { get; set; }
        public Description description { get; set; }
        public Caption caption { get; set; }
        public string alt_text { get; set; }
        public string media_type { get; set; }
        public string mime_type { get; set; }
        public Media_Details media_details { get; set; }
        public object post { get; set; }
        public string source_url { get; set; }

    }


    public class Description
    {
        public string rendered { get; set; }
    }

    public class Caption
    {
        public string rendered { get; set; }
    }

    public class Media_Details
    {
        public int width { get; set; }
        public int height { get; set; }
        public string file { get; set; }
        public Sizes sizes { get; set; }
        public Image_Meta image_meta { get; set; }
    }

    public class Sizes
    {
        public Thumbnail thumbnail { get; set; }
        public Medium medium { get; set; }
        public Medium_Large medium_large { get; set; }
        public Large large { get; set; }
        public Full full { get; set; }
    }

    public class Thumbnail
    {
        public string file { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string mime_type { get; set; }
        public string source_url { get; set; }
    }

    public class Medium
    {
        public string file { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string mime_type { get; set; }
        public string source_url { get; set; }
    }

    public class Medium_Large
    {
        public string file { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string mime_type { get; set; }
        public string source_url { get; set; }
    }

    public class Large
    {
        public string file { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string mime_type { get; set; }
        public string source_url { get; set; }
    }

    public class Full
    {
        public string file { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string mime_type { get; set; }
        public string source_url { get; set; }
    }

    public class Image_Meta
    {
        public string aperture { get; set; }
        public string credit { get; set; }
        public string camera { get; set; }
        public string caption { get; set; }
        public string created_timestamp { get; set; }
        public string copyright { get; set; }
        public string focal_length { get; set; }
        public string iso { get; set; }
        public string shutter_speed { get; set; }
        public string title { get; set; }
        public string orientation { get; set; }
        public object[] keywords { get; set; }
    }
}
