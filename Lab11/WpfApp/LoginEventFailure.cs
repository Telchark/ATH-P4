using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    //sprawdzanie co było złe przy logowaniu
    public class LoginFailureEventArgs : EventArgs
    {
        public List<LoginError> Errors { get; set; }
        public class LoginError
        {
            public LoginFields Field { get; set; }
            public string ErrorMsg { get; set; }
        }
    }
    public enum LoginFields
    {
        Login,
        Password,
        All
    }
}
