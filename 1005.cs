// 1005

namespace URI {
	class URI1005 {
		static void Main1005(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			cult.NumberFormat.NumberDecimalDigits = 4;
			var A = double.Parse(System.Console.ReadLine().Trim(), cult);
			var B = double.Parse(System.Console.ReadLine().Trim(), cult);
			var X = (A * 3.5 + B * 7.5) / 11;
			System.Console.Write(string.Format(cult, "MEDIA = {0:0.00000}\n", X));
		}
	}
}