public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dic=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            int needed=target-nums[i];
            if(dic.ContainsKey(needed))
            {
                return new int[]{dic[needed],i};
            }
            dic[nums[i]]=i;
        }
        return new int[]{};
    }
}
