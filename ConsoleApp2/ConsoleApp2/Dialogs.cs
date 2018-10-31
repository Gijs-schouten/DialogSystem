using System;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{

	class Dialogs {
		private int stage;

		public void main() {

			var result = new ChooseOption().result;
			var print = new PrintDialog();

			switch (stage) {
				case 0:
					print.printSection("Guy: hey", "A: hi", "B: hi", "C: nice", "D: cool");
					Console.WriteLine(stage);
					stage++;
					Console.WriteLine(stage);
					result = null;
					break;
				case 1:
					switch (result) {
						case "a":
							print.printSection("Guy: How you doin?", "A: Fine, thanks.", "B: Shut up.", "empty", "empty");
							break;
						case "b": 
							print.printSection("Guy: *dies*", "A: cool", "empty", "empty", "empty");
							break;
						case "c":
							print.printSection("Guy: Well okay.", "A: ", "B: ", "empty", "empty");
							break;
						case "d":
							print.printSection("Guy: ye", "empty", "empty", "empty", "empty");
							break;
					}
					stage++;
					break;

				case 2:
					break;
					
			}
		}
	}
}
