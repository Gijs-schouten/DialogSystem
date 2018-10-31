using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public class PrintDialog
	{
		public void printSection(string dialog, string a, string b, string c, string d) {
			printDialog(dialog);
			printOptions(a, b, c, d);
		}

		void printDialog(string dialog)
		{
			slowPrint(dialog);
			Console.Write("\n \n");
		}

		void printOptions(string a, string b, string c, string d) {
			slowPrint(a);
			Console.Write("\n");
			slowPrint(b);
			Console.Write("\n");
			slowPrint(c);
			Console.Write("\n");
			slowPrint(d);
			Console.Write("\n");
			
		}

		public void slowPrint(string dialog) {
			foreach (char c in dialog) {
				if (dialog == "empty")
				{
					return;
				}

				Console.Write(c);
				Thread.Sleep(50);

			}

		}
	}
}
