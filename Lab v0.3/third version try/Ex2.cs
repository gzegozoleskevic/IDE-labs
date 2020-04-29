using System;
using System.Collections.Generic;
using MathNet.Numerics.Statistics;
using System.IO;
using third_version_try;

namespace third_version_try
{
	/// <summary>
	/// Grades are generated randomly in this method.
	/// </summary>
	public static class Ex2
	{
		 public static void Exercise2()
        {
            Console.WriteLine("You have chosen to generate the grades");
           
  			var rand = new Random();
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
                
               Console.WriteLine("How many grades would you like to be random generated?");
               try{
               	
               double b1 = Convert.ToDouble(Console.ReadLine());
               exam = rand.NextDouble() * 10;
               for (int ctr = 0; ctr < b1; ctr++){
					grade = rand.NextDouble() * 10;
					aaa.Add(grade);
					Console.WriteLine("{0,8:N2}", grade);
				}
          		Console.WriteLine("Exam: {0,8:N2}", exam);
               } catch (ArgumentException ex) {
               	Console.WriteLine("ArgumentException Handler: {0}", ex);
               } catch (FormatException ex) {
               		Console.WriteLine("FormatException Handler: {0}", ex);
               }
          		
				

                
                    
				for (var index = 0; index < aaa.Count; index++)
                {
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
