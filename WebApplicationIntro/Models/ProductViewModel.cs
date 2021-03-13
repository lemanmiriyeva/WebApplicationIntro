using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationIntro.Entity;

namespace WebApplicationIntro.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public List<string> Categories { get; set; }
    }
}
