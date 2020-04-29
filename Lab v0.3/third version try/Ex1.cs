using System;
using System.Collections.Generic;
using MathNet.Numerics.Statistics;
using System.IO;
using third_version_try;

namespace third_version_try
{
	/// <summary>
	/// Grades are entered manually by keyboard
	/// </summary>
	public static class Ex1
	{
		public static void Exercise1()
        {
           var aaa = new List<double>();

            string[] name = new string[100];
            string[] surname = new string[100];
            double[] avg = new double[100];
            double[] hw = new double[100];
            double[] avg1 = new double[100];
            double[] median = new double[100];

            string a1 = "Surname";
            string a2 = "Name";
            string a3 = "Final points(Avg.)";
            string a4 = "Final points(Med.)";


        	Console.WriteLine("You have chosen to enter grades from keyboard");
            Console.WriteLine("Lets go");
            Console.WriteLine("Please input some data: ");
            int count = 0;
            int count1;
            double sum;
            double exam = 0;
            string s1 = "";
            string s2 = "";
            string s3 = "";
            
            while (s1 != "quit") {
                
           	Console.WriteLine("Row #{0}: ", count);
                Console.WriteLine("Surname: ");
                surname[count] = Console.ReadLine();
                Console.WriteLine("Name: ");
                name[count] = Console.ReadLine();
               
                count1 = 0;
                sum = 0;
                double grade;
                
               
                Console.WriteLine("Enter exam grade:");
                exam = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter homework grades, type N when done: ");
               
                s1 = "";
                s2 = "";
               
               while (true)
                {
               	string check;
               	Console.WriteLine("HW #{0} ", count1);
               	check = Console.ReadLine();
               	if(check == "N") break;
                  grade = Convert.ToDouble(check);
                    Console.WriteLine("entered grade: {0}", grade);
                    aaa.Add(grade);
                    count1++;
                }
                
                    
				for (var index = 0; index < aaa.Count; index++)
                {
                    Console.WriteLine(aaa[index]);
                    sum += aaa[index];
                }  
                 avg[count] = (sum / aaa.Count)* 0.3 + exam * 0.7;
                 median[count] = aaa.Median() * 0.3 + exam * 0.7;
                 aaa.Clear();
                  count++;
                 Console.WriteLine("Continue? Y/N");
                    s2 = Console.ReadLine();
                    if (s2 == "N"){	break;
                    }
              Console.WriteLine("count1 = {0}", count1);
              
            }
            
          	
            Console.WriteLine("Would you like average or median in the results table? (A/M)");
            s3 = Console.ReadLine();
            
            if(s3== "A") {
            
            Console.WriteLine("{0,-15:N0} {1,-20:N0} {2,-20:N0} ", a1, a2, a3);
            Console.WriteLine("-----------------------------------------------------");
			      for (int i = 0; i < count; i++)
            	{
			      	Console.WriteLine("{0,-15:N0} {1,-20:N0} {2,-20:N2} ", surname[i], name[i], avg[i]);
           		}    
            } else if (s3 == "M") {
            	Console.WriteLine("{0,-15:N0} {1,-20:N0} {2,-20:N0} ", a1, a2,a4);
            Console.WriteLine("-----------------------------------------------------");
			      for (int i = 0; i < count; i++)
            	{
			      	Console.WriteLine("{0,-15:N0} {1,-20:N0} {2,-20:N2}", surname[i], name[i], median[i]);
           		} 
            }
	
        }
	}
}
