using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cellula.Entity
{
    public class CategoriesEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<UserCategoryEntity> UserCategories { get; set; }

    }
}
