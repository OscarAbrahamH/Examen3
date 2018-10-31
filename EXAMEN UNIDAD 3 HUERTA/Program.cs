using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    class Program
    {
        public static int c;
        public static string[,] act2 = new string[100, 2];
        static Stack<int> GetStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(3);
            stack.Pop();
            stack.Push(2);
            stack.Push(8);
            stack.Pop();
            stack.Pop();
            stack.Push(9);
            stack.Push(1);
            stack.Pop();
            stack.Push(7);
            stack.Push(6);
            stack.Pop();
            stack.Pop();
            stack.Push(4);
            stack.Pop();
            stack.Pop();
            return stack;
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Seleccione ejercicio a ejecutar:");
                Console.WriteLine("0) Salir");
                Console.WriteLine("1) Actividad 1");
                Console.WriteLine("2) Actividad 2");

                string r = Console.ReadLine();
                c = Int32.Parse(r);
                if (c == 1){
                        var stack = GetStack();
                        Console.WriteLine("--- Stack contents ---");
                        foreach (int i in stack)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                }
                else if (c==2){
                        Console.WriteLine("Instrucciones:");
                        Console.WriteLine("1) Registrar");
                        Console.WriteLine("2) Mostrar datos");
                        string a = Console.ReadLine();
                        int b = Int32.Parse(a);
                        if (b==1)
                        {
                                Console.WriteLine("Declare:");
                                bool check = false;
                                string d = Console.ReadLine();
                                string[] words = d.Split(' ');
                                for (int i = 0; i <= 99; i++)
                                {
                                        for (int j = 0; j <= 1; j++)
                                        {
                                            if (act2[i, j] == null)
                                            {
                                                act2[i, j] = words[j];
                                                check = true;
                                            }
                                            
                                        }
                                        if (check == true)
                                        {
                                            i = 100;
                                        }
                                }
                        }else if(b==2)
                        {
                                for (int i = 0; i <= 99; i++)
                                {

                                    for (int j = 0; j <= 1; j++)
                                    {
                                        if (act2[i, j] != null)
                                        {
                                            if (j == 1)
                                            {
                                                Console.WriteLine(act2[i, j]);
                                            }
                                            else
                                            {
                                                Console.Write(" "+act2[i, j]);
                                            }
                                        }
                                    }



                                }
                        }

                }
                else if (c == 3)
                {
                    Clase mate = new Clase();

                }
                else if (c != 1 && c != 2 && c != 0)
                {
                    Console.WriteLine("Seleccione un numero valido");
                }

            } while (c != 0);
        }
            
            
    }
}
