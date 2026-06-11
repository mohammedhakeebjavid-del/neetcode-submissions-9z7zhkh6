public class Solution {
    public bool IsAnagram(string s, string t) {
    int l1=s.Length,l2=t.Length;
    if(l1!=l2)
    return false;
    char[] a=s.ToCharArray();
    char[] b=t.ToCharArray();
    Array.Sort(a);
    Array.Sort(b);

    return new string(a)==new string(b);

    }

}
