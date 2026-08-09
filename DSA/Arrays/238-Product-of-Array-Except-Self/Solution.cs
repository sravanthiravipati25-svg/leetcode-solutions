public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] answer = new int[n];

        // Calculate prefix products
        answer[0] = 1;

        for (int i = 1; i < n; i++)
        {
            answer[i] = answer[i - 1] * nums[i - 1];
        }

        // Calculate suffix products
        int suffixProduct = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            answer[i] *= suffixProduct;

            suffixProduct *= nums[i];
        }

        return answer;
    }
}