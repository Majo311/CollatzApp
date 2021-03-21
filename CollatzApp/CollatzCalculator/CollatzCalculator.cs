﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzCalculator
{
    public class CollatzCalculator
    {
        public string InputAsText
        {
            get;
            private set;
        }
        public List<string> SequenceValues
        {
            get;
            private set;
        } = new List<string>();
        public string SequenceValuesAsString => this.SequenceValues.AsString();
        public uint NumberOfEven
        {
            get;
            private set;
        } = 0;
        public uint NumberOfOdd
        {
            get;
            private set;
        } = 0;
        public List<uint>InputValue { get; private set; }
        public CollatzCalculator(string txtInput)
        {
            this.InputAsText = txtInput;

            this.InputValue=txtInput.GetDigits().ToList();
            if(this.InputValue.IsInputZero())
            {
                throw new Exception("Incorrect input! Input have to be >0");
            }
        }
        public void Calculate()
        {
            double result = 0;
            for(int i=0;i<this.InputValue.Count;i++)
            {
                result += this.InputValue[i] * Math.Pow(10, this.InputValue.Count-1 - i );
            }
            double sequenceItem = result;
            do
            {
                if (sequenceItem % 2 == 0)
                {
                    sequenceItem = sequenceItem / 2;
                    this.NumberOfEven++;
                }
                else
                {
                    sequenceItem = (3 * sequenceItem) + 1;
                    this.NumberOfOdd++;
                }
                this.SequenceValues.Add(sequenceItem.ToString());
            }
            while (sequenceItem != 1);
        }

 
    }
}
