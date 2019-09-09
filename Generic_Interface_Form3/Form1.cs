using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_Interface_Form3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInt_Click(object sender, EventArgs e)
        {
            AddInteger addInt = new AddInteger();
            MessageBox.Show(addInt.Add(11,6).ToString());
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            AddDouble addDoub = new AddDouble();
            MessageBox.Show(addDoub.Add(12.75, 16.49).ToString());
        }

        private void BtnString_Click(object sender, EventArgs e)
        {
            AddString addStr = new AddString();
            MessageBox.Show(addStr.Add("Nikola","Tesla"));
        }
    }
}
