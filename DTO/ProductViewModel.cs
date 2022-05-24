using System.ComponentModel.DataAnnotations;

namespace TechnicalTassk.DTO
{
    public class ProductViewModel
    {
        //[Required]
        public int ProductId { get; set; }
        //[Required]
        //[StringLength(60, MinimumLength = 5)]
        public string ProductName { get; set; }
        //[Required]
        public int ProductPrice { get; set; }
        //[Required]
        public int ProductQuantity { get; set; }
        //[StringLength(100, MinimumLength = 4)]
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}
