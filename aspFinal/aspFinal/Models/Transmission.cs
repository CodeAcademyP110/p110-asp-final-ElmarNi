﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspFinal.Models
{
    public class Transmission
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
