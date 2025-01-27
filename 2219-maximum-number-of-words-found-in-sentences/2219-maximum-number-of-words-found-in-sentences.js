/**
 * @param {string[]} sentences
 * @return {number}
 */
var mostWordsFound = function(sentences) {
     let len=0
    for(let i=0;i<sentences.length;i++){
        let words = sentences[i].split(' ').length;
        if(words>len){
            len=words;
        }
    }
    return len
};