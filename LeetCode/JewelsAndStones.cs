public int NumJewelsInStones(string jewels, string stones)
{
    if(jewels.Length == 0 || stones.Length == 0)
    {
        return 0;
    }

    int result = 0;
    Dictionary<char, int> tempCounter = new Dictionary<char, int>();

    for (int i = 0; i < jewels.Length; i++)
    {
        // all jewels are unique character so no check is necessary
        tempCounter.Add(jewels[i], 0);
    }

    for (int i = 0; i < stones.Length; i++)
    {
        if(tempCounter.ContainsKey(stones[i]))
        {
            result++;
        }
    }

    return result;
}