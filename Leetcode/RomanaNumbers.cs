using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
	public class RomanaNumbers
	{
		public string IntToRomana(int integer)
		{
			string str = "";

			Dictionary<int, string> romana = new Dictionary<int, string>();
			romana.Add(1000, "M");
			romana.Add(900, "CM");
			romana.Add(500, "D");
			romana.Add(400, "CD");
			romana.Add(100, "C");
			romana.Add(90, "XC");
			romana.Add(50, "L");
			romana.Add(40, "XL");
			romana.Add(10, "X");
			romana.Add(9, "IX");
			romana.Add(5, "V");
			romana.Add(4, "IV");
			romana.Add(1, "I");
			
			if(romana.ContainsKey(integer))
			{
				str = romana[integer];
				return str;
			}
			
			while(integer != 0)
			{
				var max = romana.FirstOrDefault(i => integer - i.Key >= 0);
				str += max.Value;
				integer -= max.Key;
			}

			return str;
		}

		public int RomanToInt(string s)
		{
			int integer = 0;

			Dictionary<string, int> romanaDictionary = new Dictionary<string, int>();
			romanaDictionary.Add("I", 1);
			romanaDictionary.Add("V", 5);
			romanaDictionary.Add("X", 10);
			romanaDictionary.Add("L", 50);
			romanaDictionary.Add("C", 100);
			romanaDictionary.Add("D", 500);
			romanaDictionary.Add("M", 1000);

			int i = 0;
			while (i < s.Length)
			{
				if(i+1 == s.Length)
				{
					integer += romanaDictionary[s[i].ToString()];
					i++;
				}
				else if (romanaDictionary[s[i].ToString()] >= romanaDictionary[s[i + 1].ToString()])
				{
					integer += romanaDictionary[s[i].ToString()];
					i++;
				}
				else if (romanaDictionary[s[i].ToString()] < romanaDictionary[s[i + 1].ToString()])
				{
					integer += (romanaDictionary[s[i + 1].ToString()] - romanaDictionary[s[i].ToString()]);
					i += 2;
				}
			}

			return integer;
		}
	}
}
