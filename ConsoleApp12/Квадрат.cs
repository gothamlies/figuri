using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
	class Квадрат : Формулы
	{
		public Квадрат(int side1, int side2, int height, int radius, int diagonal, int side3, int side4) :
			base(side1, side2, height, radius, diagonal, side3, side4)
		{
		}
		internal override double square()
		{
			double c = Side1;
			double S = Math.Pow(c, 2);
			Console.WriteLine("Плошадь квадрата: " + S);
			return S;
		}
		internal override void Perimetr()
		{
			int a = Side1;
			int b = Side2;
			int c = Side3;
			int d = Side4;
			int P = a + b + c + d;
			Console.WriteLine("Периметр квадрата: " + P);
		}
	}
}
