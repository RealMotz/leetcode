using System.Diagnostics;
using code.Algorithms;
using code.DataStructures;

class Program {
    static void Main(string[] args) {
        // TwoPointers pointers = new TwoPointers();
        // pointers.Rotate(new int[] { 1,2,3,4,5,6,7 }, 3);
        // var x = new int[] { 1,2,3,4,5,6,7 };
        // Array.Reverse(x, 0, x.Length);
        // foreach (var i in x) {
        //     Console.Write($"{i}, ");
        // }

        // var recursion = new Recursion();
        // var c = new char[] { 'h', 'o', 'l', 'a'};
        // // recursion.ReverseString2(c, 0);
        // int x = 0;
        // Console.WriteLine(c[x++..c.Length]);
        // Console.WriteLine(x);
        // Console.WriteLine(c[c.Length..c.Length]);

        var dynamic = new DynamicProgramming();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        dynamic.HowSum(300, new List<int>() { 7, 14 }, new Dictionary<int, List<int>?>());
        stopwatch.Stop();
        Console.WriteLine("Elapsed Time: {0}", stopwatch.Elapsed);
    }
}