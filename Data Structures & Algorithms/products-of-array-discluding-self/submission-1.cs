public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int l=nums.Length;
        
        int[] result= new int[l];
        result[0]=1;

        for(int i=1;i<l;i++)
        {
            result[i]=result[i-1]*nums[i-1];
        }
        int suffix=1;
        for(int i=l-1;i>=0;i--)
        {
            result[i]*=suffix;
            suffix*=nums[i];
        }
        

        return result;
    }
}
