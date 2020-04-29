using System;
using System.Collections.Generic;
using MathNet.Numerics.Statistics;
using System.IO;

namespace Empty
{
    class Program
    {
       public static void Main(string[] args)
        {
        	Menu();
        }
public class Part : IEquatable<Part> , IComparable<Part>
{
    public string PartName { get; set; }
	public string PartSurname { get; set; }
    public double PartId { get; set; }
    public double PartId2 { get; set; }
    
    public override string ToString()
    {
    	return String.Format("{0,-15:N0} {1,-20:N0} {2,-20:N2} {3,-20:N2}", PartSurname, PartName, PartId, PartId2);
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Part objAsPart = obj as Part;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }
    public int SortByNameAscending(string name1, string name2)
    {

        return name1.CompareTo(name2);
    }

    // Default comparer for Part type.
    public int CompareTo(Part comparePart)
    {
          // A null value means that this object is greater.
        if (comparePart == null)
            return 1;

        else
            return this.PartId.CompareTo(comparePart.PartId);
    }

    public bool Equals(Part other)
    {
        if (other == null) return false;
        return (this.PartId.Equals(other.PartId));
    }
}


       public static void Menu()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("Welcome to Lab!");
                Console.WriteLine("Please choose one of the following: ");
                Console.WriteLine("1. Enter grades from keyboard");
                Console.WriteLine("2. Generate grades randomly");
                Console.WriteLine("3. Read from file");
                Console.WriteLine("Type TERMINATE if you want to exit the program");
                choice = Console.ReadLine();
                if (choice == "TERMINATE")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else if (choice == "1")
                {
                    //call 1st program
                    Exercise1();
                }
                else if (choice == "2")
                {
                    //call 2nd program
                    Exercise2();
                }
                else if (choice == "3")
                {
                	//call 3rd program
                	Exercise3();
                }
            }
        }

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

        static void Exercise2()
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
          		double b1 = Convert.ToDouble(Console.ReadLine());
          		exam = rand.NextDouble() * 10;
          		Console.WriteLine("Exam: {0,8:N2}", exam);
				for (int ctr = 0; ctr < b1; ctr++){
					grade = rand.NextDouble() * 10;
					aaa.Add(grade);
					Console.WriteLine("{0,8:N2}", grade);
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
        public static void Exercise3(){
        	    List<string> list  = new List<string>();
			    List<double> hwgrades  = new List<double>();
			    List<Part> parts = new List<Part>();
			    string[] surname = new string[100];
			    string[] name = new string[100];
			    double[] exam = new double[100];
			    double[] hw = new double[100];
			    double[] grade = new double[100];
			    string a1 = "Surname";
            string a2 = "Name";
            string a3 = "Final points(Avg.)";
            string a4 = "Final points(Med.)";
    			using(StreamReader sr = new StreamReader("C:\\Users\\Grzes\\Desktop\\Lab3v0.2\\input.txt"))
    {
        string line;
        while((line = sr.ReadLine()) != null)
        {
            string[] words = line.Split(' ');
            foreach(string word in words)
                 list.Add(word);
        }
        
    }
    			for (int i = 0; i < list.Count; i=i+8)
        {
    		exam[i] = Convert.ToDouble(list[i+2]) * 0.7;
    		grade[i] = (Convert.ToDouble(list[i+3]) + Convert.ToDouble(list[i+4]) + Convert.ToDouble(list[i+5]) + Convert.ToDouble(list[i+6]) + Convert.ToDouble(list[i+7]))/ 5 *0.3;
    		
    		hwgrades.Add(Convert.ToDouble(list[i+3]));
    		hwgrades.Add(Convert.ToDouble(list[i+4]));
    		hwgrades.Add(Convert.ToDouble(list[i+5]));
    		hwgrades.Add(Convert.ToDouble(list[i+6]));
    		hwgrades.Add(Convert.ToDouble(list[i+7]));
    		grade[i+1] = hwgrades.Median() * 0.3;

    		parts.Add(new Part() { PartName = list[i+1], PartSurname = list[i], PartId = grade[i] + exam[i], PartId2 = grade[i+1]+exam[i]});
    		hwgrades.Clear();
	

       
        }
		parts.Sort(delegate(Part x, Part y)
        {
            if (x.PartName == null && y.PartName == null) return 0;
            else if (x.PartName == null) return -1;
            else if (y.PartName == null) return 1;
            else return x.PartName.CompareTo(y.PartName);
        });

        Console.WriteLine("After sort by surname:");
        Console.WriteLine("{0,-15:N0} {1,-20:N0} {2,-20:N0} {3,-20:N0}", a1, a2, a3, a4);
        Console.WriteLine("------------------------------------------------------------------------------");
        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }
           Console.WriteLine("------------------------------------------------------------------------------");
    			Console.ReadKey();
        }
    }
}
