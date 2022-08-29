using System;
using StackUsingLL;

namespace StackUsingLL
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            StackByLinkedList<int> s = new StackByLinkedList<int>();
            int[] arr = { 1, 4, 2, 4, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                s.push(arr[i]);
                Console.WriteLine("size now " + s.Size());
            }
        }
    }
}
