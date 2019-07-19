// 1012

namespace URI {
	class URI1012 {
		static void Main1012(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var valores = System.Console.ReadLine().Trim().Split(' ');
			decimal a = decimal.Parse(valores[0], cult), b = decimal.Parse(valores[1], cult), c = decimal.Parse(valores[2], cult);
			System.Console.Write(string.Format(cult, "TRIANGULO: {0:0.000}\n", (a * c) / 2.0m));
			System.Console.Write(string.Format(cult, "CIRCULO: {0:0.000}\n", 3.14159m * c * c));
			System.Console.Write(string.Format(cult, "TRAPEZIO: {0:0.000}\n", (a + b) * c / 2.0m));
			System.Console.Write(string.Format(cult, "QUADRADO: {0:0.000}\n", b * b));
			System.Console.Write(string.Format(cult, "RETANGULO: {0:0.000}\n", a * b));
		}
	}
}