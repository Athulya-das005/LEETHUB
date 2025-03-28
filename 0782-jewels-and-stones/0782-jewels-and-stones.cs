

public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int gems = 0;

        foreach (char c in stones)
        {
            if (jewels.Contains(c))
            gems++;
        }

        return gems;
    }
}

