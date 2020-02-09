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
            sampleChosen = samples.Sample1;
            dataChosen = samples.Data1;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            display.DisplayClass(richTextBox1, sampleChosen, dataChosen);
        }
    }
}
