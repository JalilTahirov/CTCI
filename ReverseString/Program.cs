// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var result = Reverse("Jalil");
Console.WriteLine(result);

string Reverse(string value)
{
    var reversedArray = value.Reverse();


    return reversedArray.ToString();
}
