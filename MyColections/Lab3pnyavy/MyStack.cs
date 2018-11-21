using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3pnyavy
{
    class MyStack<T> : Node<T>
    {
        public MyStack() //конструктор с длиной стека n
        {
            head = 0;
            count = 0;
            items = new T[n];
        }

        public MyStack(int length)// конструктор с заданной длиной стека
        {
            items = new T[length];
        }

        public T Pop() //метод взятия с вершины
        {
            if (IsEmpty())
            {
                //ошибка при взятии пустого стека(Overflow)
                throw new InvalidOperationException("Стек пуст");
            }
            T item = items[--head];// определяем элемент который должен выйти
            count--;//уменьшаем количество элементов
            items[head] = default(T); // сбрасываем ссылку
            return item;            
        }


        public void Push(T item) // добавление в стек
        {
            if (head == items.Length) //если переполнение
            {
                var newArray = new T[2 * items.Length];
                Array.Copy(items, 0, newArray, 0, head);
                items = newArray; //просто создаём новый массив с двойным размером
            }
            items[head++] = item; // новый элемент добавляется "сверху"
            count++;// увеличиваем количество
        }

        // просто вывод элемента
        public T Peek()
         {
             if (head == 0)
             { //ошибка при пустом стеке
                 throw new InvalidProgramException();
             }

             return items[head - 1]; // возвращаем элемент с верхушки
         }

        public void StClear() // очистка стека
        {
            if (head < Count)
                Array.Clear(items, head, count);// метод для очистки очереди (массив, начальный индекс, длина массива)
            head = 0;// зануляем значения
            tail = 0;
            count = 0;
        }
    }
}
