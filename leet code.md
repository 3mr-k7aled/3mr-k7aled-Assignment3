leet code problem : https://leetcode.com/problems/single-number/submissions/2141575526/

with C++ :
#include <iostream>
using namespace std;

int singleNumber(int nums[], int size)
{
    int result = 0;

    for (int i = 0; i < size; i++)
    {
        result ^= nums[i];
    }

    return result;
}

int main()
{
    int nums1[] = {2, 2, 1};
    int nums2[] = {4, 1, 2, 1, 2};

    cout << singleNumber(nums1, 3) << endl;
    cout << singleNumber(nums2, 5) << endl;

    return 0;
}

With C# : 
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int result = 0;

        // XOR cancels every number that appears twice, leaving the number that appears once.
        for (int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }

        return result;
    }
}
