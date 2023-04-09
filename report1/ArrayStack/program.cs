using System;

namespace ArrayStack
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arrStack = new object[10];

            int top = -1;

            push(5);
            peek();
            pop();
            pop();
            push("안녕하세요");

            void push(object data)
            {
                arrStack[++top] = data;
                System.Console.WriteLine(arrStack[top]+"를 push 했습니다");
            }

            void pop()
            {
                if (top == -1)
                {
                    System.Console.WriteLine("스택이 비어있습니다.");
                    return;
                }
                else
                {
                    object temp = arrStack[top];
                    top--;
                    System.Console.WriteLine("{0}을 pop 했습니다.", temp);
                    return;
                }
            }

            void peek()
            {
                if(top == -1){
                    System.Console.WriteLine("스택이 비어있습니다.");
                    return;
                }
                
                System.Console.WriteLine("현재 TOP은 {0} 입니다.",arrStack[top]);
                return;
            }
        }
    }
}
