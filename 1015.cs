// 1015

namespace URI {
	class URI1015 {
		static double distancia(double x1, double x2, double y1, double y2) {
			return System.Math.Sqrt(System.Math.Pow(x2 - x1, 2) + System.Math.Pow(y2 - y1, 2));
		}

		static void Main1015(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var par1 = System.Console.ReadLine().Trim().Split(' ');
			var par2 = System.Console.ReadLine().Trim().Split(' ');
			double x1 = double.Parse(par1[0], cult), y1 = double.Parse(par1[1], cult);
			double x2 = double.Parse(par2[0], cult), y2 = double.Parse(par2[1], cult);
			System.Console.Write(string.Format(cult, "{0:0.0000}\n", distancia(x1, x2, y1, y2)));
		}
	}
}