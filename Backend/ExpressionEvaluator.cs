using System.Globalization;
namespace Backend;

public static class ExpressionEvaluator
{
    public static double Evaluate(string infix) => EvaluatePostfix(ToPostfix(infix));

    private static List<string> ToPostfix(string infix)
    {
        var postfix = new List<string>();
        var stack = new Stack<char>();
        for (int i = 0; i < infix.Length; i++)
        {
            char item = infix[i];
            if (char.IsDigit(item) || item == '.')
            {
                string num = string.Empty;
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    num += infix[i++];
                }
                i--;
                postfix.Add(num);
            }
            else if (IsOperator(item))
            {
                if (item == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix.Add(stack.Pop().ToString());
                    }
                    if (stack.Count > 0) stack.Pop();
                }

                else
                {
                    while (stack.Count > 0 && PriorityStack(stack.Peek()) >= PriorityInfix(item))
                    {
                        postfix.Add(stack.Pop().ToString());
                    }
                    stack.Push(item);
                }
            }
        }
        while (stack.Count > 0)
        {
            postfix.Add(stack.Pop().ToString());
        }
        return postfix;
    }
    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid expression."),
    };

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid expression."),
    };

    private static bool IsOperator(char item) => item == '^' || item == '*' || item == '/' || item == '+' || item == '-' || item == '(' || item == ')';

    private static double EvaluatePostfix(List<string> postfix)
    {
        return 0;
    }

    private static double Calculate(double ope1, double ope2, char item) => item switch
    {
        '*' => ope1 * ope2,
        '/' => ope1 / ope2,
        '+' => ope1 + ope2,
        '-' => ope1 - ope2,
        '^' => Math.Pow(ope1, ope2),
        _ => throw new Exception("Invalid expression."),
    };
}
