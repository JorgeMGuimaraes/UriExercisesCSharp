// 1172

namespace URI {

	class URI1172 {
		static void Main1172(string[] args) {
			for (int i = 0; i < 10; i++) {
				var val = int.Parse(System.Console.ReadLine().Trim());
				System.Console.Write("X[{0}] = {1}\n", i, (val < 1) ? 1 : val);
			}
			return;
		}
	}
}