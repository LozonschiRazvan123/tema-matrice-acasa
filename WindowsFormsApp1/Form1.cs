using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct matrice
        {
            public int sumlin, sumcol, maxlin, maxcol, minlin, mincol;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int[,] x = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            matrice[] v = new matrice[4];
            int sumtot = 0; int maxtot = x[0, 0]; int mintot = x[0, 0];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                v[i].sumlin = x[i, 0]; v[i].maxlin = x[i, 0]; v[i].minlin = x[i, 0];
                for (int j = 1; j < x.GetLength(1); j++)
                {
                    v[i].sumlin += x[i, j];
                    sumtot += x[i, j];
                    if (v[i].minlin > x[i, j])
                        v[i].minlin = x[i, j];
                    if (mintot > x[i, j])
                        mintot = x[i, j];
                    if (v[i].maxlin < x[i, j])
                        v[i].maxlin = x[i, j];
                    if (maxtot < x[i, j])
                        maxtot = x[i, j];
                }
            }
            for(int j=0;j<x.GetLength(0);j++)
            {
                v[j].sumcol = x[0, j]; v[j].maxcol = x[0, j]; v[j].mincol = x[0, j];
                for (int i = 1; i < x.GetLength(1); i++)
                {
                    v[j].sumcol += x[i, j];
                    if (v[j].mincol > x[i, j])
                        v[j].mincol = x[i, j];
                    if (v[i].maxcol < x[i, j])
                        v[i].maxcol = x[i, j];
                }
            }
            for(int i=0;i<v.Length;i++)
            {
                Console.WriteLine("Suma pe linia " + (i + 1) + " este " + v[i].sumlin);
                Console.WriteLine("Suma pe coloana " + (i + 1) + " este " + v[i].sumcol);
                Console.WriteLine("Suma elementelor din matrice este " + sumtot);
                Console.WriteLine("Maximul de pe linia " + (i + 1) + " este " + v[i].maxlin);
                Console.WriteLine("Maximul de pe coloana " + (i + 1) + " este " + v[i].maxcol);
                Console.WriteLine("Cel mai mare element din matrice este " + maxtot);
                Console.WriteLine("Minimul de pe linia " + (i + 1) + " este " + v[i].minlin);
                Console.WriteLine("Minimul de pe coloana " + (i + 1) + " este " + v[i].mincol);
                Console.WriteLine("Cel mai mic element din matrice este " + mintot);
            }
            
        }
    }
}
