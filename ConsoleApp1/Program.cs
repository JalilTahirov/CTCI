// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*Let's introduce the concept - if there is an element in a linked list that refers to NULL, there is no cycle.
If there is an element that refers to any of the previous ones or to itself, then the cycle exists.
the architect gave the interface:
interface LLI {LLI next();}
where next() returns the next element
task: write a function bool hasCycle(LLI lli)
which takes an element of a linked list and returns true if there is a cycle in this list, and false if there is no cycle*/



interface LLI
{
    LLI next();
}


bool hasCycle(LLI lli)
{
    var linkedlisttoarray = new List<LLI>();





    while (true)
    {
        if (lli.next() == null) return false;
        llinext = lli.next();
    }
}


interface IMyService<T>
{
    object GetById(int id);
}



class MyService<T> : IMyService<T>
{
    MyRepo<T> _myrepo;
    public MyService(MyRepo<T> myrepo)
    {
        _myrepo = myrepo;
    }

    object GetById<T>(int id)
    {
        return _myrepo.GetItemById<T>(id);
    }
}


void CheckIfCalls()
{
    var sut = new MyService();

    sut.

}



