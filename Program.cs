using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

using CommonMath;

namespace CommonMathUT
{
    class Program
    {
        static void Main (string [] args)
        {
            try
            {
                List<Point3D> source = new List<Point3D> () {new Point3D (0, 0, 0), 
                                                             new Point3D (5, 0, 0),
                                                             new Point3D (6, 0, 0),
                                                             new Point3D (9, 0, 0)
                };

                List<Point3D> pts = Interpolation.Linear (source, 7);

                for (int i=0; i<pts.Count; i++)
                    Console.WriteLine (i + ": " + pts [i].X + " " + pts [i].Y + " " + pts [i].Z);
            }

            catch (Exception ex)
            {
                Console.WriteLine ("Exception: " + ex.Message);
            }
        }
    }
}
