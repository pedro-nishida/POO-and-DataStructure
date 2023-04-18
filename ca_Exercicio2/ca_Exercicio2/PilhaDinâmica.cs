using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ca_Exercicio2
{
    public class DynamicStack
    {
        private class Node
        {
            public Carro Value;
            public Node Next;

            public Node(Carro value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node top;
        private int count;

        public DynamicStack()
        {
            top = null;
            count = 0;
        }

        public void Push(Carro value)
        {
            Node newNode = new Node(value);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        //dado a placa, o carro é removido e a pilha é reajustada pela vacancia
        public void Pop(string placa)
        {
            Node current = top;
            Node previous = null;
            while (current != null)
            {
                if (current.Value.Placa == placa)
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        top = current.Next;
                    }
                    count--;
                    break;
                }
                previous = current;
                current = current.Next;
            }
        }

        //imprime os valores da pilha
        public void Print()
        {
            Node current = top;
            while (current != null)
            {
                Console.WriteLine(current.Value.Placa);
                current = current.Next;
            }
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public int Size()
        {
            return count;
        }
    }
}
