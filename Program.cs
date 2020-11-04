using System;
using System.Collections.Generic;
/* Lab - 5.	Stack of Strings
 * Date: 04 Nov 2020
 * Create a class StackOfStrings which can store only strings and has the following functionality:
•	Private field: data: List<string>
•	Public method: Push(string item): void
•	Public method: Pop(): string
•	Public method: Peek(): string
•	Public method: IsEmpty(): bool

*/

namespace StackOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StackOfStrings");
            StackOfStrings sos = new StackOfStrings();
            int n;
            do
            {
                Console.WriteLine("Enter any option in stack");
                Console.WriteLine("1. push 2. pop 3. peek 4. IsEmpty 5. End");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter String to push");
                        sos.push(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("poped string is :" + sos.pop());
                        break;
                    case 3:
                        Console.WriteLine("peek string is :" + sos.peek());
                        break;
                    case 4:
                        if (sos.isEmpty())
                            Console.WriteLine("stack is empty");
                        else
                            Console.WriteLine("stack is not empty");
                        break;
                    case 5:
                        break;
                }

            } while (n != 5);
        }
    }
    class StackOfStrings
    {
        private int index;
        private List<String> data;
        public StackOfStrings()
        {
            data = new List<string>();
            index = -1;
        }
        public void push(String item)
        {
            data.Add(item);
            index++;

        }
        public String pop()
        {

            String top = data[index];
            data.RemoveAt(index);
            index--;
            return top;
        }

        public String peek()
        {
            return data[index];
        }
        public bool isEmpty()
        {
            if (data.Count == 0)
            {
                return true;
            }
            else
                return false;

        }

    }
}
