using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_general_y_binomio_al_cuadrado_perfecto_N3
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            int z;
            Console.WriteLine("¿Que operacion se desea realizar?");
            Console.WriteLine("1) Formula general 2) Binomio al cuadrado perfecto");
            opcion = Console.ReadLine();
            z = int.Parse(opcion); //convertidor de texto a numero entero

            //"menu de opciones" por asi decirlo
            if (z == 1)
            {   //las variables con las que se va a trabajar
                int A;
                int B;
                int C;
                double X;
                double P;
                double P2;
                string d; //se puede usar una misma variable para convertir cadena a numero
                double Res1;
                double Res2;
                Console.WriteLine("Ingrese el valor A");
                d = Console.ReadLine();
                A = int.Parse(d);
                Console.WriteLine("Ingrese el valor B");
                d = Console.ReadLine();
                B = int.Parse(d); 
                Console.WriteLine("Ingrese el valor C");
                d = Console.ReadLine();
                C = int.Parse(d);
                //sistema anti-graciosos...
                if (A == 0 & B == 0 & C == 0)
                {
                    Console.WriteLine("¿Como van a ser 0 los tres valores? >:v");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("FORMULA GENERAL X=-B+-√B^2-4(A)(C)/2(A)");
                    Console.WriteLine("Primero se sustituyen todos los valores:");
                    Console.WriteLine("X=-("+ B + ")+-√" + B + "^2-4(" + A +")("+ C +")/2(" + A +")" );
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.WriteLine("Despues se resuelven primero las operaciones dentro de la raiz:");
                    Console.WriteLine("+-√" + B + "^2 - 4(" + A +")(" + C + ")");
                    Console.WriteLine(B*B - 4 * A * C);
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    X = Math.Sqrt((B * B) - (4 * A * C)); //este es para sacar la raiz de un numero
                    //la condicion se cumple si X es igual o mayor que 1
                    if (X >= 1)
                    {
                        Console.WriteLine("Despues se saca la raiz");
                        Console.WriteLine(X);
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        P = (-B + X);
                        Res1 = P / (2 * A);

                        P2 = (-B - X);
                        Res2 = P2 / (2 * A);
                        Console.WriteLine("Posteriormente se suma el resultado positivo de la raiz con el valor B antes de dividir");
                        Console.WriteLine(-B + "+" + X);
                        Console.WriteLine(-B + X);
                        Console.WriteLine("Despues se divide el primer resultado");
                        Console.WriteLine(P + "/" + (2 * A));
                        Console.WriteLine(P / (2 * A));
                        Console.WriteLine("El primer resultado es " + Res1);
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.WriteLine("Y despues se suma con el resultado negativo");
                        Console.WriteLine(-B + "-" + X);
                        Console.WriteLine(-B - X);
                        Console.WriteLine("Finalmente se divide el segundo resultado");
                        Console.WriteLine(P2 + "/" + (2 * A));
                        Console.WriteLine(P2 / (2 * A));
                        Console.WriteLine("El segundo resultado es " + Res2);
                        Console.WriteLine("Presione cualquier tecla para finalizar");
                        Console.ReadKey();
                    }
                    //la condicion solo se cumple si es igual a 0
                    else if (X == 0)
                    {
                        Console.WriteLine("Despues se saca la raiz");
                        Console.WriteLine(X);
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        P = (-B + X);
                        Res1 = P / (2 * A);
                        Console.WriteLine("Posteriormente se suma el resultado de la raiz con el valor B antes de dividir");
                        Console.WriteLine(-B + "+" + X);
                        Console.WriteLine(-B + X);
                        Console.WriteLine("Despues se divide el resultado");
                        Console.WriteLine(P + "/" + (2 * A));
                        Console.WriteLine(P / (2 * A));
                        Console.WriteLine("El resultado es " + Res1);
                        Console.WriteLine("Presione cualquier tecla para finalizar");
                        Console.ReadKey();
                    }                    
                     else 
                     {
                        Console.WriteLine("Al ser el resultado dentro de la raiz negativo no hay ninguna solucion");
                        Console.WriteLine("Presione cualquier tecla para finalizar");
                        Console.ReadKey();
                     }
                }
            }                                                       
            else
            {
                int num;
                string y;
                double a;
                double b;
                Console.WriteLine("BINOMIO AL CUADRADO PERFECTO");
                Console.WriteLine("Ingrese un numero");
                y = Console.ReadLine();
                num = int.Parse(y);
                a = num*2;
                b = Math.Pow(num, 2); //este otro es para elevar al numero que quieras
                if (a>0)
                {
                    Console.WriteLine("El resultado es x²+" + a + "x+" + b);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El resultado es x²" + a + "x+" + b);
                    Console.ReadKey();
                }
            }
            
        }
    }
}
