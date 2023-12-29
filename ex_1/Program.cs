// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int sum(int n)
{
    if (n <= 0) return 0;
    return n + sum(n - 1);
}

System.Console.WriteLine(sum(7));



Console.WriteLine("Hello, World!");


var result = ReverseString("Hello");
Console.WriteLine(result); // Returns 'olleH'

string ReverseString(string value)
{
    int length = value.Length;

    var reversedArray = new char[length];

    foreach (var letter in value)
    {
        length = length - 1;
        reversedArray[length] = letter;
    }

    return string.Concat(reversedArray);
}
