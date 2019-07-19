// 1017

namespace URI {
	class URI1017 {
		static decimal consumo(int tempo, int velocidade) => tempo * velocidade / 12m;

		static void Main1017(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var tempo = int.Parse(System.Console.ReadLine().Trim(), cult);
			var velocidade = int.Parse(System.Console.ReadLine().Trim(), cult);
			System.Console.Write(string.Format(cult, "{0:0.000}\n", consumo(tempo, velocidade)));
		}
	}
}
