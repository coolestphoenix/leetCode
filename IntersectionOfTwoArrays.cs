public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        List<int> lst = new List<int>();
        
        for (int i=0;i<nums1.Length;i++)
        {
            if(!lst.Contains(nums1[i]))
                lst.Add(nums1[i]);
        }
        List<int> result =  new List<int>();
        for(int i=0;i<nums2.Length;i++)
        {
            if(lst.Contains(nums2[i]))
                result.Add(nums2[i]);
        }
        return result.Distinct().ToArray();
    }
}