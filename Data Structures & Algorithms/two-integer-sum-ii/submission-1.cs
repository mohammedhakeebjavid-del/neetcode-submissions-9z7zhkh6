public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        int left=0;
        int right=numbers.Length-1;
        while(left<right)
        {
            int cs= numbers[left]+ numbers[right];
            if(cs==target)
            {
                return new int[] {left+1, right+1};
            }
            if(cs<target)
            left++;
            else
            right--;


        }
        return new int[] {};
    }
}
