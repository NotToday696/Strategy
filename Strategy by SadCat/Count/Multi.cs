using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_by_SadCat.Count
{
     public class Multi:INumber
    {
        public void Number()
        {
            Console.WriteLine("Введено многозначное число");
        }
    }
}
