using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events5
{   public delegate void SendMessage(string message);
    class Bank
    {
        List<User> users = new List<User>();
        public event SendMessage SuccessLogin;
        public event SendMessage UnSuccessLogin;

        public Bank()
        {
            users.Add(new User() { UserName = "fbk", Password = "grsgr" });
            users.Add(new User() { UserName = "fggsgg", Password = "32" });
            users.Add(new User() { UserName = "fe", Password = "1rgrg" });
        }

        public bool Login(string userName , string password)
        {
            User user = users.FirstOrDefault(x => x.UserName == userName)   ;
            if (user != null)
            {
                if(user.Password == password)
                {
                    OnLoginSuccess("LoginSuccess");
                    return true;
                }
            }    
            else
            {
                OnLoginFailed("User name is no exist");
                return false;
            }
        }

        private void OnLoginFailed(string message)
        {
            UnSuccessLogin?.Invoke(message);
        }
        private void OnLoginSuccess(string message)
        {
            SuccessLogin?.Invoke(message);
        }
    }
}
