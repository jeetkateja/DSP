//Q: Find sub array with Given Sum
//Approach 1: Traverse through all array and maintain sum from i to last index if matches return else move to next index TC: O(n^2)
//Approach 2: Maintain curr_sum and start pointer at first item of array and traverse. if curr_sum exceed sum remove starting item from sum and increase value of start
// TC for 2 : O(n) 

public class Solution
{
  public List<int> subArray(int[] arr, int n, int s)
  {
    int curr_sum = arr[0];
    int start = 0;
    
    for(int i=1; i<=n; i++)
    {
      while(curr_sum > s && start < i-1)
      {
        curr_sum  -= arr[s];
        start++;
      }
      
      if(curr_sum == s)
      {
        return new List<int> { start+1; i);
      }
      
      if(i < n)
      {
      curr_sum += arr[i];
      }
    }
    return new List<int>{-1};
  }
}
