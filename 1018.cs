// 1018

namespace URI {
	class URI1018 {
		static void processaValor(int valor) {
			int[] notas				= new int[] { 100, 50, 20, 10, 5, 2, 1 };
			int quantidadeDeNotas;
			for (int i = 0; i < notas.Length; i++) {
				quantidadeDeNotas	= valor / notas[i];
				valor				%= notas[i];
				System.Console.Write("{0} nota(s) de R$ {1},00\n", quantidadeDeNotas, notas[i]);
			}
		}

		static void Main1018(string[] args) {
			var cult		= new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator	= ".";
			var valor		= int.Parse(System.Console.ReadLine().Trim(), cult);
			System.Console.Write(string.Format(cult, "{0}\n", valor));
			processaValor(valor);
			return;
		}
	}
}