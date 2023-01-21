using Services;
using System.Collections;



var stack = new Stack<string>();
stack.Push("1 Kaoutar");
stack.Push("2 khalid");
stack.Push("3 Ayoub");

foreach (var item in stack.OrderBy(a => a))
{
    Console.WriteLine(item);
}

//Remove
stack.Pop();
foreach (var item in stack)
{
    Console.WriteLine(item);
}



var q = new Queue();
q.Enqueue("Je suis le 1");
q.Enqueue("Je suis le 2eme");
q.Enqueue("Je Suis le 3 eme");
q.Enqueue(null);

Console.WriteLine("Tapez votre classement :");

q.Enqueue(Console.ReadLine());



foreach (var item in q)
{
    Console.WriteLine(item);
}


q.Dequeue();
q.Dequeue();

foreach (var item in q)
{
    Console.WriteLine(item);
}


Console.ReadKey();