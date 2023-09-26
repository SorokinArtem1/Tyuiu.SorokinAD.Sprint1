using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SorokinAD.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            value = value.Replace(" ", "");
            for (var i = 0; i < value.Length-1; ++i)
            {
                
                char check0 = value[i];
                char check1 = value[i+1];
                if (check0 > check1)
                {
                    return false;
                }
            }
            return true;



            
        }
    }
}
