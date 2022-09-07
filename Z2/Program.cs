/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

System.Console.Write("Введите координаты a первой точки: ");
int a1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты b первой точки: ");
int b1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координаты a второй точки: ");
int a2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты b второй точки: ");
int b2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координаты a третьей точки: ");
int a3 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты b третьей точки: ");
int b3 = Convert.ToInt32(Console.ReadLine());

double rez = Math.Sqrt(Math.Pow((a1-b1),2)+Math.Pow((a2-b2),2)+Math.Pow((a3-b3),2));
System.Console.WriteLine(rez);