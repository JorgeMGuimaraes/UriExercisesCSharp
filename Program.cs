// 1011

namespace URI {
	class URI {
		static void Main(string[] args) {
			var cult					= new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat
				.NumberDecimalSeparator	= ".";
			var raio					= decimal.Parse(System.Console.ReadLine().Trim(), cult);
			System.Console.Write(string.Format(cult, "VOLUME = {0:0.000}\n", (4m / 3.0m) * 3.14159m * raio * raio * raio));
		}
	}
}