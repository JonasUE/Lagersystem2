using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models {
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public decimal? Price { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }
    public class CategorySelection {
        public CategorySelection() {
            ItemsInDropDown = new List<SelectListItem>(){
            new SelectListItem{ Text="SomeValue", Selected=false, Value="SomeUniqueId"}
        };

        }
        public int Id { get; set; }
        public string Category { get; set; }
        public IEnumerable<SelectListItem> ItemsInDropDown { get; set; }
        public void Post() {
            //This method will have the user selected value...
        }
    }  
}