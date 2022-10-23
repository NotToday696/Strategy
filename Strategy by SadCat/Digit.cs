using Strategy_by_SadCat.Count;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Single = Strategy_by_SadCat.Count.Single;

namespace Strategy_by_SadCat
{
    public  class Digit
    {
        protected INumber number = new Single();
        public void digit(double res)
        {
            string count = res.ToString();
            if (count.Length == 1)
            {
                number = new Single();
                number.Number();
            }
            else if (count.Length == 2)
            {
                number = new Two_digit();
                number.Number();
            }
            else
            {
                number = new Multi();
                number.Number();
            }
        }
    }
}
