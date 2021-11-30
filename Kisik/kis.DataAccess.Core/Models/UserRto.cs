using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kis.DataAccess.Core.Models
{
    [Table("User")]
    class UserRto
    {
       [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumberPrefix { get; set; }
        public string PhoneNumber { get; set; }
    }
}
