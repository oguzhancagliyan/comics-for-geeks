using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cellula.Entity
{
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        
        public int GenderId { get; set; }
        public GenderEntity Gender { get; set; }
        public ICollection<UserCategoryEntity> UserCategories { get; set; }

    }
}
