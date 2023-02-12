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
            int lengthx1 = 0, lengthy1 = 0, lengthx2 = 0, lengthy2 = 0 , lengthA1=0, lengthA2 = 0, lengthB1 = 0, lengthB2 = 0;
            double lineX=0,lineY=0, Linelength1 =0, lineA=0, lineB =0,Linelength2 = 0;

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

            Console.WriteLine("Enter the length of lengthA1 and lengthA2");
            lengthA1 = Convert.ToInt32(Console.ReadLine());
            lengthA2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of lengthB1 and lengthB2");
            lengthB1 = Convert.ToInt32(Console.ReadLine());
            lengthB2 = Convert.ToInt32(Console.ReadLine());
            //Calculating Cartesian points
            lineA = Math.Pow(lengthA2 - lengthA1, 2);
            lineB = Math.Pow(lengthB2 - lengthB1, 2);
            Console.WriteLine("The length of Cartesian point lineY :" +lineA);
            Console.WriteLine("The length of Cartesian point lineB :" +lineB);
            //Calculating length of the line
            Linelength2 = Math.Sqrt(lineA + lineB);
            Console.WriteLine("The length of Line using cartesian points is :" +Linelength2);

            //Comparing two lengths of line using equal operator
            if(Linelength1 == Linelength2)
            {
                Console.WriteLine("\nBoth the lines are equal");
            }
            else if(Linelength1 > Linelength2)
            {
                Console.WriteLine("\nLine one is greater than line second");
            }
            else
            {
                Console.WriteLine("\nBoth the lines are not equal");
            }

            //Compairing two length of line using CompareTo() method
            Console.WriteLine("\nCompaired length will be:"+Linelength1.CompareTo(Linelength2));
        }
    }
}
