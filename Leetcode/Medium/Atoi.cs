using System.Collections.Generic;

namespace Leetcode.Medium
{
	public class Atoi
	{
		//pure native implementation
		public int MyAtoiV1(string str)
		{
			int integer = 0;

			Dictionary<char, int> integers = new Dictionary<char, int>();
			integers.Add('0', 0);
			integers.Add('1', 1);
			integers.Add('2', 2);
			integers.Add('3', 3);
			integers.Add('4', 4);
			integers.Add('5', 5);
			integers.Add('6', 6);
			integers.Add('7', 7);
			integers.Add('8', 8);
			integers.Add('9', 9);

			int sign = 1;

			if (!string.IsNullOrWhiteSpace(str))
			{
				int i = 0;
				bool integerStarts = false;
				int numbersParsed = 0;

				while (i < str.Length)
				{
					if (!integerStarts)
					{
						if (str[i] == ' ')
						{
							i++;
							continue;
						}
						else if (str[i] == '-' || str[i] == '+')
						{
							sign = str[i] == '-' ? -1 : 1;
							i++;
							integerStarts = true;
							continue;
						}
					}

					if (!integers.ContainsKey(str[i]))
					{
						break;
					}
					else
					{
						if(numbersParsed > 9)
						{
							return sign > 0 ? int.MaxValue : int.MinValue;
						}

						integerStarts = true;

						int? number = integers[str[i]];
						
						if (numbersParsed == 9)
						{
							int signedInt = integer * sign;
							if (signedInt > 0
								&& (signedInt > int.MaxValue / 10 || (signedInt == int.MaxValue / 10 && number.Value > 7)))
							{
								return int.MaxValue;
							}
							else if (signedInt < 0
								&& (signedInt < int.MinValue / 10 || (signedInt == int.MinValue / 10 && number.Value > 8)))
							{
								return int.MinValue;
							}
						}

						integer = integer * 10 + number.Value;

						i++;

						if (integer > 0)
						{
							numbersParsed++;
						}
					}
				}
			}

			return integer*sign;
		}
		
		//With Trim first and long int
		public int MyAtoiV2(string str)
		{
			long integer = 0;

			Dictionary<char, int> integers = new Dictionary<char, int>();
			integers.Add('0', 0);
			integers.Add('1', 1);
			integers.Add('2', 2);
			integers.Add('3', 3);
			integers.Add('4', 4);
			integers.Add('5', 5);
			integers.Add('6', 6);
			integers.Add('7', 7);
			integers.Add('8', 8);
			integers.Add('9', 9);

			int sign = 1;

			str = str.Trim();

			if (!string.IsNullOrEmpty(str))
			{
				int i = 0;
				
				if(str[0] == '-' || str[0] == '+')
				{
					sign = str[0] == '-' ? -1 : 1;
					i = 1;
				}
				else if(!integers.ContainsKey(str[0]))
				{
					return 0;
				}

				while (i < str.Length)
				{
					if (!integers.ContainsKey(str[i]))
					{
						break;
					}
					else
					{
						int? number = integers[str[i]];

						integer = integer * 10 + number.Value;

						if (integer * sign > int.MaxValue)
						{
							return int.MaxValue;
						}
						if (integer * sign < int.MinValue)
						{
							return int.MinValue;
						}

						i++;
					}
				}
			}

			return (int)integer * sign;
		}

		//With char.IsDigit
		public int MyAtoiV3(string str)
		{
			long integer = 0;

			int sign = 1;

			str = str.Trim();

			if (!string.IsNullOrEmpty(str))
			{
				int i = 0;

				if (str[0] == '-' || str[0] == '+')
				{
					sign = str[0] == '-' ? -1 : 1;
					i = 1;
				}
				else if (!char.IsDigit(str[0]))
				{
					return 0;
				}

				while (i < str.Length)
				{
					if (!char.IsDigit(str[i]))
					{
						break;
					}
					else
					{
						int? number = int.Parse(str[i].ToString());

						integer = integer * 10 + number.Value;

						if (integer * sign > int.MaxValue)
						{
							return int.MaxValue;
						}
						if (integer * sign < int.MinValue)
						{
							return int.MinValue;
						}

						i++;
					}
				}
			}

			return (int)integer * sign;
		}
	}
}
