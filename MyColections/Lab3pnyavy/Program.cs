using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3pnyavy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>();
            // добавляем четыре элемента
            stack.Push("Kate");
            stack.Push("Sam");
            stack.Push("Alice");
            stack.Push("Tom");
            stack.Push("Peter");

            // извлекаем один элемент
            var head = stack.Pop();
            Console.WriteLine(head);    // Tom

            // просто получаем верхушку стека без извлечения
            head = stack.Peek();
            Console.WriteLine(head);    // Alice
            Console.WriteLine("Количество элементов в стеке " + stack.Count);
            stack.StClear();
            Console.ReadLine();
            
            MyQueue<string> myQueue = new MyQueue<string>();

            // Добавляем элементы
            myQueue.Enqueue("Kate");
            myQueue.Enqueue("Sam");
            myQueue.Enqueue("Alice");
            myQueue.Enqueue("Tom");

            var qhead = myQueue.Dequeue();// Извлечение элемента из очереди.
            Console.WriteLine(qhead);    // 1

            // просто получаем верхушку очереди без извлечения
            qhead = myQueue.Peek(); // Просмотр элемента на вершине очереди.  
            Console.WriteLine(qhead);    // 2

            Console.WriteLine("Количество элементов в очереди " + myQueue.Count);
            myQueue.Clear();
            Console.ReadKey();

            MyArray<string> myArray = new MyArray<string>();
            myArray.Add("John");
            myArray.Add("Sam");
            myArray.Add("Peter");
            myArray.Remove(2);
            var elem = myArray.Show(2);
            Console.WriteLine("\nВывод элемента " + elem);
            Console.WriteLine("Количество элементов в массиве " + myArray.Count);
            Console.ReadKey();

        }  
    }
}
