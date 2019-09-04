using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFourDayTwoHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork hw = new HomeWork();
            Console.WriteLine("Accessing array element at 2,3,7: {0}", hw.GetElementAt(2,3,7));
            Console.WriteLine("List aggregate: {0}",hw.GetAggregate());
            hw.DisplayDictionary();
            Console.WriteLine("Sum of first 10 element to dequeue from queue: {0}", hw.DequeueAndSum());
            Console.WriteLine("Sum of first 10 element to pop from stack: {0}", hw.PopAndSum());
            Console.Read();
        }
    }

    class HomeWork
    {
        private int[,,] threeDArray;
        private List<int> myList;
        private Dictionary<string, string> myDictionary;
        private Queue<int> myQueue;
        private Stack<int> myStack;
        
        public HomeWork()
        {
            threeDArray = new int[10,10,10];
            populateArray();

            myList = new List<int>();
            cpyArrayToList();

            myDictionary = new Dictionary<string, string>();
            populateDictionary();

            myQueue = new Queue<int>();
            myStack = new Stack<int>();
            populateQueueAndStack();
        }

        private void populateArray()
        {
            for(int i = 0; i < threeDArray.GetLength(0); i++)
            {
                for(int j = 0; j < threeDArray.GetLength(1); j++)
                {
                    for(int k = 0; k < threeDArray.GetLength(2); k++)
                    {
                        threeDArray[i, j, k] = i * j * k;
                    }
                }
            }
        }

        private void cpyArrayToList()
        {
            foreach (int element in threeDArray)
            {
                myList.Add(element);
            }            
        }

        private void populateDictionary()
        {
            myDictionary.Add("USA", "Washington DC");
            myDictionary.Add("China", "Beijing");
            myDictionary.Add("Russian", "Moscow");
            myDictionary.Add("England", "London");
            myDictionary.Add("Germany", "Berlin");
            myDictionary.Add("Japan", "Tokyo");
            myDictionary.Add("Australia", "Sydney");
            myDictionary.Add("Hungary", "Budapest");
            myDictionary.Add("Thailand", "Bankok");
            myDictionary.Add("Scotland", "Edinburg");
        }

        private void populateQueueAndStack()
        {
            for (int i = 1; i <= 100; i++)
            {
                int product = i * i * i;
                myQueue.Enqueue(product);
                myStack.Push(product);
            }
        }

        public int GetElementAt(int i, int j, int k)
        {
            return threeDArray[i, j, k];
        }

        public int GetAggregate()
        {
            return myList.Aggregate((x, y) =>
            {
                return x + y;
            });
        }

        public void DisplayDictionary()
        {
            foreach (KeyValuePair<string, string> entry in myDictionary)
            {
                Console.WriteLine("Country: {0} , Capital: {1}", entry.Key, entry.Value);
            }
        }

        public Dictionary<string, string> GetDictionary()
        {
            return myDictionary;
        }

        public int DequeueAndSum()
        {
            int sum = 0;
            for(int i = 0; i < 10; i++)
            {
                sum += myQueue.Dequeue();
            }
            return sum;
        }

        public int PopAndSum()
        {
            int sum = 0;
            for(int i = 0; i < 10; i++)
            {
                sum += myStack.Pop();
            }
            return sum;
        }

    }
}
