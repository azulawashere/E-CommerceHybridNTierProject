using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class AppUserDTO : BaseDTO
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
