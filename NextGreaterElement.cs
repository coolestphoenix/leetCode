public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length];
        for (int i = 0; i< nums1.Length; i++){
            result[i] = FindNextGreater(nums1[i], nums2);
        }
        return result;
    }
    private int FindNextGreater(int num, int[] nums2) {
        bool search = false;
        for (int i = 0; i<nums2.Length; i++){
            if(num == nums2[i]){
                search = true;
            }
            if(search){
                if (nums2[i] > num){
                    return nums2[i];
                }
            }
        }
        return -1;
    }
}