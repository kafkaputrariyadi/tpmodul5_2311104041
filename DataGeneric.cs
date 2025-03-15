using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_2311104041
{
    class DataGeneric<T>
    {
        public T Data { get; set; }

        public DataGeneric(T data)
        {
            Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Mengisi Data dengan NIM (contoh: "12345678")
            DataGeneric<string> dataNIM = new DataGeneric<string>("2311104041");

            dataNIM.PrintData();
        }
    }
}
