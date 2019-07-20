// 1179
namespace URI {
	using System.Collections.Generic;
	class URI1179 {
		static void Main179(string[] args) {
			List<int> pares = new List<int>(), impares = new List<int>();
			int valor;
			for (int i = 0; i < 15; i++) {
				valor = int.Parse(System.Console.ReadLine().Trim());
				if (valor % 2 == 0) {
					pares.Add(valor);
					if (pares.Count >= 5) {
						for (int j = 0; j < pares.Count; j++) { System.Console.Write("par[{0}] = {1}\n", j, pares[j]); }
						pares.Clear();
					}
				}
				else {
					impares.Add(valor);
					if (impares.Count >= 5) {
						for (int j = 0; j < impares.Count; j++) { System.Console.Write("impar[{0}] = {1}\n", j, impares[j]); }
						impares.Clear();
					}
				}
			}
			for (int j = 0; j < impares.Count; j++) { System.Console.Write("impar[{0}] = {1}\n", j, impares[j]); }
			for (int j = 0; j < pares.Count; j++) { System.Console.Write("par[{0}] = {1}\n", j, pares[j]); }
			return;
		}
	}
}