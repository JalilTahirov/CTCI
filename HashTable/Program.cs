using System.Collections;
using System.Reflection;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var myStruct = new MyStruct();

            myStruct.name = "Jalil ";
            //var myValue = myStruct.secretSecret();
            //Console.WriteLine(myValue);

            //myStruct = null;

            //myStruct.SomeMethod();

            // Test_HashTable_NumberNames();
            Test_Hashtable_Students();
        }


        static void Test_HashTable_NumberNames()
        {
            Hashtable numbers = new Hashtable();

            numbers.Add("100", "one");
            numbers.Add(2, "two");
            numbers.Add(3, "three");
            numbers.Add(4, "four");
            numbers.Add(5, "five");

            foreach (DictionaryEntry de in numbers)
            {
                var hash = de.Key.GetHashCode();

                Console.WriteLine("Key: {0}, Value: {1}, hashCode: {2}", de.Key, de.Value, hash);
            }
        }

        static void Test_Hashtable_Students()
        {
            var students = new Hashtable();
            //int[] table = (int[])students.GetType().GetField("_buckets", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(students);
            //Console.WriteLine(table.Length);

            students.Add("100", "Bob");
            students.Add("123", "Sponge");
            students.Add("144", "Viola");

            foreach (DictionaryEntry de in students)
            {
                var hash = de.Key.GetHashCode();

                Console.WriteLine("Key: {0}, Value: {1}, hashCode: {2}", de.Key, de.Value, hash);
            }
        }
    }
}
