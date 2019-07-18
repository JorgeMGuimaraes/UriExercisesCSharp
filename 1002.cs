// 1002

namespace URI {
	class URI1002 {
		static void Main1002(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			cult.NumberFormat.NumberDecimalDigits = 4;
			var raio = double.Parse(System.Console.ReadLine().Trim(), cult);
			var area = 3.14159d * raio * raio;
			System.Console.Write(string.Format(cult, "A={0:0.0000}\n", area));
		}
	}
}