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
        static bool RunTest1 = true;
        static bool RunTest2 = true;

        static bool ExitAfterOneTest = false;

        static void Main (string [] _)
        {
            try
            {
                if (RunTest1)
                { 
                    Console.WriteLine ("Test1");

                    Complex c1 = new Complex (1, 2);
                    Complex c2 = new Complex (3, 4);
                    Complex c3 = c1 + c2;

                    List<Complex> test1 = new List<Complex> ()
                    {
                        c1,
                        c1 ^ 2.5,
                        //c2,
                        //c3,
                    };

                    foreach (var m in test1)
                    {
                        Console.WriteLine (m.GetType ());
                        Console.WriteLine (m);
                        Console.WriteLine ();
                    }
                    
                    if (ExitAfterOneTest)
                        return;
                }


                if (RunTest2)
                { 
                    Console.WriteLine ("Test2");

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
                        new Complex ("  0.3759 +  0.8670i"),
                        new Complex ("  0.0183 +  0.2714i"),
                        new Complex ("  0.9134 +  0.2174i"),
                        new Complex ("  0.3580 +  0.6897i"),
                        new Complex ("  0.7604 +  0.2305i"),
                        new Complex ("  0.8077 +  0.1721i"),
                        new Complex ("  0.0990 +  0.3898i"),
                        new Complex ("  0.4972 +  0.9545i"), 
                        new Complex ("  0.3478 +  0.7410i"),
                        new Complex ("  0.0276 +  0.2276i"),
                        new Complex ("  0.5313 +  0.7689i"),
                        new Complex ("  0.9958 +  0.1522i"),
                        new Complex ("  0.2079 +  0.6552i"),
                        new Complex ("  0.4921 +  0.2661i"),
                        new Complex ("  0.7597 +  0.1018i"),
                        new Complex ("  0.3365 +  0.7189i") 
                    };

                    cm1.FillByColumn (cm1Data);
                    cm2.FillByColumn (cm2Data);

                    List<CMatrix> test2 = new List<CMatrix> ()
                    {
                        //cm1,
                        //cm2 / 3,
                        new Complex (3, 2) / cm2,  
                        //cm1 * CMatrix.Transpose (cm1),
                        //CMatrix.Inverse (cm1),
                    };

                    foreach (var m in test2)
                    {
                        Console.WriteLine (m.GetType ());
                        Console.WriteLine (m);
                        Console.WriteLine ();
                    }
                    
                    if (ExitAfterOneTest)
                        return;
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
