// 1019

namespace URI {
	class URI1019 {
		static void processaTempo(int tempo) {
			int[] tempos = new int[] { 3600, 60, 1 }, resultados = new int[] { 0, 0, 0 };
			for (int i = 0; i < tempos.Length; i++) {
				resultados[i] = tempo / tempos[i];
				tempo %= tempos[i];
			}
			System.Console.Write(string.Format("{0}:{1}:{2}\n", resultados[0], resultados[1], resultados[2]));
			return;
		}

		static void Main1019(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			processaTempo(int.Parse(System.Console.ReadLine().Trim(), cult));
			return;
		}
	}
}