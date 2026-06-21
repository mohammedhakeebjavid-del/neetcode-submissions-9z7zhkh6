public class Solution 
{
    public int LongestConsecutive(int[] nums) 
    {
    int n=nums.Length;
    int longest = 0;
    HashSet<int> set = new HashSet<int>(nums);
    foreach(int num in set)
    {
        if (!set.Contains(num - 1))
        {
            int currentNum = num;
            int currentLength = 1;
            while (set.Contains(currentNum + 1))
            {
                currentNum++;
                currentLength++;
            }
            longest = Math.Max(longest, currentLength);
        }

    }

    return longest;
     
    }
}
