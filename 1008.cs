// 1008

namespace URI {
	class URI1008 {
		static void Main1008(string[] args) {
			var cult									= new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator	= ".";
			var numero									= int.Parse(System.Console.ReadLine().Trim(), cult);
			var horasTrabalhadas						= int.Parse(System.Console.ReadLine().Trim(), cult);
			var valorHora								= double.Parse(System.Console.ReadLine().Trim(), cult);
			System.Console.Write(string.Format(cult, "NUMBER = {0}\nSALARY = U$ {1:0.00}\n", numero, horasTrabalhadas * valorHora));
		}
	}
}