using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelektikaPirmaUzduotis
{
    public class DisplayResult
    {
        public List<List<object>> Calculations { get; set; }
        public string ClassSign { get; set; }     


       public void DisplayClass(RichTextBox richBox, string[][] sample, string[][] data, int k, int point)
        {
            OneFormula one = new OneFormula();
            DetermineClass determine = new DetermineClass();
            this.Calculations = one.CalculateDistances(sample, data, point);
            this.ClassSign = determine.DetermineClassSign(Calculations, k);
            richBox.Text = ClassSign;
           
        }

        
}
}
