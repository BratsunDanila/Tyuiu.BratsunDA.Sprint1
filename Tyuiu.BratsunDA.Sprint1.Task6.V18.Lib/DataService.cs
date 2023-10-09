using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BratsunDA.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            if (int.TryParse(value, out int number) && value[0]!='0')
            {
                if (number > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
