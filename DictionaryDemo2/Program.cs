using System;

namespace DictionaryDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> arabaMarkaları = new MyDictionary<int, string>();
            arabaMarkaları.Add(1, "BMW");
            arabaMarkaları.Add(2, "Porshe");
            arabaMarkaları.Add(3, "Ford");
            arabaMarkaları.Add(4, "Wolksvagen");
            arabaMarkaları.Add(5, "Ferrari");
            arabaMarkaları.Add(6, "Hundai");
            arabaMarkaları.Add(7, "Honda");


            Console.WriteLine("No: " + arabaMarkaları.Items1[0] + " " + " Markası : " + arabaMarkaları.Items2[0]);
            Console.WriteLine("No: " + arabaMarkaları.Items1[1] + " " + " Markası : " + arabaMarkaları.Items2[1]);
            Console.WriteLine("No: " + arabaMarkaları.Items1[2] + " " + " Markası : " + arabaMarkaları.Items2[2]);
            Console.WriteLine("No: " + arabaMarkaları.Items1[3] + " " + " Markası : " + arabaMarkaları.Items2[3]);
            Console.WriteLine("No: " + arabaMarkaları.Items1[4] + " " + " Markası : " + arabaMarkaları.Items2[4]);
            Console.WriteLine("No: " + arabaMarkaları.Items1[5] + " " + " Markası : " + arabaMarkaları.Items2[5]);
            Console.WriteLine("No: " + arabaMarkaları.Items1[6] + " " + " Markası : " + arabaMarkaları.Items2[6]);





        }
    }
}
