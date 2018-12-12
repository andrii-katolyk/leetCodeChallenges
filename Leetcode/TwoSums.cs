namespace Leetcode
{
	public class TwoSums
	{
		public int[] TwoSum(int[] nums, int target)
		{
			int[] result = new int[2];

			int length = nums.Length;
			int first = 0;
			int i = 0;

			while (i < length)
			{
				int second = i == first ? i + 1 : i;
				int sum = nums[first] + nums[second];
				if (sum == target)
				{
					result[0] = first;
					result[1] = second;
					break;
				}
				else if(i+1 == length && first < length)
				{
					first++;
					i = 0;
				}
				else
				{
					i++;
				}
			}

			return result;
		}
		
	}
}
