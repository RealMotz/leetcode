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

        var recursion = new Recursion();
        recursion.PascalTriangleRow(4);
    }
}