using System;
using System.Collections;

namespace HashTableNonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

        //----------------Add Hashtable----------
            ht.Add("Ayaz", "2234");
            ht.Add("Vikash", "2294");
            ht.Add("Arvind", "1253");
            ht.Add("Anup", "4321");
            ht.Add("Ashish", "1234");

            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine($"key:{item.Key},value: {item.Value}");
            //}

            //---------------print only key-------------

            //var key = ht.Keys;
            //foreach(var item in key)
            //{
            //    Console.WriteLine(item);
            //}

            //---------------print only values-------------

            //var value = ht.Values;
            //foreach (var item in value)
            //{
            //    Console.WriteLine(item);
            //}

            //-----------------Hashtable Contains-------------

                // Console.WriteLine(ht.ContainsKey("Vikash"));        //true

                // Console.WriteLine(ht.ContainsKey("Alok"));          //false

            Console.WriteLine(ht.ContainsValue("1234"));               //true

            Console.WriteLine(ht.ContainsValue("8454"));                //false
        }
    }
}
