using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class UserProfileDTO : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
