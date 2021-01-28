﻿using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Kayseri");
            sehirler.Add("İzmir");
            sehirler.Add("Giresun");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Bursa");
            sehirler2.Add("Antalya");
            sehirler2.Add("Adana");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T> // Generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }

    }
}