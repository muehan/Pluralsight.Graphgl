using System.ComponentModel.DataAnnotations;

namespace Pluralsight.Graphgl.Mvc.Data.Entities
{
    public class ProductReview
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        public string Review { get; set; }
    }
}
