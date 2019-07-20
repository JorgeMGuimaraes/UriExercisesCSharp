// 1175

namespace URI {
	class URI1175 {
		static void Main1175(string[] args) {
			const int LIMITE = 20;
			int[] vetor = new int[LIMITE];
			for (int i = 0; i < LIMITE; i++) {
				var val = int.Parse(System.Console.ReadLine().Trim());
				vetor[LIMITE - 1 - i] = val;
			}
			for (int i = 0; i < LIMITE; i++) { System.Console.Write("N[{0}] = {1}\n", i, vetor[i]); }
			return;
		}
	}
}