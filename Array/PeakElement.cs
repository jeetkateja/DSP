// Peak element from Array:
// edge cases: 
// if first element is greater than second return that, if last element is greater than second last return that
// Approaches 
// 1: Traverse through array and if i > i+1 && i < i-1 then return peak element
// 2: Binary search
//    if mid is first or mid is greater than mid-1 return that  && mid is last or mid is greater than mid+1 return mid  
//    if mid element is less than mid -1 then apply search on left of mid element
//    else right side search

class Solution
    {
        
        public int findPeak(int[] arr, int l, int h ,int n)
        {
            int mid = l + (h - l)/2;
            
            if((mid == 0 || arr[mid] >= arr[mid-1]) &&
                (mid == n-1 || arr[mid] >= arr[mid+1]))
                return mid;
            
            else if(mid > 0 && arr[mid-1] > arr[mid])
                return findPeak(arr,l,(mid-1),n);
                
            else 
                return findPeak(arr,(mid+1),h,n);
            
        }
        
        public int peakElement(int[] arr, int n)
        {
            //Approach 1 O(n)
            //if(n == 1)
            //    return 0;
                
            //if(arr[0] >= arr[1])
            //    return 0;
                
            //if(arr[n-1] >= arr[n-2])
            //    return n-1;
                
            //for(int i=1; i<=n-2; i++)
            //{
            //    if(arr[i] >= arr[i-1] && arr[i] >= arr[i+1])
            //        return i;
            //}
            //return 0;
            
            //Approach 2 O(logn)
            return findPeak(arr,0,n-1,n);
        }
    }
