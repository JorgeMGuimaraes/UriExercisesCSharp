// 1020

namespace URI {

	class URI1020 {
		static void processaIdadeEmDias(int dias) {
			int[] tempos = new []{ 365, 30, 1 }, resultados = new[] { 0, 0, 0 };
			for (int i = 0; i < tempos.Length; i++) {
				resultados[i]	= dias / tempos[i];
				dias			%= tempos[i];
			}
			System.Console.Write(string.Format("{0} ano(s)\n{1} mes(es)\n{2} dia(s)\n", resultados[0], resultados[1], resultados[2]));
			return;
		}
		static void Main1020(string[] args) {
			processaIdadeEmDias(int.Parse(System.Console.ReadLine().Trim()));
			return;
		}
	}
}