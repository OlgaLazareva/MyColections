using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3pnyavy
{
    class MyQueue<T> : QueueNode<T>
    {
        
        public MyQueue() // конструктор с длинной по умолчанию n
        {
            head = 0;
            tail = 0;
            count = 0;
            items = new T[n]; //новый массив элементов Т
        }

        public MyQueue(int capacity) // конструктор очереди заданной длины
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException();
            items = new T[capacity];//новый массив элементов Т
            head = 0;
            tail = 0;
            count = 0;
        }


        // Добавление элемента в очередь.
        public void Enqueue(T item)
        {
            if (count == items.Length) // при переполнении очереди нужно увеличить её (схоже с массивом и стеком)
            {
                var newArray = new T[2 * items.Length];
                Array.Copy(items, 0, newArray, 0, count);
                items = newArray; //просто создаём новый массив с двойным размером
            }
            items[tail] = item;// добавляем элемент в хвост
            tail = (tail + 1) % items.Length;// переопределяем хвост новым значением
            count++;// увеличиваем количество элементов
        }

        // Извлечение элемента из очереди.
        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException(); // если пуста очередь выдаем ошибку
            T local = items[head]; // запоминаем элемент который должен выйти из очереди
            items[head] = default(T); // удаляем вышедший элемент
            head = (head + 1) % items.Length; // задаем новый элемент как "голову" очереди
            count--; // уменьшаем количество элементов
            return local; // возвращаем вышедший элемент
        }

        // Просмотр элемента на вершине очереди.  
        public T Peek()
        {
            if (count == 0)// если пуста очередь выдаем ошибку
                throw new InvalidOperationException();
            return items[head]; // просто вывод элемента на вершине очереди
        }
        // Очистка очереди.
        public void Clear()
        {
            if (head < tail) // если голова меньше чем хвост
                Array.Clear(items, head, count); // методы для очистки очереди (массив, начальный индекс, длина массива)
            else
            {
                Array.Clear(items, head, items.Length - head);
                Array.Clear(items, 0, tail);
            }
            head = 0; // зануляем все значения
            tail = 0;
            count = 0;
        }
     
    }
}

