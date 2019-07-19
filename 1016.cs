// 1016

namespace URI {
	class URI1016 {
		static int calcularDistancia(int tempo) => tempo * 2;

		static void Main1016(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var tempo = int.Parse(System.Console.ReadLine().Trim(), cult);
			System.Console.Write(string.Format(cult, "{0} minutos\n", calcularDistancia(tempo)));
		}
	}
}