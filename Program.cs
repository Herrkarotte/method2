using System;

namespace method2
{
    public class Queue
    {
        int[] arr;
        int size;
        int count;
        public Queue(int s)
        {
            size = s;
            arr = new int[size];
            count = 0;
        }
        public void push(int num)
        {
            arr[count++] = num;
            Console.WriteLine("OK");
        }
        public object pop()
        {
            if (count == 0) return "error";
            int result = arr[0];
            for (int i = 0; i < count; i++)
            {
                arr[i] = arr[i + 1];
            }
            count--;
            return result;
        }
        public object front()
        {
            if (count == 0) return "error";
            return arr[0];
        }
        public int Size()
        {
            return count;
        }
        public void clear()
        {
            count = 0;
        }
        public void exit()
        {
            Console.WriteLine("BYE");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(10);
            while (true)
            {
                Console.Write(": ");
                string input = Console.ReadLine();
                string ch = "";
                string num = "";
                int num2 = 0;
                bool flag = true;
                for (int i = 0; i < input.Length; i++)
                {
                    if (flag && i == input.Length - 1)
                    {
                        ch += input[i];
                        break;
                    }
                    if (input[i] == ' ')
                    {
                        flag = false;
                        continue;
                    }
                    if (flag)
                    {
                        ch += input[i];
                    }
                    else if (!flag)
                    {
                        num += input[i];
                    }
                    if (i == input.Length - 1)
                    {
                        num2 = Convert.ToInt32(num);
                    }
                }

                switch (ch)
                {
                    case "push":
                        queue.push(num2);
                        break;
                    case "pop":
                        Console.WriteLine($"{queue.pop()}");
                        break;
                    case "front":
                        Console.WriteLine($"{queue.front()}");
                        break;
                    case "size":
                        Console.WriteLine($"{queue.Size()}");
                        break;
                    case "clear":
                        queue.clear();
                        break;
                    case "exit":
                        queue.exit();
                        return;
                    default:
                        Console.WriteLine("err");
                        break;
                }
            }
        }
    }
}
