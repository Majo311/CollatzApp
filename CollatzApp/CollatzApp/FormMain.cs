using System;
using System.Windows.Forms;
using CollatzCalculator;

namespace CollatzApp
{
    public partial class FormMain : Form
    {
        CollatzCalculator.CollatzCalculator collatzCalculator = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.collatzCalculator = new CollatzCalculator.CollatzCalculator(this.tbInput.Text);
            this.collatzCalculator.Calculate();
            AddResult(this.collatzCalculator);
        }
        private void AddResult(CollatzCalculator.CollatzCalculator collatzCalculator )
        {
            Output output = new Output(collatzCalculator.SequenceValuesAsString, collatzCalculator.NumberOfEven.ToString(), collatzCalculator.NumberOfOdd.ToString(), null);
            panelOutput.Controls.Add(output);
        }
    }
}
