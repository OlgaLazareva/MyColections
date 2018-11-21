using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3pnyavy
{
    abstract class Node<T> // Модификатор abstract в определении класса позволяет указать, что класс может быть только базовым классом для других классов. Нельзя создавать экземпляр базового класса
    { 
        protected T[] items; // элементы 
        protected int count;  // количество элементов
        public const int n = 10;
        public int Count //параметр для вывода размера (метод для получения колличества элементов)
        {
            get
            {
                return count;
            }
        }


        public bool IsEmpty() // проверка на пустоту
        {
            return head == 0; //(если в голове пуст.элемент то возращ. true )
        }


    }
}
