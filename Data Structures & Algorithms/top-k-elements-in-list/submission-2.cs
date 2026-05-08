public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
{
    var freq = new Dictionary<int, int>();
    foreach (var num in nums)
    {
        freq[num] = freq.GetValueOrDefault(num, 0) + 1;
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
