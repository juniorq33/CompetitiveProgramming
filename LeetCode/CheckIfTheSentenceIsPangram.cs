public bool CheckIfPangram(string sentence)
{
    if(sentence.Length < 26 || sentence.Length == 0)
    {
        return false;
    }

    HashSet<char> letters = new HashSet<char>();

    for (int i = 0; i < sentence.Length; i++)
    {
        letters.Add(sentence[i]);
    }

    return letters.Count == 26;

}