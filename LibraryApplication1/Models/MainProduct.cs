using System.ComponentModel.DataAnnotations;
namespace LibraryApplication1.Models
{
    public class MainProduct
    {

        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int SubCategoryId { get; set; }
    }
}
