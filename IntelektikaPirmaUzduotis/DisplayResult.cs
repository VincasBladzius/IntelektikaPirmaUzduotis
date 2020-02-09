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

        public DisplayResult()
        {         
            
        }     

       public void DisplayClass(RichTextBox richBox, string[][] sample, string[][] data)
        {
            OneFormula one = new OneFormula();
            DetermineClass determine = new DetermineClass();
            this.Calculations = one.CalculateDistances(sample, data);
            this.ClassSign = determine.DetermineClassSign(Calculations, 5);
            richBox.Text = ClassSign;
           
        }

        
}
}
