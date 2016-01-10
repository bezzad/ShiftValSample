using System;
using System.Windows.Forms;

namespace TestShiftVal
{
    public partial class Form1 : Form
    {
        private ulong CHECKED = 2;
        private ulong UNCHECKED = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CHECKED = (uint)numChecked.Value << (int)numShiftVal.Value;
            UNCHECKED = (uint)numUnchecked.Value << (int)numShiftVal.Value;

            textBox1.Text = string.Format("Shiftval: {1}{0}Checked({2}): {3}{0}Unchecked({4}): {5}", 
                Environment.NewLine,
                (int)numShiftVal.Value, 
                numChecked.Value,
                CHECKED,
                numUnchecked.Value,
                UNCHECKED);
        }


        private void numShiftVal_ValueChanged(object sender, EventArgs e)
        {
            Form1_Load(this, null);
        }

        private void numChecked_ValueChanged(object sender, EventArgs e)
        {
            Form1_Load(this, null);
        }

        private void numUnchecked_ValueChanged(object sender, EventArgs e)
        {
            Form1_Load(this, null);
        }
    }
}
