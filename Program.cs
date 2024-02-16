using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
                CMatrix cm1 = new CMatrix (2, 2);
                CMatrix cm2 = new CMatrix (4, 4);
                
                Complex [] cm1Data = new Complex [] // data copied from Matlab
                {
                    new Complex ("   0.6897 +  0.2305i"), 
                    new Complex ("   0.9545 +  0.7410i"),
                    new Complex ("   0.1721 +  0.3898i"),
                    new Complex ("   0.2276 +  0.7689i"),
                };

                Complex [] cm2Data = new Complex [] // data copied from Matlab
                {
                    new Complex ("  0.1522 +  0.6552i"),
                    new Complex ("   0.7623 +  0.9862i"),
                    new Complex ("   0.9112 +  0.6565i"),
                    new Complex ("   0.4618 +  0.9132i"),
                    new Complex ("   0.2661 +  0.1018i"),
                    new Complex ("   0.0484 +  0.0395i"),
                    new Complex ("   0.3236 +  0.5196i"),
                    new Complex ("   0.0204 +  0.2899i"), 
                    new Complex ("   0.7189 +  0.2515i"),
                    new Complex ("   0.9445 +  0.4942i"),
                    new Complex ("   0.1273 +  0.9954i"),
                    new Complex ("   0.0756 +  0.3774i"),
                    new Complex ("   0.7457 +  0.3774i"),
                    new Complex ("   0.0089 +  0.4399i"),
                    new Complex ("   0.5407 +  0.0840i"),
                    new Complex ("   0.4398 +  0.6215i") 
                };

                cm1.FillByColumn (cm1Data);
                cm2.FillByColumn (cm2Data);


                //for (int i=0; i<cm1.Rows; i++)
                //    for (int j=0; j<cm1.Cols; j++)
                //        cm1 [i, j] = new Complex (i + 3, j + 2);

                //for (int i=0; i<cm2.Rows; i++)
                //    for (int j=0; j<cm2.Cols; j++)
                //        cm2 [i, j] = new Complex (i + 1, j + 1);

                List<CMatrix> results = new List<CMatrix> ()
                {
                    cm1,
                    cm2,
                    //cm1 * cm2,
                    //cm2 * cm1,
                    //cm1 * CMatrix.Transpose (cm1),
                    CMatrix.Inverse (cm1),
                    CMatrix.Inverse (cm2),
                    CMatrix.Inverse (cm1) * cm1,
                    CMatrix.Inverse (cm2) * cm2,
                };

                foreach (CMatrix m in results)
                {
                    Console.WriteLine (m.GetType ());
                    Console.WriteLine (m);
                    Console.WriteLine ();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine ("Exception: " + ex.Message);
                Console.WriteLine ("Exception: " + ex.StackTrace);
            }
        }
    }
}
