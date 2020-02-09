using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IntelektikaPirmaUzduotis
{
    public class OneFormula
    {
        public List<List<object>> Calculations { get; set; }
        public OneFormula()
        {
            this.Calculations = new List<List<object>>();
        }

        public List<List<object>> CalculateDistances(string[][] sample, string[][] data)
        {
            double sum;
            List<object> pointDistance;
            
            for (int i = 0; i < sample.Length; i++)
            {
                sum = Math.Pow(Convert.ToInt32(data[0][0]) - Convert.ToInt32(sample[i][0]), 2) + Math.Pow(Convert.ToInt32(data[0][1]) - Convert.ToInt32(sample[i][1]), 2);
                sum = Math.Sqrt(sum);
                pointDistance = new List<object> { sum, sample[i][2] };
                Calculations.Add(pointDistance);                
            }
            Calculations = Calculations.OrderBy(lst => lst[0]).ToList();
            return Calculations;           
        }            
        }
    }

