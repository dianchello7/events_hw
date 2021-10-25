using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events5
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            Bank B = new Bank();
            User u = new User();
            b.SuccessLogin += u.OnTryLogin;
            b.UnuccessLogin += u.OnTryLogin;

            b.Login("fbk", "1rg");
            b.Login("dbf", "32");
            b.Login("fe", "1rgrg");
        }
    }
}
