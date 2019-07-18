// 1009
//Todo: not working
namespace URI {
	class URI1009 {
		static void Main1009(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat
				.NumberDecimalSeparator = ".";
			var nome = System.Console.ReadLine().Trim();
			var salario = decimal.Parse(System.Console.ReadLine().Trim(), cult);
			var vendas = decimal.Parse(System.Console.ReadLine().Trim(), cult);
			var total = (salario + (0.1500000000000m * vendas));
			System.Console.Write(string.Format(cult, "TOTAL = R$ {0:0.00}\n", total));
		}
	}
}