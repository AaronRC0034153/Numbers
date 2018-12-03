using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double d1 = 5e6;
            box1.AppendText(d1.ToString() + "\n");
            box1.AppendText(d1.ToString("N") + "\n");
            box1.AppendText(d1.ToString("N4") + "\n");
            box1.AppendText(d1.ToString("N0") + "\n");
            box1.AppendText(d1.ToString("0") + "\n");
            box1.AppendText(d1.ToString("0.0") + "\n");
            box1.AppendText(d1.ToString("0.0E0") + "\n");
            box1.AppendText(d1.ToString("0.00E00") + "\n");

            double pi = 3.141592653589793;
            double c = 299792458;
            box1.AppendText(pi.ToString("N3") + "\n");
            box1.AppendText(pi.ToString("N5") + "\n");
            box1.AppendText(pi.ToString("N15") + "\n");
            box1.AppendText(c.ToString() + "\n");
            box1.AppendText(c.ToString("N0") + "\n");
            box1.AppendText(c.ToString("0.000000000000000E0") + "\n");
            box1.AppendText(c.ToString("0.00E0") + "\n");


        }
    }
}
