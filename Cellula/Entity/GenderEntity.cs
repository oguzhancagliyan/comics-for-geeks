using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cellula.Entity
{
    public class GenderEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public ICollection<UserEntity> Users { get; set; }
    }
}
