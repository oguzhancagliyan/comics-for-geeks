using System;
using System.Collections.Generic;
using System.Text;

namespace Cellula.Entity
{
    public class CategoriesEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<UserEntity> Users { get; set; }

    }
}
