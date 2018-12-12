using System;
using Leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class ChallengeTest
	{
		[TestMethod]
		public void TwoSums_TestMethod()
		{
			int[] result = new int[2];
			var sums = new TwoSums();
			result = sums.TwoSum(new int[3] { 3, 2, 4 }, 6);
		}

		[TestMethod]
		public void ReverseInt_TestMethod()
		{
			var reverser = new IntReverser();
			var r = reverser.Reverse(1463847412);
		}

		[TestMethod]
		public void RomanaToInteger_TestMethod()
		{
			var romanaNumbers = new RomanaNumbers();
			var integer = romanaNumbers.RomanToInt("III");
		}

		[TestMethod]
		public void IntegerToRomana_TestMethod()
		{
			var romanaNumbers = new RomanaNumbers();
			var integer = romanaNumbers.IntToRomana(1994);
		}
	}
}
