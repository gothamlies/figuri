using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
	class Трапеция : Формулы
	{
		public Трапеция(int side1, int side2, int height, int radius, int diagonal, int side3, int side4) : 
			base(side1, side2, height, radius, diagonal,side3,side4)
		{
		}
		internal override double square()
		{
			double a = Side1;
			double b = Side2;
			double h = Height;
			double S = ((a + b) / 2) * h;
			Console.WriteLine("Плошадь трапеции: " + S);
			return S;
		}

		internal override void Perimetr()
		{
			int a = Side1;
			int b = Side2;
			int c = Side3;
			int d = Side4;
			int P = a + b + c + d;
			Console.WriteLine("Периметр трапеции: " + P);
		}
	}
}
