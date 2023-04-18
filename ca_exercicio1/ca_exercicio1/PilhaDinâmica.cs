using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_exercicio1
{
    public class DynamicStack
    {
        //já é uma classe interna da classe DynamicStack
        private class Node
        {
            public char Value;
            public Node Next;

            public Node(char value)
            {
                Value = value;
                Next = null;
            }
        }
        
        private Node top;

        //construtor
        public DynamicStack()
        {
            top = null;
        }


        //métodos
        public void Push(char value)
        {
            Node newNode = new Node(value);
            newNode.Next = top;
            top = newNode;
        }


        public char Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            char result = top.Value;
            top = top.Next;
            return result;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}

