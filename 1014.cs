// 1014

namespace URI {
	class URI1014 {

		static void Main1014(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var x = decimal.Parse(System.Console.ReadLine().Trim(), cult);
			var y = decimal.Parse(System.Console.ReadLine().Trim(), cult);
			System.Console.Write(string.Format(cult, "{0:0.000} km/l\n", x / y));
		}
	}
}