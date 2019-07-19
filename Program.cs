// 1022

namespace URI {

	class URI {
		static int simplificar(int n, int d) {
			int i = 2, mdc = 1;
			n = System.Math.Abs(n);
			d = System.Math.Abs(d);
			while (i <= System.Math.Min(n, d)) {
				if (n % i == 0 && d % i == 0) {
					mdc	*= i;
					n	/= i;
					d	/= i;
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
			int numInicial = (n1 * d2) + (n2 * d1), denInicial = d1* d2 ;
			imprimirTDARacional(numInicial, denInicial);
			return;
		}
		static void subtracao(int n1, int d1, int n2, int d2) {
			int numInicial = (n1 * d2) - (n2 * d1), denInicial = d1* d2;
			imprimirTDARacional(numInicial, denInicial);
			return;
		}
		static void multiplicacao(int n1, int d1, int n2, int d2) {
			int numInicial = n1* n2, denInicial = d1* d2;
			imprimirTDARacional(numInicial, denInicial);
			return;
		}
		static void divisao(int n1, int d1, int n2, int d2) {
			int numInicial = n1* d2, denInicial = n2* d1;
			imprimirTDARacional(numInicial, denInicial);
			return;
		}

		static void Main(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var casos = int.Parse(System.Console.ReadLine().Trim(), cult);

			for (int i = 0; i < casos; i++) {
				var linha		= System.Console.ReadLine().Trim().Split(' ');
				var operador	= linha[3];
				var n1			= int.Parse(linha[0]);
				var d1			= int.Parse(linha[2]);
				var n2			= int.Parse(linha[4]);
				var d2			= int.Parse(linha[6]);
				if (operador == "+")		{ soma(n1, d1, n2, d2); }
				else if (operador == "-")	{ subtracao(n1, d1, n2, d2); }
				else if (operador == "*")	{ multiplicacao(n1, d1, n2, d2); }
				else if (operador == "/")	{ divisao(n1, d1, n2, d2); }
			}
			return;
		}
	}
}

/*
	
10/8 = 5/4
-2/8 = -1/4
12/18 = 2/3
4/6 = 2/3
/*
//1022
#include <iostream>
#include <cmath>
#include <algorithm>

int simplificar(int n, int d) {
	register int i { 2 }, mdc { 1 };
	n = std::abs(n);
	d = std::abs(d);
	while(i <= std::min(n, d)) {
		if(n % i == 0 && d % i == 0) {
			mdc *= i;
			n /= i;
			d /= i;
		}
		else { ++i; }
	}
	return mdc;
}
void imprimirTDARacional(int n, int d) {
	int divComum { simplificar(n, d) };
	printf("%d/%d = %d/%d\n", n, d, n / divComum, d / divComum);
	return;
}
void soma(int n1, int d1, int n2, int d2) {
	int numInicial { (n1 * d2) + (n2 * d1) }, denInicial { d1 * d2 };
	imprimirTDARacional(numInicial, denInicial);
	return;
}
void subtracao(int n1, int d1, int n2, int d2) {
	int numInicial { (n1 * d2) - (n2 * d1) }, denInicial { d1 * d2 };
	imprimirTDARacional(numInicial, denInicial);
	return;
}
void multiplicacao(int n1, int d1, int n2, int d2) {
	int numInicial { n1 * n2 }, denInicial { d1 * d2 };
	imprimirTDARacional(numInicial, denInicial);
	return;
}
void divisao(int n1, int d1, int n2, int d2) {
	int numInicial { n1 * d2 }, denInicial { n2 * d1 };
	imprimirTDARacional(numInicial, denInicial);
	return;
}

int main1022() {
	register int casos {}, i {};
	scanf("%d", &casos);
	for(i = 0; i < casos; i++) {
		int n1 {}, d1 {}, n2 {}, d2 {};
		char div {}, operador {};
		std::cin >> n1 >> div >> d1 >> operador >> n2 >> div >> d2;
		if(operador == '+') { soma(n1, d1, n2, d2); }
		else if(operador == '-') { subtracao(n1, d1, n2, d2); }
		else if(operador == '*') { multiplicacao(n1, d1, n2, d2); }
		else if(operador == '/') { divisao(n1, d1, n2, d2); }
	}

	return 0;
}

*/
