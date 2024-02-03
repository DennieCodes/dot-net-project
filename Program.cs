
// using System.Numerics;
// using System.Reflection.Metadata;

int findMaxSumSubArray(int k, int[] arr)
{
  int windowSum = 0, maxSum = 0;
  int windowsStart = 0;

  for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
  {
    windowSum += arr[windowEnd];

    if (windowEnd >= k - 1)
    {
      maxSum = Math.Max(maxSum, windowSum);
      windowSum -= arr[windowsStart];
      windowsStart++;
    }
  }

  return maxSum;
}

var result = findMaxSumSubArray(3, [2, 1, 5, 1, 3, 2]);
Console.WriteLine(result);
