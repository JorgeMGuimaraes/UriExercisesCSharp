// 1178
//Todo: not working
namespace URI {
	class URI {
		static void Main(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var valor = decimal.Parse(System.Console.ReadLine().Trim(), cult);
			for (int i = 0; i < 100; i++) {
				/*
				var stringValor = valor.ToString("0.00000", cult);
				System.Console.Write(string.Format(cult, "N[{0}] = {1}\n", i, stringValor.Substring(0, stringValor.Length - 1)));
				*/


				System.Console.Write(string.Format(cult, "N[{0}] = {1:0.0000}\n", i, valor));
				valor /= 2.0m;
			}
			return;
		}
	}
}