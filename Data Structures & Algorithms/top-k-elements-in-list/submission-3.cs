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
        if (heap.Count > k)
        {
            heap.Dequeue();
        }
    }

    var arr = new int[k];
    for(var i = 0; i < k; i++)
    {
        arr[i] = heap.Dequeue();
    }

    return arr;
}
}
