using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selectionsort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Int32 i = 0;
        int[] feld = new int[5];

        private void button1_Click(object sender, EventArgs e)
        {
            int eingabe;
            eingabe = Convert.ToInt32(textBox1.Text);

            if (eingabe > 0)
            {
                if (i < 5) feld[i] = eingabe;
                label5.Text = "";
                if (i < 5) i++;
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                label5.Text = "Bitte nur positive Zahlen eingeben";
            }
            label3.Text = Convert.ToString(i + 1);
            string ausgabe = "";
            for (int j = 0; j < 5; j++)
            {
                ausgabe = ausgabe + feld[j] + "\r\n";
            }
            textBox2.Text = ausgabe;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp;

            for (int i = 0; i < 5 - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < 5; j++)
                {
                    if (feld[j] < feld[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    temp = feld[i];
                    feld[i] = feld[minIndex];
                    feld[minIndex] = temp;
                }

                string ausgabe = "";
                for (int j = 0; j < 5; j++)
                {
                    ausgabe = ausgabe + feld[j] + "\r\n";
                }
                textBox2.Text = ausgabe;
            }
        }
    }
}