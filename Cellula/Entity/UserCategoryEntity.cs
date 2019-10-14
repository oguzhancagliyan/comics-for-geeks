using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cellula.Entity
{
    public class UserCategoryEntity
    {
        [Key, Column(Order = 0)]
        public int CategoryId { get; set; }
        public CategoriesEntity Category { get; set; }
        [Key, Column(Order = 0)]
        public int UserId { get; set; }
        public UserEntity User { get; set; }

    }
}
