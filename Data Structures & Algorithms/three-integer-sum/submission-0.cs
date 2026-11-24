public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++) {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            TwoSum(nums, i + 1, -nums[i], nums[i], result);
        }

        return result;
    }

    private void TwoSum(int[] numbers, int start, int target, int firstNum, List<List<int>> result) {
        var dct = new Dictionary<int, int>();

        for (int n = start; n < numbers.Length; n++) {
            int diff = target - numbers[n];

            if (dct.ContainsKey(numbers[n])) {
                result.Add(new List<int> { firstNum, numbers[dct[numbers[n]]], numbers[n] });

                while (n + 1 < numbers.Length && numbers[n] == numbers[n + 1]) {
                    n++;
                }
            }

            dct.TryAdd(diff, n);
        }
    }
}