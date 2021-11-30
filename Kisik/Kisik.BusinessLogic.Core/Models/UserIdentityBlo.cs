using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisik.BusinessLogic.Core.Models
{
    public class UserIdentityBlo
    {
        public string Id { get; set; }
        public string NumberPrefix { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
