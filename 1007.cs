// 1007

namespace URI {
	class URI1007 {
		static void Main1007(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var A = int.Parse(System.Console.ReadLine().Trim(), cult);
			var B = int.Parse(System.Console.ReadLine().Trim(), cult);
			var C = int.Parse(System.Console.ReadLine().Trim(), cult);
			var D = int.Parse(System.Console.ReadLine().Trim(), cult);
			var X = (A * B) - (C * D);
			System.Console.Write(string.Format(cult, "DIFERENCA = {0}\n", X));
		}
	}
}