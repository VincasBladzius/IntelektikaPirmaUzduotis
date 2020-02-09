using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelektikaPirmaUzduotis
{
    class SecondFormula
    {       
        public List<List<object>> Calculations { get; set; }
        public SecondFormula()
        {
            this.Calculations = new List<List<object>>();
        }

        public List<List<object>> CalculateDistances(string[][] sample, string[][] data, int point)
        {
            double sum;
            List<object> pointDistance;

            for (int i = 0; i < sample.Length; i++)
            {
                double sum1 = Convert.ToInt32(data[point][0]) - Convert.ToInt32(sample[i][0]);
                double sum2 = Convert.ToInt32(data[point][1]) - Convert.ToInt32(sample[i][1]);
               if(sum1 < 0)
                {
                    sum1 *= -1;
                }
                if(sum2 < 0)
                {
                    sum2 *= -1;
                }

                if (sum1 > sum2)
                {
                    sum = sum1;
                }
                else
                {
                    sum = sum2;
                }
                
                pointDistance = new List<object> { sum, sample[i][2] };
                Calculations.Add(pointDistance);
            }
            Calculations = Calculations.OrderBy(lst => lst[0]).ToList();
            return Calculations;
        }
    }
    
}
