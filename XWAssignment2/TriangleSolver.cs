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
                builder.Append("No, the numbers cannot form a triangle");
            }
            else
            {
                if (threeSides[0] == threeSides[1] && threeSides[1] == threeSides[2])
                {
                    builder.Append("Yes, the numbers can form a equilateral triangle");
                }
                else if (threeSides[0] == threeSides[1] || threeSides[1] == threeSides[2])
                {
                    builder.Append("Yes, the numbers can form a isosceles triangle");
                }
                else
                {
                    builder.Append("Yes, the numbers can form a scalene triangle");
                }
            }

            return builder.ToString();
        }
    }
}
