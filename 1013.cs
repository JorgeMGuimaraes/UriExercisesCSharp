// 1013

namespace URI {
	class URI1013 {
		static int maiorAB(int a, int b) => (a + b + System.Math.Abs(a - b)) / 2;

		static void Main1013(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var valores = System.Console.ReadLine().Trim().Split(' ');
			int a = int.Parse(valores[0], cult), b = int.Parse(valores[1], cult), c = int.Parse(valores[2], cult);
			System.Console.Write(string.Format(cult, "{0} eh o maior\n", maiorAB(maiorAB(a, b), c)));
		}
	}
}