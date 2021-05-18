﻿using System.Collections.Generic;

namespace Restaurant.DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public virtual IEnumerable<Dish> Dishes { get; set; }
    }
}
