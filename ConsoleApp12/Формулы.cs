using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
	class Формулы
	{
		public int Side1;
		public int Side2;
		public int Height;
		public int Radius;
		public int Diagonal;
		public int Side3;
		public int Side4;


		public Формулы(int side1, int side2, int height, int radius, int diagonal, int side3, int side4)
		{
			Side1 = side1;
			Side2 = side2;
			Height = height;
			Radius = radius;
			Diagonal = diagonal;
			Side3 = side3;
			Side4 = side4;

		}
		internal virtual double square()
		{
			double c = Side1;
			double S = Math.Pow(c, 2);
			Console.WriteLine("Плошадь квадрата: " + S);
			return S;
		}
		internal virtual void Perimetr()
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
