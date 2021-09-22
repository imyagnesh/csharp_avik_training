﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // Name             Memory      Generic     Performance              idleFor
    // Array             Low           yes          High                Fix Set of Data/ if you know size of data/ retrive data through index
    // Stack             Low           yes          High                Fix Set of data/ if you dont know size of data/ LILO/ / retrive data through index
    // Queue             Low           yes          High                Fix Set of data/ if you dont know size of data/ FIFO// retrive data through index
    // Dictionary        Low           yes          High                for key value pair data/ to retrive data base on key// retrive data through key
    // SortedList        Low           yes          Very High           for key value pair data/ to retrive data base on key/ best for sortig and searching
    // HashTable       Moderate        No           Low                 if you dont know type of data
    // List            Moderate        Yes          Moderate(High)      for large dataset its useful
    // ArrayList        Hight          No           Low                 for large dataset + if you know data type

    // Generics



    // Delegates

    // Error Handling

    // Lambda & Linq

    // Advantages Of generics

    // 1. Increase resusabily 
    // 2. type-safe
    // 3. performace advantages it removes possibilies of boxing and unboxing;

    interface ITemp
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }

    class Temp
    {
        public int id { get; set; }

        public string name { get; set; }
    }

    class DataStore<T> where T : class
    {
        public T Data { get; set; }
    }


    class DataStore1<T> where T : struct
    {
        public T Data { get; set; }
    }

    class DataStore2<T> where T : class, new()
    {
        public T Data { get; set; }
    }


    class KeyValuePair<T, U>
    {
        public T Key { get; set; }

        public U Value { get; set; }
    }

    class Store<T>
    {
        // 
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if(index >= 0 && index < 10)
            {
                _data[index] = item;
            }
        }

        public void AddOrUpdate(T data1, T data2)
        {
            Console.WriteLine(data1);
            Console.WriteLine(data2);
        }

        public void AddOrUpdate<U>(T data1, U data2)
        {
            Console.WriteLine(data1);
            Console.WriteLine(data2);
        }


        public T GetData(int index)
        {
            if(index >=0 && index < 10)
            {
                return _data[index];
            }
            else
            {
                return default(T);
            }
        }
    }

    class Stokes
    {
        public string key { get; set; }

        public string name { get; set; }

        public string sector { get; set; }

        public string country { get; set; }
    }

    class Generics
    {
        static void Main(string[] args)
        {

            List<Stokes> lstStokes = new List<Stokes>()
            {
                new Stokes(){ key = "inf", name = "infosys", sector = "IT", country = "india" },
                new Stokes(){ key = "rel", name = "reliance", sector = "chemical", country = "india" },
                new Stokes(){ key = "mic", name = "microsoft", sector = "IT", country = "US" },
                new Stokes(){ key = "ola", name = "Ola", sector = "Auto", country = "india" }
            };

            Dictionary<string, Stokes> dst = new Dictionary<string, Stokes>();
            dst.Add("inf", new Stokes() { key = "inf", name = "infosys", sector = "IT", country = "india" });

            dst.ContainsKey("inf")





            lstStokes.ForEach(item =>
            {

            })
            


            //SortedList<int, string> lst = new SortedList<int, string>();

            //lst.Add(3, "Three");
            //lst.Add(1, "One");

            //foreach (var item in lst)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            //}

            // LILO
            Stack<int> myStack = new Stack<int>();

            myStack.Push(1);
            myStack.Push(2);

            myStack.Pop();

            //FIFo

            Queue<int> myQ = new Queue<int>();

            myQ.Enqueue(1);
            myQ.Enqueue(2);

            myQ.Dequeue();


            Hashtable names = new Hashtable();

            names.Add("abc", 2);

            //Temp temp = new Temp();
            //Console.WriteLine("i: " + temp.id);
            //Console.WriteLine("i: " + temp.name);



            //Store<int> empIds = new Store<int>();
            //empIds.AddOrUpdate(0, 50);
            //empIds.AddOrUpdate(1, 65);
            //empIds.AddOrUpdate(2, 89);

            //Store<float> ids = new Store<float>();


            //empIds.AddOrUpdate<string>(0, "hello");

            //Console.WriteLine(empIds.GetData(0));
            //Console.WriteLine(empIds.GetData(11));

            //Store<string> cities = new Store<string>();

            //cities.AddOrUpdate(0, "Mumbai");
            //cities.AddOrUpdate(1, "Singapore");

            //Console.WriteLine(cities.GetData(1));


            //DataStore<string> strStore = new DataStore<string>();
            //DataStore<Temp> strore = new DataStore<Temp>();
            //DataStore<ITemp> strore = new DataStore<ITemp>();
            //DataStore<IEnumerable> store = new DataStore<IEnumerable>();
            //DataStore<ArrayList> store = new DataStore<ArrayList>();

            //DataStore<int> store = new DataStore<int>();

            //DataStore1<int> ds1 = new DataStore1<int>();
            //DataStore1<char> ds2 = new DataStore1<char>();


            //DataStore2<Temp> ds2 = new DataStore2<Temp>();






            //strStore.Data = "hello";


            //DataStore<int> intStore = new DataStore<int>();

            //intStore.Data = 3;

            //Console.WriteLine(strStore.Data);

            //Console.WriteLine(intStore.Data);

            //KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            //kvp1.Key = 1;
            //kvp1.Value = "Hello...";

            //KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            //kvp2.Key = "one";
            //kvp2.Value = "How are you?";

            //Console.WriteLine(kvp1.Key + " " + kvp1.Value);

            //Console.WriteLine(kvp2.Key + " " + kvp2.Value);

            //var arrList1 = new ArrayList();
            //arrList1.Add(1);
            //arrList1.Add("Yagnesh");
            //arrList1.Add(true);
            //arrList1.Add(4.5);

            //arrList1.Remove(4.5);

            //arrList1.RemoveAt(1);
            //arrList1.RemoveRange(0, 2);

            //arrList1.Contains(1);

            //arrList1.Contains("Yagnesh");


            // IEnurables
            // ICollection
            // Ilist
            // Arralist



            //for (int i = 0; i < arrList1.Count; i++)
            //{
            //    Console.WriteLine(arrList1[i]);
            //}


            //List<int> lst = new List<int>();


        }
    }
}