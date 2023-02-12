using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LineComparison
    {
        public static void Comparison()
        {
            int lengthx1 = 0, lengthy1 = 0, lengthx2 = 0, lengthy2 = 0;
            double lineX=0,lineY=0 , Linelength1 =0;

            Console.WriteLine("Enter the length of lengthx1 and lengthx2");
            lengthx1 = Convert.ToInt32(Console.ReadLine());
            lengthx2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of lengthy1 and lengthy2");
            lengthy1= Convert.ToInt32(Console.ReadLine());
            lengthy2= Convert.ToInt32(Console.ReadLine());
            //Calculating Cartesian points
            lineX = Math.Pow(lengthx2-lengthx1, 2); 
            lineY = Math.Pow(lengthy2-lengthy1, 2);
            Console.WriteLine("The length of Cartesian point lineX:"+lineX);
            Console.WriteLine("The length of Cartesian point lineY:" +lineY);
            //Calculating length of the line
            Linelength1 = Math.Sqrt(lineX + lineY);
            Console.WriteLine("The length of Line using cartesian points is :" + Linelength1);
        }
    }
}
