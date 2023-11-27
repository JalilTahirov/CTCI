// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int sum(int n)
{
    if (n <= 0) return 0;
    return n + sum(n - 1);
}

System.Console.WriteLine(sum(7));
