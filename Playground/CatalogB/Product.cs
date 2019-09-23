using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.CatalogB
    {
    public class Product
        {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City{ get; set; }
        public Details Details { get; set; }
        public List<Category> Categories { get; set; }


        }
    }
