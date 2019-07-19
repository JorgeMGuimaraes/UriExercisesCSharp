// 1022

namespace URI {

	class URI1022 {
		static int simplificar(int n, int d) {
			int i = 2, mdc = 1;
			n = System.Math.Abs(n);
			d = System.Math.Abs(d);
			while (i <= System.Math.Min(n, d)) {
				if (n % i == 0 && d % i == 0) {
					mdc *= i;
					n /= i;
					d /= i;
				}
				else { i++; }
			}
			return mdc;
		}

		static void imprimirTDARacional(int n, int d) {
			int divComum = simplificar(n, d);
			System.Console.Write("{0}/{1} = {2}/{3}\n", n, d, n / divComum, d / divComum);
			return;
		}
		static void soma(int n1, int d1, int n2, int d2) {
			int numInicial = (n1 * d2) + (n2 * d1), denInicial = d1 * d2;
			imprimirTDARacional(numInicial, denInicial);
			return;
		}
		static void subtracao(int n1, int d1, int n2, int d2) {
			int numInicial = (n1 * d2) - (n2 * d1), denInicial = d1 * d2;
			imprimirTDARacional(numInicial, denInicial);
			return;
		}
		static void multiplicacao(int n1, int d1, int n2, int d2) {
			int numInicial = n1 * n2, denInicial = d1 * d2;
			imprimirTDARacional(numInicial, denInicial);
			return;
		}
		static void divisao(int n1, int d1, int n2, int d2) {
			int numInicial = n1 * d2, denInicial = n2 * d1;
			imprimirTDARacional(numInicial, denInicial);
			return;
		}

		static void Main1022(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var casos = int.Parse(System.Console.ReadLine().Trim(), cult);

			for (int i = 0; i < casos; i++) {
				var linha = System.Console.ReadLine().Trim().Split(' ');
				var operador = linha[3];
				var n1 = int.Parse(linha[0]);
				var d1 = int.Parse(linha[2]);
				var n2 = int.Parse(linha[4]);
				var d2 = int.Parse(linha[6]);
				if (operador == "+") { soma(n1, d1, n2, d2); }
				else if (operador == "-") { subtracao(n1, d1, n2, d2); }
				else if (operador == "*") { multiplicacao(n1, d1, n2, d2); }
				else if (operador == "/") { divisao(n1, d1, n2, d2); }
			}
			return;
		}
	}
}