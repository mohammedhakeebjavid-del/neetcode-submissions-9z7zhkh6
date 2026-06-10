public class Solution {
    public bool hasDuplicate(int[] nums) {
       HashSet<int> n = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            n.Add(nums[i]);
        }

        return n.Count < nums.Length;
    }
}