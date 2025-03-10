var hasSpecialSubstring = function(s, k) {
    const n = s.length;
    let prev, count = 0;

    for (let i = 0; i < n; ++i) {
        if (prev === s[i]) ++count;
        else {
            if (count === k) return true;
            count = 1;
            prev = s[i];
        }
    }

    return count === k;
};