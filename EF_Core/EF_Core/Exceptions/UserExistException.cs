using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Exceptions
{
    class UserExistException : Exception
    {
        public UserExistException() : base("User already is exist, Please try login!") { }
        public UserExistException(string message) : base(message) { }
    }
}
