public class Solution {
    public void NextPermutation(int[] nums) {
        int pivot = -1;

        for(int i = nums.Length - 1; i > 0; i--)
        {
            if(nums[i] > nums[i - 1]) // first number that is in decreasing fasion from end of array
            {
                pivot = i - 1;
                break;
            }
        }
        if(pivot != -1)
        {
            // if pivot is found, then swap the element at pivot with the 1st element from right which is greater than the pivot element
            for(int i = nums.Length - 1; i > pivot; i--)
            {
                if(nums[i] > nums[pivot])
                {
                    int temp = nums[i];
                    nums[i] = nums[pivot];
                    nums[pivot] = temp;
                    break;
                }
            }
        }

        // now just reverse the array from i = pivot + 1 to i = nums.Length - 1
        int start = pivot + 1, end = nums.Length - 1;
        while(start <= end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}

// Idea is that always there would a subpart of the array from end that would follow an ascending order
// find out where that pattern fails, i.e. where the element is smaller than it's next element
// make that index as the pivot index
// then swap the pivot index element with the first element from the right that is greater than the pivot element
