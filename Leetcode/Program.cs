using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			RomanaNumbers romanaNumbers = new RomanaNumbers();
			var integerStr = Console.ReadLine();
			Console.WriteLine(romanaNumbers.IntToRomana(Convert.ToInt32(integerStr)));
			Console.ReadLine();
		}
	}
}
