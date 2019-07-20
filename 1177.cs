// 1177

namespace URI {
	class URI1177 {
		static void Main1177(string[] args) {
			var limite = int.Parse(System.Console.ReadLine().Trim());
			for (int i = 0; i < 1000; i++) { System.Console.Write("N[{0}] = {1}\n", i, (i + limite) % limite); }
			return;
		}
	}
}