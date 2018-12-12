using System;

namespace Leetcode
{
	public class IntReverser
	{
		public int Reverse(int x)
		{
			var sign = x > 0 ? 1 : -1;

			int l = x.ToString().Length;
			l = x > 0 ? l : l - 1;
			int digits = l ;

			int result = 0;

			int digitsLeft = digits-1;

			while (digitsLeft >= 0)
			{
				int digit = x % 10;

				if(digitsLeft == digits - 1 && digits == 10)
				{
					int maxIntFirstDigit = int.MaxValue / GetTenPower(digitsLeft);
					int minIntFirstDigit = int.MinValue / GetTenPower(digitsLeft);
					if (digit > maxIntFirstDigit || digit < minIntFirstDigit)
					{
						return 0;
					}
				}

				digit *= sign;
				x = x / 10;
				int prevResult = result/10 + digit * (GetTenPower(digitsLeft)/10);
				result += digit * GetTenPower(digitsLeft);

				if (digits == 10 && digitsLeft > 0)
				{
					int res = prevResult / (GetTenPower(digitsLeft)/10);
					int maxResDigit = int.MaxValue / GetTenPower(digitsLeft);
					int minResDigit = (int.MinValue / GetTenPower(digitsLeft)) * (-1);
					if (res > maxResDigit || res > minResDigit)
					{
						return 0;
					}
				}
				else if (digits == 10 && digitsLeft == 0)
				{
					int maxResDigit = int.MaxValue % 10;
					int minResDigit = (int.MinValue % 10) * (-1);
					if (digit > maxResDigit || digit > minResDigit)
					{
						return 0;
					}
				}

					digitsLeft--;
			}

			return result*sign;
		}

		private int GetTenPower(int pow)
		{
			int result = 1;

			for(int i=1; i<=pow; i++)
			{
				result *= 10;
			}
			return result;
		}
	}
}
