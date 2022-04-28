using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BinarisKeresoFa
{
    abstract class Node
    {
        public char Data { get; }
        public Node Left { get; }
        public Node Right { get; }

        protected Node(Char data, Node left, Node right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        protected Node(char data) : this(data, null, null)
        {
            Data = data;
        }
    }
    class OperandNode : Node
    {
        public OperandNode(char data) : base(data)
        {

        }
    }
    class OperatorNode : Node
    {
        private Operator Operator { get; }

        public OperatorNode(char data, Node left, Node right) : base(data, right, left)
        {
            Operator = (Operator)Enum.Parse(typeof(Operator), Enum.GetName(typeof(Operator), data));
        }
    }

    enum Operator { Add = (int)'+', Sub = (int)'-', Mul = (int)'*', Div = (int)'/', Pow = (int)'^' };

    class BinaryExpressionTree
    {
        private BinaryExpressionTree(Node root)
        {
            Root = root;
        }
        private Node Root { get; }

        static public BinaryExpressionTree Build(string expression)
        {
            char[] tomb = expression.ToCharArray();
            for (int i = 0; i < tomb.Length; i++)
            {
                if (!(char.IsNumber(expression[i])) && !(expression[i] == '+' || expression[i] == '-' || expression[i] == '/' || expression[i] == '*' || expression[i] == '^'))
                {
                    throw new InvalidExpressionException(expression, i);
                }
            }
            return Build(tomb);
        }
        static BinaryExpressionTree Build(char[] expression)
        {
            Stack<Node> Verem = new Stack<Node>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsNumber(expression[i]))
                {
                    OperandNode on = new OperandNode(expression[i]);
                    Verem.Push(on);
                }
                else
                {
                    OperatorNode on = new OperatorNode(expression[i], Verem.Pop(), Verem.Pop());
                    Verem.Push(on);
                }
            }
            BinaryExpressionTree back = new BinaryExpressionTree(Verem.Pop());
            return back;
        }

        string kimenet = "";
        public override string ToString()
        {
            if (Root != null)
            {
                return ToString(Root);
            }
            else
            {
                return "";
            }
        }

        private String ToString(Node node)
        {
            if (node != null)
            {
                ToString(node.Left);
                ToString(node.Right);
                kimenet += node.Data.ToString();
            }
            return kimenet;
        }

        public string Convert()
        {
            if (Root != null)
            {
                return Convert(Root);
            }
            else
            {
                return "";
            }
        }

        string kimenetzarojelekkel = "";

        public string Convert(Node node)
        {
            if (node != null)
            {
                if (node is OperatorNode)
                {
                    kimenetzarojelekkel += '(';
                }
                Convert(node.Left);
                kimenetzarojelekkel += node.Data.ToString();
                Convert(node.Right);
                if (node is OperatorNode)
                {
                    kimenetzarojelekkel += ')';
                }
            }
            return kimenetzarojelekkel;
        }

        public double Evaluate()
        {
            if (Root != null)
            {
                return Evaluate(Root);
            }
            else
            {
                return 0;
            }
        }
        private double Evaluate(Node node)
        {
            if (node != null)
            {
                if (node is OperandNode)
                {
                    return double.Parse(node.Data.ToString());
                }
                else
                {
                    double bal = Evaluate(node.Left);
                    double jobb = Evaluate(node.Right);
                    switch (node.Data)
                    {
                        case '+': return bal + jobb;
                        case '-': return bal - jobb;
                        case '*': return bal * jobb;
                        case '/': return bal / jobb;
                        case '^': return Math.Pow(bal, jobb);
                        default: return double.NaN;
                    }
                }
            }
            else
            {
                return 0;
            }

        }
    }
}
