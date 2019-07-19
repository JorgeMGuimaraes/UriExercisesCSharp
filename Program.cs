// 1022

namespace URI {

	class URI {
		static void Main(string[] args) {
			var line = System.Console.ReadLine();
			line = line.Replace(",", "\n");
			System.Console.Write(line + "\n");
			return;
		}
	}
}

/*

// 2765
#include <iostream>
#include <string>

int main2765() {
	std::string line {};
	std::getline(std::cin, line);
	int pos = line.find(',');
	line.replace(pos, 1, "\n");
	std::cout << line << "\n";
	return 0;
}
*/
