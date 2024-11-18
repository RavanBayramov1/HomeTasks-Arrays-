using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Exceptions
{
    class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("User not founded, Please try again!") { }
        public UserNotFoundException(string message) : base(message) { }
    }
}
