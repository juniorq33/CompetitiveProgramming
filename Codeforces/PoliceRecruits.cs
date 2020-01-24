using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    
namespace Police_Recruits___Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int[] temp = line.Split(' ').Select( x => int.Parse(x)).ToArray();
    
            Stack<int> stack = new Stack<int>();
    
            for (int i = 0; i < temp.Length; i++)
            {
    
                    if (stack.Count > 0 && stack.Peek() > 0)
                    {
                        int aux = stack.Pop();
                        aux+=temp[i];
                        if (aux > 0)
                        {
                            stack.Push(aux);
                        }
                    }
                    else
                    {
                        stack.Push(temp[i]);
                    }
                }
    
            if (stack.Count > 0 && stack.Peek() > 0)
            {
                stack.Pop();
    
            }
    
    
            Console.WriteLine(stack.Count);
            
    
        }
    }
}