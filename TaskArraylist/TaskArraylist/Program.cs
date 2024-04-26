using System.Collections.Generic;
using TaskArraylist;

internal class Program
{
    public static void Main(string[] args)
    {
        Arraylist arraylist = new Arraylist()
           {
            "Pasha",
            "Ali",
            "Hello",
            24,
            23,
            20
            
           };
        arraylist.Remove("Hello");
        arraylist.Remove(20);
        arraylist.TrimToSize();
        arraylist.Add("Car");
        Console.WriteLine(arraylist._arr.Length);
        Console.WriteLine(arraylist.Count);
    }
}
