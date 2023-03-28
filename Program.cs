using System;
class Program{
    static void Main (string[]args){
        double x1, x2, x3, y1, y2, y3;
        x1 =double.Parse(Console.ReadLine());
        y1 =double.Parse(Console.ReadLine());
        x2 =double.Parse(Console.ReadLine());
        y2 =double.Parse(Console.ReadLine());
        x3 =double.Parse(Console.ReadLine());
        y3 =double.Parse(Console.ReadLine());

        double H, K, r;
        H = ((y2 - y1) * (y3 * y3 - y1 * y1 + x3 * x3 - x1 * x1) + (y3 - y1) * (y1 * y1 - y2 * y2 + x1 * x1 - x2 * x2)) / (2 * (x3 - x1) * (y2 - y1) - 2 * (x2 - x1) * (y3 - y1));
        K = ((x2 - x1) * (x3 * x3 - x1 * x1 + y3 * y3 - y1 * y1) + (x3 - x1) * (x1 * x1 - x2 * x2 + y1 * y1 - y2 * y2)) / (2 * (y3 - y1) * (x2 - x1) - 2 * (y2 - y1) * (x3 - x1));
        r = Math.Sqrt((x1-H)*(x1-H)+(y1-K)*(y1-K));

        Console.WriteLine("Center: ({0},{1})", H, K);
        Console.WriteLine("Radius: {0}",r);
        Console.ReadKey();
    }
}
