using System;
using System.Collections.Generic;
using System.Windows;
using System.Text;
using System.Threading.Tasks;

using CommonMath;

namespace CommonMathUT
{
    class Program
    {
        static void Main (string [] args)
        {
            try
            {
                Matrix3x3 m33 = new Matrix3x3 ();

                m33.FillOneColumn (0, new List<double> {1, 2, 3});
                m33.FillOneColumn (1, new List<double> {10, 20, 30});
                m33.FillOneColumn (2, new List<double> {100, 200, 300});

                ColumnVector v3 = new ColumnVector (3);

                v3.FillByColumn (new double [] {23, 34, 56 });

                ColumnVector v = new ColumnVector (m33 * v3);

                Console.WriteLine ("{0:0.00}", v);
            }

            catch (Exception ex)
            {
                Console.WriteLine ("Exception: " + ex.Message);
            }
        }
    }
}
