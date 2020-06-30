using System.Collections.Generic;

namespace InterpreterPatternDemo
{
    class Evaluator
    {
        public RpnExpression Parse(string text)
        {
            Stack<RpnExpression> stack = new Stack<RpnExpression>();
            string[] words = text.Split(' ');
            foreach(var word in words)
            {
                RpnExpression lhs = null, rhs = null;
                switch(word)
                {
                    case "+":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Add(lhs, rhs));
                        break;
                    case "-":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Subtract(lhs, rhs));
                        break;
                    case "*":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Multiply(lhs, rhs));
                        break;
                    case "/":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Divide(lhs, rhs));
                        break;//Above are Non-Terminal expression
                    default:
                        int number = int.Parse(word);
                        stack.Push(new Number(number));
                        break;//This is terminal expression
                }
            }
            return stack.Pop();
        }
    }
}
