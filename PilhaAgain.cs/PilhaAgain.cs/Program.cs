using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaAgain.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha[] pilhas = new Pilha[4];
            for (int i = 0; i < pilhas.Length; i++)
            {
                pilhas[i] = new Pilha();
            }

            int qnt_stack1 = 0;
            int qnt_stack2 = 0;
            int qnt_stack3 = 0;
            int qnt_stack4 = 0;

            bool running = true;
            while (running)
            {
                Console.WriteLine("Controle de Containers\n" +
                    "[1] - Inserir Container\n" +
                    "[2] - Remover Container\n" +
                    "[3] - Imprimir Tudo\n" +
                    "[4] - Encerrar");

                int op = Convert.ToInt16(Console.ReadLine());
                
                //---------------------------INSERIR CONTAINER--------------------------------
                if (op == 1) 
                { 
                    Console.WriteLine("Digite o numero do container: ");
                    int container = Convert.ToInt16(Console.ReadLine());
                    if (search(container))
                    {
                        Console.WriteLine("Container já existe");
                        continue;
                    }
                    else
                    {
                        //se tiver pilha vazia insere nele
                        if (qnt_stack1 == 0 || qnt_stack2 == 0 || qnt_stack3 == 0 || qnt_stack4 == 0) //OVERENGINEERING?
                        {
                            if (qnt_stack1 == 0)
                            {
                                pilhas[0].Push(container);
                                qnt_stack1++;
                            }
                            else if (qnt_stack2 == 0)
                            {
                                pilhas[1].Push(container);
                                qnt_stack2++;
                            }
                            else if (qnt_stack3 == 0)
                            {
                                pilhas[2].Push(container);
                                qnt_stack3++;
                            }
                            else if (qnt_stack4 == 0)
                            {
                                pilhas[3].Push(container);
                                qnt_stack4++;
                            }
                        }

                        //se a quantidade de containers for iguais entre as pilhas, insere na primeira
                        else if (qnt_stack1 == qnt_stack2 && qnt_stack1 == qnt_stack3 && qnt_stack1 == qnt_stack4)
                        {
                            if (qnt_stack1 < 3)
                            {
                                pilhas[0].Push(container);
                                qnt_stack1++;
                            }
                            else
                            {
                                Console.WriteLine("Impossível Empilhar!");
                            }
                        }

                        //se tiver pilha menor que uma das outras, insere
                        else if (qnt_stack1 < qnt_stack2 || qnt_stack1 < qnt_stack3 || qnt_stack1 < qnt_stack4)
                        {
                            if (qnt_stack1 < 3)
                            {
                                pilhas[0].Push(container);
                                qnt_stack1++;
                            }
                            else
                            {
                                Console.WriteLine("Impossível Empilhar!");
                            }
                        }
                        else if (qnt_stack2 < qnt_stack1 || qnt_stack2 < qnt_stack3 || qnt_stack2 < qnt_stack4)
                        {
                            if (qnt_stack2 < 3)
                            {
                                pilhas[1].Push(container);
                                qnt_stack2++;
                            }
                            else
                            {
                                Console.WriteLine("Impossível Empilhar!");
                            }
                        }
                        else if (qnt_stack3 < qnt_stack1 || qnt_stack3 < qnt_stack2 || qnt_stack3 < qnt_stack4)
                        {
                            if (qnt_stack3 < 3)
                            {
                                pilhas[2].Push(container);
                                qnt_stack3++;
                            }
                            else
                            {
                                Console.WriteLine("Impossível Empilhar!");
                            }
                        }
                        else if (qnt_stack4 < qnt_stack1 || qnt_stack4 < qnt_stack2 || qnt_stack4 < qnt_stack3)
                        {
                            if (qnt_stack4 < 3)
                            {
                                pilhas[3].Push(container);
                                qnt_stack4++;
                            }
                            else
                            {
                                Console.WriteLine("Impossível Empilhar!");
                            }
                        }
                    } 
                }

                //--------------------------REMOVER CONTAINER---------------------------------
                else if (op == 2)
                {
                    Console.WriteLine("Digite o numero do container: ");
                    int container = Convert.ToInt16(Console.ReadLine());
                    bool found = false;
                    for (int i = 0; i < pilhas.Length; i++)
                    {
                        if (pilhas[i].Topo.Valor == container)
                        {
                            pilhas[i].Pop();
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        Console.WriteLine("Container removido com sucesso!");
                    } else
                    {
                        Console.WriteLine("Imposível desempilhar! Container não encontrado no topo ou não existente");
                    }
                }

                //--------------------------IMPRIMIR TUDO-------------------------------------
                else if (op == 3)
                {
                    for (int i = 0; i < pilhas.Length; i++)
                    {
                        Console.WriteLine("Pilha " + (i + 1) + ": ");
                        pilhas[i].print();
                    }
                }

                else if (op == 4)
                {
                    Console.WriteLine("Encerrando...");
                    running = false;
                }

                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            } // end while

            //função procurar container nas pilhas
            bool search(int container)
            {
                for (int i = 0; i < pilhas.Length; i++)
                {
                    if (pilhas[i].Topo == null)
                    {
                        continue;
                    }
                    else if (pilhas[i].Topo.Valor == container)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
