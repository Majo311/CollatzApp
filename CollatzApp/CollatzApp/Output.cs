using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollatzApp
{
    public partial class Output : UserControl
    {
        public Output(string Sequences,string NumberOfEven,string NumberOfOdd,string max)
        {
            InitializeComponent();
            this.tb_Sequence.Text = Sequences;
            this.tb_even.Text = NumberOfEven;
            this.tb_Odd.Text = NumberOfOdd;
            this.tb_maxMember.Text = max;
        }

    }
}
