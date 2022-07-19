public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        List<Tuple<int, int>> mp = new List<Tuple<int, int>>();
        for (int x = 0; x < nums.Length; x++)
        {
            mp.Add(Tuple.Create(nums[x], x));
        }

        //Sort
        mp.Sort();

        int i = 0, j = nums.Length - 1;
        int idx1 = 0, idx2 = 0;

        while(i<j)
        {
            if(mp[i].Item1 + mp[j].Item1 == target)
            {
                idx1 = mp[i].Item2;
                idx2 = mp[j].Item2;
                break;
            }

            if (mp[i].Item1 + mp[j].Item1 < target) i++;
            if (mp[i].Item1 + mp[j].Item1 > target) j--;

        }

        return new int[] { idx1, idx2 };
        
        
    }
}