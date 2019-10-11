using System;
using System.Collections.Generic;
using System.Text;

namespace Cellula.Entity
{
    public class UserCategoryEntity
    {
        public int CategoryId { get; set; }
        public CategoriesEntity Category { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }

    }
}
