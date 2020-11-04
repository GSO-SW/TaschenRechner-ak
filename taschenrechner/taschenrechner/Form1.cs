using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taschenrechner
{
    public partial class Form1 : Form
    {
        static double zahl, zahl2, ergebnis;

        static char op;

        public Form1()
        {

            InitializeComponent();
            tbxop.Enabled = false;
            tbxergebnis.Enabled = false;

        }



        private void btngleich_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case '+':
                    ergebnis = zahl + zahl2;
                    break;
                case '-':
                    ergebnis = zahl - zahl2;
                    break;
                case '/':
                    ergebnis = zahl / zahl2;
                    break;
                case '*':
                    ergebnis = zahl * zahl2;
                    break;
                default:
                    MessageBox.Show("geht nicht such dir ein op aus");
                    break;
            }

            tbxergebnis.Text = Convert.ToString(ergebnis);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            op = '+';
            tbxop.Text = "+";

        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            op = '-';
            tbxop.Text = "-";

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            op = '*';
            tbxop.Text = "*";

        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            op = '/';
            tbxop.Text = "/";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxzahl1.Clear();
            tbxzahl2.Clear();
            tbxergebnis.Clear();
            op = ' ';
            zahl = 0;
            zahl2 = 0;
            ergebnis = 0;

        }

        private void tbxzahl1_TextChanged(object sender, EventArgs e)
        {
            if (tbxzahl1.Text != "")
            {
                zahl = Convert.ToDouble(tbxzahl1.Text);
            }

            //bool hatZahl = true;

         

            //foreach (char c in tbxzahl1.Text)
            //{
        
            //    if (char.IsDigit(c) == true)
            //    {
            //        hatZahl = true;
            //    }

            //}
            //if (hatZahl == false)
            //{
            //    MessageBox.Show("Bitte nur Zahlen eingeben");
            //}
            //else
            //{
            //    zahl = Convert.ToDouble(tbxzahl1.Text);
            //}

        }

        private void tbxzahl2_TextChanged(object sender, EventArgs e)
        {
            if (tbxzahl2.Text != "")
            {
                zahl2 = Convert.ToDouble(tbxzahl2.Text);
            }
            //bool hatZahl = true;

            //foreach (char c in tbxzahl2.Text)
            //{
            //    //Methode IsDigit gibt true zurück, wenn es sich um eine Zahl handelt 
            //    if (char.IsDigit(c) == true)
            //    {
            //        hatZahl = true;
            //    }

            //}
            //if (hatZahl == false)
            //{
            //    MessageBox.Show("Bitte nur Zahlen eingeben");
            //}
            //else
            //{
            //    zahl2 = Convert.ToDouble(tbxzahl2.Text);
            //}
        }
    }
}
