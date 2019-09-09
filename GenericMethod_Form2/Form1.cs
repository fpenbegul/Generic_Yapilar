using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericMethod_Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ArrayBoyutlandir<T>(ref T[] dizi)
        {
            int length = dizi.Length * 2;
            T[] yeniDizi = new T[length];

            for (int i = 0; i < dizi.Length; i++)
            {
                yeniDizi[i] = dizi[i];
            }
            dizi = new T[length];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = yeniDizi[i];
            }

        }
        void ListBoxiDoldur<T>(T[] dizi)
        {
            lbxSonuc.Items.Clear();
            foreach (T item in dizi)
            {
                lbxSonuc.Items.Add(item == null ? "null" : item.ToString());
            }
        }
        string[] stringArray;
        private void BtnStringArrayOlustur_Click(object sender, EventArgs e)
        {
            stringArray = new string[2] { "metin1", "metin2" };
            ListBoxiDoldur<string>(stringArray);
        }

        private void BtnStringBoyutlandir_Click(object sender, EventArgs e)
        {
            ArrayBoyutlandir<string>(ref stringArray);
            ListBoxiDoldur<string>(stringArray);
        }

        int[] intArray;
        private void BtnIntArrayOlustur_Click(object sender, EventArgs e)
        {
            intArray = new int[4] { 1, 2, 3, 4 };
            ListBoxiDoldur<int>(intArray);
        }
        private void BtnBoyutlandir_Click(object sender, EventArgs e) // int boyutlandir
        {
            ArrayBoyutlandir<int>(ref intArray);
            ListBoxiDoldur<int>(intArray);
        }
        Kisi[] kisiler;
        private void BtnKisiBoyutlandir_Click(object sender, EventArgs e)
        {
            ArrayBoyutlandir<Kisi>(ref kisiler);
            ListBoxiDoldur<Kisi>(kisiler);
        }

        private void BtnKisiOlustur_Click(object sender, EventArgs e)
        {
            kisiler = new Kisi[3]
            {
                new Kisi("Ali","Veli"),
                new Kisi("Ayşe","Fatma"),
                new Kisi("Ahmet","Mehmet"),
            };
            ListBoxiDoldur<Kisi>(kisiler);

        }


    }
}
