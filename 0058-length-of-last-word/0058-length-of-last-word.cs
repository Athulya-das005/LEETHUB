public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.TrimEnd();                
        string[] tmp = s.Split(' ');
        return tmp[tmp.Length-1].Length; 
    }
}