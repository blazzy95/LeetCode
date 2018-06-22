using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// 682. Baseball Game
/// </summary>

namespace ConsoleApp4
{
    class BaseballGame
    {
        public static int CalPoints(string[] ops)
        {
            Stack<int> stack = new Stack<int>();
            
            foreach(string s in ops)
            {
                switch(s)
                {
                    case "+" :
                        stack.Push(stack.Take(2).Sum());
                        break;
                    case "D" :
                        stack.Push(stack.Peek() * 2);
                        break;
                    case "C":
                        stack.Pop();
                        break;
                    default:
                        stack.Push(Int32.Parse(s));
                        break;
                }
            }

            return stack.Sum();
        }
    }
}
