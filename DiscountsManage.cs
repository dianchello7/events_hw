using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_hw
{
    class DiscountsManage
    {

        public void GetFivePrcntDiscount(object sender , EventArgs e)
        {
            Console.WriteLine("You get 5%");
        }
    }
}
