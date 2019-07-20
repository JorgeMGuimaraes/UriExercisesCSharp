// 1173

namespace URI {

	class URI1173 {
		static void Main1173(string[] args) {
			var valor = int.Parse(System.Console.ReadLine().Trim());
			for (int i = 0; i < 10; i++) {
				System.Console.Write("N[{0}] = {1}\n", i, valor);
				valor *= 2;
			}
			return;
		}
	}
}