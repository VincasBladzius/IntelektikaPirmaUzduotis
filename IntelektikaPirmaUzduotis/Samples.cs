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
        public string[][] Sample2 { get; set; }
        public string[][] Data2 { get; set; }
        public string[][] Sample3 { get; set; }
        public string[][] Data3 { get; set; }
        public string[][] Sample4 { get; set; }
        public string[][] Data4 { get; set; }
        public string[][] Sample5 { get; set; }
        public string[][] Data5 { get; set; }
        public string[][] Sample6 { get; set; }
        public string[][] Data6 { get; set; }
        public string[][] Sample7 { get; set; }
        public string[][] Data7 { get; set; }
        public string[][] Sample8 { get; set; }
        public string[][] Data8 { get; set; }
        public string[][] Sample9 { get; set; }
        public string[][] Data9 { get; set; }

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
            this.Sample2 = new string[][]
            {
                new string[]{"5","1","+"},
                new string[]{"3","3","+"},
                new string[]{"0","3","+"},
                new string[]{"4","0","-"},
                new string[]{"2","0","-"},
                new string[]{"1","1","-"},
                
            };

            this.Data2 = new string[][]
            {
                new string[]{"1","2"},
                new string[]{"0","2"}
            };
            this.Sample3 = new string[][]
            {
                new string[]{"0","2","+"},
                new string[]{"2","0","+"},
                new string[]{"5","0","+"},
                new string[]{"1","3","-"},
                new string[]{"3","3","-"},
                new string[]{"4","2","-"},
                
            };

            this.Data3 = new string[][]
            {
                new string[]{"4","1"},
                new string[]{"5","1"}
            };
            this.Sample4 = new string[][]
            {
                new string[]{"6","3","+"},
                new string[]{"4","1","+"},
                new string[]{"1","1","+"},
                new string[]{"5","4","-"},
                new string[]{"3","4","-"},
                new string[]{"2","3","-"},
                
            };

            this.Data4 = new string[][]
            {
                new string[]{"2","2"},
                new string[]{"1","2"}
            };
            this.Sample5 = new string[][]
            {
                new string[]{"1","1","+"},
                new string[]{"4","5","+"},
                new string[]{"5","2","+"},
                new string[]{"2","4","-"},
                new string[]{"3","2","-"},
                new string[]{"4","3","-"},
                
            };

            this.Data5 = new string[][]
            {
                new string[]{"2","1"},
                new string[]{"3","3"}
            };
            this.Sample6 = new string[][]
            {
                new string[]{"5","0","+"},
                new string[]{"2","4","+"},
                new string[]{"1","1","+"},
                new string[]{"4","3","-"},
                new string[]{"3","1","-"},
                new string[]{"2","2","-"},
                
            };

            this.Data6 = new string[][]
            {
                new string[]{"4","0"},
                new string[]{"3","2"}
            };
            this.Sample7 = new string[][]
            {
                new string[]{"0","3","+"},
                new string[]{"3","-1","+"},
                new string[]{"4","2","+"},
                new string[]{"1","0","-"},
                new string[]{"2","2","-"},
                new string[]{"3","1","-"},
                
            };

            this.Data7 = new string[][]
            {
                new string[]{"1","3"},
                new string[]{"2","1"}
            };
            this.Sample8 = new string[][]
            {
                new string[]{"6","4","+"},
                new string[]{"3","0","+"},
                new string[]{"2","3","+"},
                new string[]{"5","1","-"},
                new string[]{"4","3","-"},
                new string[]{"3","2","-"},
                
            };

            this.Data8 = new string[][]
            {
                new string[]{"5","4"},
                new string[]{"4","2"}
            };
            this.Sample9 = new string[][]
            {
                new string[]{"0","0","+"},
                new string[]{"0","15","+"},
                new string[]{"15","0","+"},
                new string[]{"5","5","-"},
                new string[]{"5","20","-"},
                new string[]{"20","5","-"},
                
            };

            this.Data9 = new string[][]
            {
                new string[]{"6","5"},
                new string[]{"6","13"}
            };
        }
    }
}
