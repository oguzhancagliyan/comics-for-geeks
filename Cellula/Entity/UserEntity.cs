using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cellula.Entity
{
    public class UserEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        
        public int GenderId { get; set; }
        public GenderEntity Gender { get; set; }
        public ICollection<UserCategoryEntity> UserCategories { get; set; }

    }
}
