// 1176

namespace URI {

	class URI1176 {
		static void Main1176(string[] args) {
			const int limite = 61;
			ulong[] serieDeFibonnaci = new ulong[limite];
			serieDeFibonnaci[0] = 0;
			serieDeFibonnaci[1] = 1;
			for (int i = 2; i < limite; i++) { serieDeFibonnaci[i] = serieDeFibonnaci[i - 1] + serieDeFibonnaci[i - 2]; }
			var casos = int.Parse(System.Console.ReadLine().Trim());
			for (int i = 0; i < casos; i++) {
				var entrada = int.Parse(System.Console.ReadLine().Trim());
				System.Console.Write("Fib({0}) = {1}\n", entrada, serieDeFibonnaci[entrada]);
			}
			return;
		}
	}
}
