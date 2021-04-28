using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookaboo.Models
{
    public class Recipes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Method { get; set; }
        public string Time { get; set; }
    }
}
