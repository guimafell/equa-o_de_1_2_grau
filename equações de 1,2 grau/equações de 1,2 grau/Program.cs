using System;
using System.Threading;

namespace equações_de_1_2_grau
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6, n7, n8, n9, n10;
            string p1;    
        
        start:
            //Refêrencia ao inicio

            Console.BackgroundColor = ConsoleColor.Black;
            //Cor no fundo da tela

            Console.ForegroundColor = ConsoleColor.Blue;
            //Cor das letras

            Console.Clear();
            //Limpar a tela

            Console.WriteLine("Deseja fazer uma equação de:\n\t1 - Primeiro grau\n\t2 - segundo grau (completa e incompleta)");
            //Saída de dados com número de opções válidas

            //Inicio da estrutura condicional//
            switch (Console.ReadLine())
            
            {
                case "1":
                    Console.WriteLine("Vamos utilizar a Fórmula básica:\n\t1 - n1+nX=n3 ou \n\t2 - n1-nX=n3");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Write("Fórmula escolida->n1+nX=n3 \n Digite o valor do n1: ");
                            n1 = Convert.ToDouble(Console.ReadLine());
                           
                            Console.Write("\nDigite o valor do nX: ");
                            n2 = Convert.ToDouble(Console.ReadLine());
                            
                            Console.Write("\n Digite o valor do n3: ");
                            n3 = Convert.ToDouble(Console.ReadLine());

                            n4 =(n3-n1)/n2;

                            Console.WriteLine("Resultado, X={0}",n4);
                            break;

                        case "2":
                            Console.Write("Fórmula escolida->n1-nX=n3 \n Digite o valor do n1: ");
                            n1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("\nDigite o valor do nX: ");
                            n2 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("\n Digite o valor do n3: ");
                            n3 = Convert.ToDouble(Console.ReadLine());

                            n4 = (n3-n1)/(n2*-1);

                            Console.WriteLine("Resultado, X={0}", n4);
                            break;
                    }
                    
                   
                    break;

                case "2":
                    Console.Write("Valores da equação de segundo grau:aX²+bX+c=0 \nDigite o varlor de aX²: ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nDigite o varlor de bX: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    
                    
                    Console.Write("\nDigite o varlor de c: ");
                    n3 = Convert.ToDouble(Console.ReadLine());

                    if (n2 == 0)
                    {
                        Console.Clear();
                        n4 = (n3 * -1) / n1;
                        n5 = Math.Sqrt(n4);

                        Console.WriteLine("x1={0}, x2={1}",n5,n5*-1);
                    }
                    if (n3==0)
                    {
                        Console.Clear();
                        n4 = (n2 * -1) / n1;

                        Console.WriteLine("x1=0, x2={0}",n4);
                    }
                    if(n2==0 && n3 == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("x1=0, x2=0");
                    }
                    if (n1 != 0 && n2 != 0 && n3 != 0)
                    {
                        Console.Clear();
                        n4 = Math.Pow(n2, 2) - (4 * n1 * n3);

                        n5 = ((n2 * -1) + Math.Sqrt(n4)) / (2 * n1);

                        n6 = ((n2 * -1) - Math.Sqrt(n4)) / (2 * n1);

                        Console.Write("x1={0} x2={1} delta={2}", n5, n6, n4);
                    }

                    break;

                default:
                    Console.WriteLine("Digite uma opção válida. Press enter para tentar novamente");
                    Console.ReadKey(true);
                    goto start;
                    break;
            }
            //Fim da escrutura condicional//

            Console.WriteLine("deseja continuar? (s/n)");
            p1 = Console.ReadLine();
            if (p1 == "s"||p1=="S"||p1=="sim"||p1=="SIM"||p1=="Sim")
            {
                Console.Clear();
                goto start;
            }
            else
            {
                Console.WriteLine("Obrigado por me utilizar, Press enter para sair");
                Console.ReadKey(true);
            }

        }
    }
}
