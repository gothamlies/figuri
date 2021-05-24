using System;

namespace ConsoleApp12
{
	class Program
	{
		static void Main(string[] args)
		{
			Треугольник a = new Треугольник(2, 4, 3, 2, 2, 4, 0);
			Квадрат b = new Квадрат(3, 4, 3, 2, 3, 5, 6);
			Параллелограмм c = new Параллелограмм(5, 4, 5, 2, 2, 3, 2);
			Трапеция d = new Трапеция(2, 4, 6, 2, 3, 4, 2);
			a.square();
			a.Perimetr();
			Console.WriteLine("");
			b.square();
			b.Perimetr();
			Console.WriteLine("");
			c.square();
			c.Perimetr();
			Console.WriteLine("");
			d.square();
			d.Perimetr();
			Console.WriteLine("");
			double T = b.square();
			double K = a.square();
			Console.WriteLine("");

			if (T < K)
			{
				Console.WriteLine("Квадрат меньше треугольника, последний не может поместится");
			}
			else
			{
				Console.WriteLine("Квадрат больше треугольника, фигура поместится в квадрат");
			}
		}
}
	
}
