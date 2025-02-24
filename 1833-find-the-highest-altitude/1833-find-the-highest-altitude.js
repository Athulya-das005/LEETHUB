/**
 * @param {number[]} gain
 * @return {number}
 */
var largestAltitude = function(gain) {
    let curr = 0;
    let max = 0;
    for (let i = 0; i < gain.length; i++) {
        curr += gain[i];
        if (curr > max) {
            max = curr;
        }
    }  
    return max;  
};
