﻿using System.ComponentModel.DataAnnotations;

namespace Pustok_MVC.Models
{
    public class Setting
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
