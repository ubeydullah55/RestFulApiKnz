﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestFulApi.Models
{
    public class PanelDetayList
    {
       
        public int siparisid { get; set; }     
        public int id { get; set; }
        [Required]
        [MaxLength(99)]
        public string name { get; set; }
        public int price { get; set; }
        [MaxLength(99)]
        public string imgfile { get; set; }
        public string description { get; set; }
        public int categoryid { get; set; }
        public int count { get; set; }
    }
}
