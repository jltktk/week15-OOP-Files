using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {

        class WishList
        {
            string person;
            string wish;
            
            //constructor
            public WishList(string _person, string _wish)
            {
                person = _person;
                wish = _wish;               
            }

            //getters for WishList

            public string Person
            {
                get { return person; }
            }

            public string Wish
            {
                get { return wish; }
            }           

        }



        static void Main(string[] args)
        {
            List<WishList> christmasWishes = new List<WishList>();
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                WishList newWish = new WishList(tempArray[0], tempArray[1]);
                christmasWishes.Add(newWish);
            }

            foreach (WishList wishFromList in christmasWishes)
            {
                Console.WriteLine($"{wishFromList.Person} wants {wishFromList.Wish} for Chrsitmas.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }




        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\J\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
