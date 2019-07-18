// 1006

namespace URI {
	class URI1006 {
		static void Main1006(string[] args) {
			var cult									= new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator	= ".";
			var A										= 2 * double.Parse(System.Console.ReadLine().Trim(), cult);
			var B										= 3 * double.Parse(System.Console.ReadLine().Trim(), cult);
			var C										= 5 * double.Parse(System.Console.ReadLine().Trim(), cult);
			var X										= (A + B + C) / 10;
			System.Console.Write(string.Format(cult, "MEDIA = {0:0.0}\n", X));
		}
	}
}