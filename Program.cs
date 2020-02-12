using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> myList = new List<string>();
            myList.Add("Apple");
            myList.Add("Pear");
            myList.Add("Banana");
            myList.Add("Pineapple");
            myList.Add("Quince");
            myList.Add("Strawberry");
            myList.Add("Plum");
            myList.Add("Goosberry");
            myList.Add("Kiwi");
            myList.Add("Grape");
            myList.Add("Melon");

            //generate list sorted by item length
            List<string> lengthSorted = new List<string>();
            //put a dummy item in that will always be at the end
            lengthSorted.Add("ZZZZZZZZZZZZZZZZZZZZ");
            foreach (string item in myList)
            {
            int i=0;
            foreach (string testItem in lengthSorted)
            {
                if (item.Length <= testItem.Length)
                {
                lengthSorted.Insert(i, item);
                break;
                }
                i++;
            }
            }
            //remove the dummy item
            lengthSorted.RemoveAt(lengthSorted.Count-1);

            //split list in two
            List<string> longHalf = new List<string>();
            List<string> shortHalf = new List<string>();
            int half = myList.Count / 2;
            int itemCounter = 0;
            foreach (string item in lengthSorted)
            {
            if (itemCounter < half)
            {
                shortHalf.Add(item);
            }
            else
            {
                longHalf.Add(item);
            }
            itemCounter++;
            }

            //sort alphabetically
            List<string> alphaSort = new List<string>();
            alphaSort.Add("ZZZZZZZZZZZZZZZZZZZZ");
            foreach (string item in shortHalf)
            {
            int j = 0;
            foreach(string testItem in alphaSort)
            {
                if (String.Compare(item, testItem) < 0)
                {
                    alphaSort.Insert(j, item);
                    break;
                }
                j++;
            }
            }
            alphaSort.RemoveAt(alphaSort.Count-1);
            
            //output results
            int index = 0;
            foreach (string item in alphaSort)
            {
                index++;
                Console.WriteLine("{0}: {1}", index, item);
            }
            Console.WriteLine("");
            foreach (string item in longHalf)
            {
                Console.WriteLine("{0}: {1}", item.Length, item);
            }

        }
    }
}