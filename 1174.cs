// 1174

namespace URI {

	class URI1174 {
		static void Main1174(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			for (int i = 0; i < 100; i++) {
				var valor = decimal.Parse(System.Console.ReadLine().Trim());
				if (valor <= 10) { System.Console.Write(string.Format(cult, "A[{0}] = {1:0.0}\n", i, valor)); }
			}
			return;
		}
	}
}