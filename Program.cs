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
                // source points
                PointXYZ car = new PointXYZ (-7, 5, 3);
                PointSph sph = new PointSph (5, -30, 120);
                PointCyl cyl = new PointCyl (3, -25, 9);

                ICartesian src = sph;

                Console.WriteLine ("Source: " + src);

                PointCyl s2 = new PointCyl (src);
                Console.WriteLine ("Dest: " + s2);
                
                s2.Y += 2;
                Console.WriteLine ("Dest: " + s2);


            }

            catch (Exception ex)
            {
                Console.WriteLine ("Exception: " + ex.Message);
            }
        }
    }
}
