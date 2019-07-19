// 1021

namespace URI {

	class URI1021 {
		static void Main1021(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var valor = decimal.Parse(System.Console.ReadLine().Trim(), cult);

			int[] notas = new[] { 100, 50, 20, 10, 5, 2 };
			decimal[] moedas = new[] { 1.0m, 0.5m, 0.25m, 0.1m, 0.05m, 0.01m };
			int quantidade;
			System.Console.Write("NOTAS:\n");
			for (int i = 0; i < notas.Length; i++) {
				quantidade = (int)(valor / notas[i]);
				valor -= quantidade * notas[i];
				System.Console.Write("{0} nota(s) de R$ {1}.00\n", quantidade, notas[i]);
			}
			System.Console.Write("MOEDAS:\n");
			for (int i = 0; i < moedas.Length - 1; i++) {
				quantidade = (int)(valor / moedas[i]);
				valor -= quantidade * moedas[i];
				System.Console.Write(string.Format(cult, "{0} moeda(s) de R$ {1:0.00}\n", quantidade, moedas[i]));
			}
			System.Console.Write(string.Format(cult, "{0} moeda(s) de R$ {1:0.00}\n", (int)System.Math.Round(valor * 100), moedas[moedas.Length - 1]));
			return;
		}
	}
}
