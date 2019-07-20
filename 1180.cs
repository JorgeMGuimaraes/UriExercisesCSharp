// 1180

namespace URI {

	class URI1180 {
		static void Main1180(string[] args) {
			var limite = int.Parse(System.Console.ReadLine().Trim());
			var valores = System.Console.ReadLine().Trim().Split(' ');
			int menor = int.Parse(valores[0]),
				indice = 0;
			for (int i = 1; i < limite; i++) {
				if (int.Parse(valores[i]) < menor) {
					menor = int.Parse(valores[i]);
					indice = i;
				}
			}
			System.Console.Write("Menor valor: {0}\nPosicao: {1}\n", menor, indice);
			return;
		}
	}
}