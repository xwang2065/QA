using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWAssignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            StringBuilder builder = new StringBuilder();
            List<int> threeSides = new List<int> { a, b, c };
            threeSides.Sort();
            
            if (threeSides[0] + threeSides[1] <= threeSides[2])
            {
                builder.Append("no triangle");
            }
            else
            {
                if (threeSides[0] == threeSides[1] && threeSides[1] == threeSides[2])
                {
                    builder.Append("equilateral triangle");
                }
                else if (threeSides[0] == threeSides[1] || threeSides[1] == threeSides[2])
                {
                    builder.Append("isosceles triangle");
                }
                else
                {
                    builder.Append("scalene triangle");
                }
            }

            return builder.ToString();
        }
    }
}
