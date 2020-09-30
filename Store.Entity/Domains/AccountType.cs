using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Store.Entity.Domains
{
    [Table("AccountTypes")]
    public class AccountType : Entity
    {
        [Key]
        [StringLength(50)]
        public string AccountTypeId { get; set; }

        [StringLength(100)]
        public string AccountTypeName { get; set; }
    }
}
