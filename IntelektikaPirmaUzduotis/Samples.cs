using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelektikaPirmaUzduotis
{
    public class Samples
    {
        public string[][] Sample1 { get; set; }
        public string[][] Data1 { get; set; }

        public Samples()
        {
            this.Sample1 = new string[][]
            {
                new string[]{"1","2","+"},
                new string[]{"3","4","+"},
                new string[]{"6","4","+"},
                new string[]{"2","1","-"},
                new string[]{"4","1","-"},
                new string[]{"5","2","-"},
                
            };

            this.Data1 = new string[][]
            {
                new string[]{"5","3"},
                new string[]{"6","3"}
            };


        }
    }
}
