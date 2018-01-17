using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Domain.Entities
{
    public class Book
    {
        [HiddenInput(DisplayValue=false)]
        [Display(Name = "ID")]
        public int BookId { get; set; }
        [Display(Name="Name")]
        [Required(ErrorMessage ="Please enter the Name of the Book")]
        public string Name { get; set; }
        [Display(Name = "Author")]
        [Required(ErrorMessage = "Please enter Author of the Book")]       
        public string Author { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please enter the Description of the Book")] 
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please enter the Genre of the Book")]
        public string Genre { get; set; }
        [Display(Name = "Price (USD)")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter digits of the Book")]
        public decimal Price { get; set; }

    }
}
