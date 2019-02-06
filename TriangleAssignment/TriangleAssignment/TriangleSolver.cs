using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAssignment
{
    public static class TriangleSolver
    {
        public static string Analyze(int S1, int S2, int S3)
        {
            string type = string.Empty;
            
            if ((S1 + S2) > S3 && (S2 + S3) > S1 && (S3 + S1) > S2)
            {
                if ((S1 == S2) && (S2 == S3))
                {
                    type = "Equilateral Triangle";
                }
                else if ((S1 == S2) || (S2 == S3) || (S3 == S1))
                {
                    type = "Isosceles Triangle";
                }
                else if ((S1 != S2) && (S2 != S3))
                {
                    type = "Scalene Triangle";
                }
            }
            else
            {
                type = "not a valid triangle";
            }

                return type;
        }
    }
}
    
