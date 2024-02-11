using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace MiniStore.Models

{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int CatId { get; set; }
        [ForeignKey("CatId")]
        [ValidateNever]
        public Category Category { get; set; }

        //[Required]
        public string Description { get; set; }

        [Required]
        [Display(Name = "List Price")]
        [Range(1, 1000)]
        public double ListPrice { get; set; }

        //[Required]
        [Display(Name = "Price for 1-49")]
        [Range(1, 1000)]
        public double Price { get; set; }

        //[Required]
        [Display(Name = "Price for 50-99")]
        [Range(1, 1000)]
        public double Price50 { get; set; }

       // [Required]
        [Display(Name = "Price for 100+")]
        [Range(1, 1000)]
        public double Price100 { get; set; }
        public int Size { get; set; }
        [ValidateNever]
        public string? Image1 { get; set; }
        [ValidateNever]
        public string? Image2 { get; set; }
        [ValidateNever]
        public string? Image3 { get; set; }
        public string Char_Class { get; set; }
        public string Char_Race { get; set; }

        [ValidateNever]
        public List<ProductImage> ProductImages { get; set; }
    }

}
