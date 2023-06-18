using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApplication1.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }

        public string SubCategoryName { get; set; }


    }
}
