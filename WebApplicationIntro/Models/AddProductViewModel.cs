using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationIntro.Entity;

namespace WebApplicationIntro.Models
{
    public class AddProductViewModel
    {
        public Product Product { get; set; }
        public List<SelectListItem> Categories;
    }
}
