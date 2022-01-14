public int CountConsistentStrings(string allowed, string[] words)
{
    if(allowed.Length == 0 || words.Length == 0)
    {
        return 0;
    }

    int result = 0;
    HashSet<char> map = new HashSet<char>();

    for (int i = 0; i < allowed.Length; i++)
    {
        // safely adding distinct characters
        map.Add(allowed[i]);
    }

    for (int i = 0; i < words.Length; i++)
    {
        result++;
        for (int j = 0; j < words[i].Length; j++)
        {
            if(!map.Contains(words[i][j]))
            {
                result--;
                break;
            }
        }
    }

    return result;
}