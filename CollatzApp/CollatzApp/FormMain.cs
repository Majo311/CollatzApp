﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CollatzCalculator;

namespace CollatzApp
{
    public partial class FormMain : Form
    {
        CollatzCalculator.CollatzCalculator collatzCalculator = null;
        List<Output> OutPuts = new List<Output>();
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
            this.OutPuts.Add(new Output(collatzCalculator.SequenceValuesAsString, collatzCalculator.NumberOfEven.ToString(), collatzCalculator.NumberOfOdd.ToString(), null));
            panelOutput.Controls.Clear();
            panelOutput.Controls.AddRange(this.OutPuts.ToArray());
        }
    }
}
