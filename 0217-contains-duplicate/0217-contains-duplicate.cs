public class Solution 
{
    public bool ContainsDuplicate(int[] nums) 
    {
        List<int> list = new List<int>();
        
        foreach (int num in nums)
        {
            if (list.Contains(num))
            {
                return true;
            }
            list.Add(num);
        }
        
        return false;
    }
}