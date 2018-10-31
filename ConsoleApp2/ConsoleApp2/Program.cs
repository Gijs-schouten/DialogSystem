using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using CommandLine;

namespace ConsoleApp2 {

	class Program {
		

		static void Main(string[] args) {
			var option = new ChooseOption();
			var dialog = new Dialogs();
			string command;
			bool quit = false;
			while (!quit) {
				dialog.main();
				command = Console.ReadLine();

				//Console.WriteLine(command);
				//Console.WriteLine(option.result);

				switch (command) {
					case "a":
						option.Choose("a");
						break;

					case "b":
						option.Choose("b");
						break;

					case "c":
						option.Choose("c");
						break;

					case "d":
						option.Choose("d");
						break;
				}
			}
		}
	}
}
