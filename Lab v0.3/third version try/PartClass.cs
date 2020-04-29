/*
 * Created by SharpDevelop.
 * User: Grzes
 * Date: 4/23/2020
 * Time: 11:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace third_version_try
{
	/// <summary>
	/// Class to sort final list and display in a formatted way
	/// </summary>
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
	}

