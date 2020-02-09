using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelektikaPirmaUzduotis
{
    class DetermineClass
    {
        public string DetermineClassSign(List<List<object>> calculations, int k)
        {
            List<string> signs = new List<string>();           
            List<double> sums = new List<double>(); 
            
            foreach (List<object> s in calculations)
            {
                signs.Add(s[1].ToString());
                sums.Add(Convert.ToDouble(s[0]));
            }

            int f = CheckValue(signs, k);
            string sign = DetermineSign(signs, f);
            string classSign = CheckStringValues(sums, signs, k, sign);                      
            
            return classSign;
        }
        public int CheckValue(List<string> signs, int k)
        {
            int f = 0;
            for (int i = 0; i < k; i++)
            {
                if (signs[i] == "+")
                {
                    f += 1;
                }
                else if (signs[i] == "-")
                {
                    f -= 1;
                }
                else
                {
                    throw new Exception(signs[i]);
                }
            }
            return f;
        }
        public string DetermineSign(List<string> signs, int f)
        {
            string sign;
            if (f > 0)
            {
                sign = "+";
            }
            else if (f < 0)
            {
                sign = "-";
            }
            else
            {
                sign = "nežinomas";
            }
            return sign;
        }
        public string CheckStringValues(List<double> sums, List<string> signs, int k, string sign)
        {

            if(k<sums.Count && sums[k-1] == sums[k] && signs[k - 1] == signs[k])
            {
                return "nežinomas";
            }
            else
            {
            return sign;
            }
        }
    }
}
