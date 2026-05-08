public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
{
    var freq = new Dictionary<int, int>();
    for (var i = 0; i < nums.Length; i++)
    {
        freq[nums[i]] = freq.GetValueOrDefault(nums[i], 0) + 1;
    }

    var heap = new PriorityQueue<int, int>();
    foreach (var kv in freq)
    {
        heap.Enqueue(kv.Key, kv.Value);
    }

    var arr = new List<int>();
    while (heap.Count > 0)
    {
        if (heap.Count <= k)
        {
            arr.Add(heap.Dequeue());
        }
        else
        {
            heap.Dequeue();

        }
    }

    return arr.ToArray();
}
}
