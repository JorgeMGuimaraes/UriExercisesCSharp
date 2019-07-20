// 2310
namespace URI {
	class URI2310 {
		static void Main2310(string[] args) {
			var cult = new System.Globalization.CultureInfo("pt-br");
			cult.NumberFormat.NumberDecimalSeparator = ".";
			var jogadores = int.Parse(System.Console.ReadLine().Trim());
			int ts = 0, tb = 0, ta = 0, ss = 0, sb = 0, sa = 0;
			for (int i = 0; i < jogadores; i++) {
				var nome = System.Console.ReadLine().Trim();
				var tentativas = System.Console.ReadLine().Trim().Split(' ');
				var sucessos = System.Console.ReadLine().Trim().Split(' ');
				ts += int.Parse(tentativas[0]);
				tb += int.Parse(tentativas[1]);
				ta += int.Parse(tentativas[2]);
				ss += int.Parse(sucessos[0]);
				sb += int.Parse(sucessos[1]);
				sa += int.Parse(sucessos[2]);
			}
			System.Console.Write(string.Format(
				cult,
				"Pontos de Saque: {0:0.00} %.\nPontos de Bloqueio: {1:0.00} %.\nPontos de Ataque: {2:0.00} %.\n",
				100m * ss / ts, 100m * sb / tb, 100m * sa / ta));
			return;
		}
	}
}
