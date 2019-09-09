using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericMethod_Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void GetDefaultValue<T>()
        {
            MessageBox.Show(default(T).ToString());
        }

        private void BtnChar_Click(object sender, EventArgs e)
        {
            GetDefaultValue<char>();
        }

        private void BtnInt_Click(object sender, EventArgs e)
        {
            GetDefaultValue<int>();

        }

        private void BtnBool_Click(object sender, EventArgs e)
        {
            GetDefaultValue<bool>();

        }

        private void BtnString_Click(object sender, EventArgs e)
        {
            GetDefaultValue<string>();

        }

        private void BtnDatetime_Click(object sender, EventArgs e)
        {
            GetDefaultValue<DateTime>();

        }

        private void BtnAraba_Click(object sender, EventArgs e)
        {
            GetDefaultValue<Araba>();

        }
    }
}
