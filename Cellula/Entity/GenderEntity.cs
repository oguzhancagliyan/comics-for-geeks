using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cellula.Entity
{
    public class GenderEntity
    {
        [Key]
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public ICollection<UserEntity> Users { get; set; }
    }
}
