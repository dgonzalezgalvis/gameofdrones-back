﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gameofdrones.back.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }

        public int Score { get; set; }
    }
}