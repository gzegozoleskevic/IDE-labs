using System;
using System.Collections.Generic;
using MathNet.Numerics.Statistics;
using System.IO;
using third_version_try;

namespace third_version_try
{
	/// <summary>
	/// Everything is read from file
	/// </summary>
	public static class Ex3
	{
		   public static void Exercise3(){
        	    List<string> list  = new List<string>();
			    List<double> hwgrades  = new List<double>();
			    List<Part> parts = new List<Part>();
			    string[] surname = new string[1000000];
			    string[] name = new string[1000000];
			    double[] exam = new double[1000000];
			    double[] hw = new double[1000000];
			    double[] grade = new double[1000000];
			    string a1 = "Surname";
            string a2 = "Name";
            string a3 = "Final points(Avg.)";
            string a4 = "Final points(Med.)";
            
            
            try {
    			using(StreamReader sr = new StreamReader("C:\\Users\\Grzes\\Desktop\\C# labs\\input10k.txt"))
    {
        string line;
        while((line = sr.ReadLine()) != null)
        {
            string[] words = line.Split(' ');
            foreach(string word in words)
                 list.Add(word);
        }
        
    			} } catch (FileNotFoundException ex) {
            	Console.WriteLine("FileNotFoundException Handler: {0}", ex);
            }
    			for (int i = 0; i < list.Count; i=i+8)
        {
    		
    			try {
    		exam[i] = Convert.ToDouble(list[i+2]) * 0.7;
    		grade[i] = (Convert.ToDouble(list[i+3]) + Convert.ToDouble(list[i+4]) + Convert.ToDouble(list[i+5]) + Convert.ToDouble(list[i+6]) + Convert.ToDouble(list[i+7]))/ 5 *0.3;
    		
    		hwgrades.Add(Convert.ToDouble(list[i+3]));
    		hwgrades.Add(Convert.ToDouble(list[i+4]));
    		hwgrades.Add(Convert.ToDouble(list[i+5]));
    		hwgrades.Add(Convert.ToDouble(list[i+6]));
    		hwgrades.Add(Convert.ToDouble(list[i+7]));
    		grade[i+1] = hwgrades.Median() * 0.3;

    		parts.Add(new Part() { PartName = list[i+1], PartSurname = list[i], PartId = grade[i] + exam[i], PartId2 = grade[i+1]+exam[i]});
    			} catch (IndexOutOfRangeException ex) {
    					Console.WriteLine("IndexOutOfRangeException Handler: {0}",ex);
    			} catch (OutOfMemoryException ex) {
    					Console.WriteLine("OutOfMemoryException Handler: {0}", ex);
    			}
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
    		Console.WriteLine("Press any key to continue...");
           Console.ReadKey();
        }
	}
}
