using System;
using System.Collections.Generic;
using System.Text;

namespace Cellula.Entity
{
    public class UserEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public ICollection<CategoriesEntity> Category { get; set; }

    }
}
