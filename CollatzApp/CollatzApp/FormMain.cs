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
            string sequences = this.collatzCalculator.SequenceValuesAsString;


        }
    }
}
