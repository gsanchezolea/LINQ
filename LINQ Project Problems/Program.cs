using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project_Problems
{
    class Program
    {
        static void Main(string[] args)
        {


            //*****************************************************************************************************
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var WordWithTh = words.Where(w => w.Contains("th"));
            //foreach (var word in WordWithTh)
            //{
            //    Console.WriteLine(word);
            //}

            ////*****************************************************************************************************
            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //var DistinctNameList = names.Distinct();
            //foreach (var name in DistinctNameList)
            //{
            //    Console.WriteLine(name);
            //}
            //List<int> NewList = new List<int>();
            //*********************************************************************************************************
            //List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            //foreach (var item in classGrades)
            //{
            //    var temparray1 = item.Split(',').Select(int.Parse).ToArray().OrderByDescending(g => g);
            //    var temparray2 = temparray1.Take(temparray1.Count() - 1);
            //    foreach (var item2 in temparray2)
            //    {
            //        NewList.Add(item2);
            //    }

            //}
            //double total = NewList.Sum();
            //double result = total / NewList.Count();
            //Console.WriteLine(result);
            //**********************************************************************************************************
            string name = "Terrill";

            var NameCharList = name.Split().Select(char.Parse).ToList();
            var DistinctCharList = NameCharList.Select()

        }





    }
}

