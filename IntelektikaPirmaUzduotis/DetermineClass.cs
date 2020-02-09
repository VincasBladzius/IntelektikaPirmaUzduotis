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
            string classSign = "";
            int i = 0;
            while(i < k){
                foreach (List<object> s in calculations)
                {
                    string oneLine = (s[0].ToString() + " " +  s[1] + "\n");
                    classSign += oneLine;
                }
                i++;
            }            
            return classSign;
        }
    }
}
