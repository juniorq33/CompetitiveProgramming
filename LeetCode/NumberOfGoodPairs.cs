public int NumIdenticalPairs(int[] nums)
{
    if(nums.Length <= 1)
    {
        return 0;
    }

    int result = 0;

    Dictionary<int, int> pairs = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if(!pairs.ContainsKey(nums[i]))
        {
            pairs.Add(nums[i], 1);
        }
        else
        {
            pairs[nums[i]]++;
        }
    }

    for (int i = 0; i < pairs.Count; i++)
    {
        int count = pairs.ElementAt(i).Value;

        if(count != 0)
        {
            result = result + (count * (count - 1) / 2);
        }

    }

    return result;
}