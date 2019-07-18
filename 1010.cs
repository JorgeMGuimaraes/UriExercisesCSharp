// 1010

namespace URI {
	class URI1010 {
		static void Main1010(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var peca1 = System.Console.ReadLine().Trim().Split(' ');
			var peca2 = System.Console.ReadLine().Trim().Split(' ');
			System.Console.Write(string.Format(cult, "VALOR A PAGAR: R$ {0:0.00}\n",
				decimal.Parse(peca1[1], cult) * decimal.Parse(peca1[2], cult) + decimal.Parse(peca2[1], cult) * decimal.Parse(peca2[2], cult)));
		}
	}
}

