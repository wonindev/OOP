using System;

namespace LinkedListStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Linkedliststack stack = new Linkedliststack();
            stack.push(10);
            stack.push(20);

            stack.pop();
            stack.peek();

            stack.push("안녕하세요");
            stack.push("Hello");

            stack.pop();
            stack.peek();

            stack.pop();
            stack.pop();
            stack.pop();

            stack.peek();
        }
    }

    public class Node
    {
        public object data;
        public Node before;

        public Node(object data)
        {
            this.data = data;
            before = null;
        }
    }

    public class Linkedliststack
    {
        public Node top;

        public void push(object data)
        {
            Node newNode = new Node(data);

            newNode.before = top;
            top = newNode;

            System.Console.WriteLine(data + "를 push 했습니다");
        }

        public void pop()
        {
            if (top == null)
            {
                System.Console.WriteLine("스택이 비어있습니다.");
                return;
            }

            System.Console.WriteLine("{0}을 삭제했습니다.", top.data);
            top = top.before;
        }

        public void peek()
        {
            if (top == null)
            {
                System.Console.WriteLine("스택이 비어있습니다.");
                return;
            }

            System.Console.WriteLine("현재 Top은 {0} 입니다.", top.data);
        }
    }
}
