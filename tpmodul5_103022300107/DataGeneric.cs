﻿using System;

namespace DataGenericExample
{

    class DataGeneric<T>
    {
        public T data;

  
        public DataGeneric(T data)
        {
            this.data = data;
        }


        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: Y, dengan Y adalah nilai dari property 'data' kelas tersebut.");
            Console.WriteLine("Data: " + data);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<long> data = new DataGeneric<long>(103022300107);

            data.PrintData();

            Console.ReadLine();
        }
    }
}
