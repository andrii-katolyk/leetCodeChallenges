using Leetcode.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class AtoiTests
	{
		[TestMethod]
		public void AtoiV1_Number()
		{
			string str = "45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV1(str);

			Assert.AreEqual(45, result);
		}

		[TestMethod]
		public void AtoiV2_Number()
		{
			string str = "45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV2(str);

			Assert.AreEqual(45, result);
		}

		[TestMethod]
		[TestCategory("V3")]
		public void AtoiV3_Number()
		{
			string str = "45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV3(str);

			Assert.AreEqual(45, result);
		}

		[TestMethod]
		public void AtoiV1_NegativeNumber()
		{
			string str = "   -45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV1(str);

			Assert.AreEqual(-45, result);
		}

		[TestMethod]
		public void AtoiV2_NegativeNumber()
		{
			string str = " -45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV2(str);

			Assert.AreEqual(-45, result);
		}

		[TestMethod]
		[TestCategory("V3")]
		public void AtoiV3_NegativeNumber()
		{
			string str = "   -45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV3(str);

			Assert.AreEqual(-45, result);
		}

		[TestMethod]
		public void AtoiV1_LetterAfterSign()
		{
			string str = "   -a 45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV1(str);

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void AtoiV2_LetterAfterSign()
		{
			string str = " -a 45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV2(str);

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		[TestCategory("V3")]
		public void AtoiV3_LetterAfterSign()
		{
			string str = "   -a 45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV3(str);

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void AtoiV1_LetterFirst()
		{
			string str = "   a 45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV1(str);

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void AtoiV2_LetterFirst()
		{
			string str = " a 45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV2(str);

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		[TestCategory("V3")]
		public void AtoiV3_LetterFirst()
		{
			string str = "   a 45";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV3(str);

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void AtoiV1_SignAfterDigit()
		{
			string str = "1-5";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV1(str);

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void AtoiV2_SignAfterDigit()
		{
			string str = "1-5";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV2(str);

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		[TestCategory("V3")]
		public void AtoiV3_SignAfterDigit()
		{
			string str = "1-5";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV3(str);

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void AtoiV1_MoreThanMax()
		{
			string str = " 2147483648";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV1(str);

			Assert.AreEqual(2147483647, result);
		}

		[TestMethod]
		public void AtoiV2_MoreThanMax()
		{
			string str = "2147483648";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV2(str);

			Assert.AreEqual(2147483647, result);
		}

		[TestMethod]
		[TestCategory("V3")]
		public void AtoiV3_MoreThanMax()
		{
			string str = "2147483648";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV3(str);

			Assert.AreEqual(2147483647, result);
		}

		[TestMethod]
		public void AtoiV1_ZerosFirst()
		{
			string str = "     000002147483645";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV1(str);

			Assert.AreEqual(2147483645, result);
		}

		[TestMethod]
		public void AtoiV2_ZerosFirst()
		{
			string str = "     000002147483645";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV2(str);

			Assert.AreEqual(2147483645, result);
		}

		[TestMethod]
		[TestCategory("V3")]
		public void AtoiV3_ZerosFirst()
		{
			string str = "     000002147483645";

			var atoi = new Atoi();
			int result = atoi.MyAtoiV3(str);

			Assert.AreEqual(2147483645, result);
		}
	}
}
