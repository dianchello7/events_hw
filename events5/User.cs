using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events5
{
     class User
    {
        public string UserName {  get; set;}
        public string Password {  get; set;}

        public void OnTryLogin (string message)
        {
            Console.WriteLine(message);
        }
    }
}
