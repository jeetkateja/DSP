//Difference between two elements of array
//Approach 1: traverse through array and maintain indexes of element 1 and element 2 and maintain min distance, check for min distance for all possible and return

public class Solution
{
  public int minDistantPair(int[] arr, int n, int x, int y)
  {
    int idx1 = -1, idx2 = -1, min_dist = int.MaxValue;
    for(int i=0; i<n; i++)
    {
      if(arr[i] == x)
        idx1 = i;
      else if(arr[i] == y)
        idx2= i;
      
      if(idx1 != -1 && idx2 != -1)
        min_dist = Math.Min(min_dist, Math.Abs(idx1-idx2));
    }
  
    if(idx1 == -1 || idx2 == -1)
      return -1;
    else
      return min_dist;
  }
}
