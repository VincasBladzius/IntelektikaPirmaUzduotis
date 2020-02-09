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


       public void DisplayClass(RichTextBox richBox, string[][] sample, string[][] data, int k, int point, int formulaChoise)
        {
            OneFormula one = new OneFormula();
            SecondFormula second = new SecondFormula();
            DetermineClass determine = new DetermineClass();

            if(formulaChoise == 0)
            {
                this.Calculations = one.CalculateDistances(sample, data, point);
            }
            else
            {
                this.Calculations = second.CalculateDistances(sample, data, point);
            }         
       
            this.ClassSign = determine.DetermineClassSign(Calculations, k);
            richBox.Text = ClassSign;
           
        }

        public void DisplayClass2(RichTextBox richBox, string[][] sample, string[][] data, int k, int point)
        {
           
            SecondFormula second = new SecondFormula();
            DetermineClass determine = new DetermineClass();
            this.Calculations = second.CalculateDistances(sample, data, point);
            //this.ClassSign = determine.DetermineClassSign(Calculations, k);
            string classSign = "";
            foreach (List<object> s in Calculations)
            {
                string oneLine = (s[0].ToString() + " " + s[1] + "\n");
                classSign += oneLine;
            }
            richBox.Text = classSign;

        }        
}
}
