public class Solution {
    public int[] TwoSum(int[] nums, int target) {

Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            // Check if complement exists
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            // Store current number with index
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }

        return new int[] { -1, -1 }; // if no solution
    }
}
