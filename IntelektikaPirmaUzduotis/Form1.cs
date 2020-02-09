using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelektikaPirmaUzduotis
{
    public partial class Form1 : Form
    {
        public DisplayResult display { get; set; }
        public OneFormula oneFormula { get; set; }
        public Samples samples { get; set; }
        public string[][] sampleChosen { get; set; }
        public string[][] dataChosen { get; set; }
        public int K { get; set; }
        public int Point { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.samples = new Samples();
            this.display = new DisplayResult();
            PopulateNeighboursBox();
        }
        public void PopulateNeighboursBox()
        {
            var i = 1;
            while (i < 7)
            {
                NeighboursBox.Items.Add(i);
                i++;
            }
        }

        public void button2imtis_Click(object sender, EventArgs e)
        {
            //sampleChosen = samples.Sample1;
            //dataChosen = samples.Data1;
            sampleChosen = samples.Sample2;
            dataChosen = samples.Data2;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
           
        }

        private void E7Point_Click(object sender, EventArgs e)
        {
            this.Point = 0;
        }

        private void E8Point_Click(object sender, EventArgs e)
        {
            this.Point = 1;
        }

        private void FormulaOne_Click(object sender, EventArgs e)
        {
            this.K = Convert.ToInt32(NeighboursBox.SelectedItem);
            int formulaChoise = 0;
            display.DisplayClass(richTextBox1, sampleChosen, dataChosen, K, Point, formulaChoise);
        }

        private void FormulaTwo_Click(object sender, EventArgs e)
        {
            int formulaChoise = 1;
            this.K = Convert.ToInt32(NeighboursBox.SelectedItem);
            display.DisplayClass(richTextBox1, sampleChosen, dataChosen, K, Point, formulaChoise);

        }

        private void button3imtis_Click(object sender, EventArgs e)
        {
            sampleChosen = samples.Sample3;
            dataChosen = samples.Data3;
        }

        private void button4imtis_Click(object sender, EventArgs e)
        {
            sampleChosen = samples.Sample4;
            dataChosen = samples.Data4;
        }

        private void button5imtis_Click(object sender, EventArgs e)
        {
            sampleChosen = samples.Sample5;
            dataChosen = samples.Data5;
        }

        private void button6imtis_Click(object sender, EventArgs e)
        {
            sampleChosen = samples.Sample6;
            dataChosen = samples.Data6;
        }

        private void button7imtis_Click(object sender, EventArgs e)
        {
            sampleChosen = samples.Sample7;
            dataChosen = samples.Data7;
        }

        private void button8imtis_Click(object sender, EventArgs e)
        {
            sampleChosen = samples.Sample8;
            dataChosen = samples.Data8;
        }

        private void button9imtis_Click(object sender, EventArgs e)
        {
            sampleChosen = samples.Sample9;
            dataChosen = samples.Data9;
        }
    }
}
