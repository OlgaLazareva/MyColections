using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3pnyavy
{
    class MyArray<T> : Node <T>
    {
        public MyArray() //конструктор с длинной по умолчанию n
        {
            count = 0;
            items = new T[n];
        }

        public MyArray(int length) // конструктор создания массива заданной длины 
        {
            items = new T[length];
        }

        public void Add(T item) // Метод для добавления элемента в массив 
        {
            if (count == items.Length) //если  колличество элементов равно длине масссива (переполнение)
            {
                var newArray = new T[2 * items.Length]; // создаём новый массив в 2 раза больше
                Array.Copy(items, 0, newArray, 0, head);//копируем старый массив в новый
                items = newArray; //просто создаём новый массив с двойным размером
            }
            items[count++] = item; //добавляем новый элемент   
        }

        public void Remove (int i) // удаление элемента из массива по индексу
        {
            for(int j=0; j<count; j++)//пробегаемся по массиву
            {
                items[j] = items[j + 1];//передвигаем элементы
                items[i] = default(T);//заменяем нужный элемент на дефолтный(удаляем)
            }
            count--;// уменьшаем количество элементов в массиве
        }

        public T Show(int i) => items[i]; //просто вывод элемента по индексу

        
    }
}
