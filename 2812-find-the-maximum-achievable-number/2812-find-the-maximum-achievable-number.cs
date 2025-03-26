public class Solution {
public int TheMaximumAchievableX(int num, int t) {
    int x=num+t;
    for(int i=0; i<t; i++){
        x++;
        
    }
    return x;
    }   
}