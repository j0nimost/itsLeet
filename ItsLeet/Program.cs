using ItsLeet.ArrayQuestions;
using ItsLeet.Greedy;
using ItsLeet.HashTable;

// var numberofEQ = new NumberOfEQDominoPairs();
// var result = numberofEQ.NumEquivDominoPairs([[1, 2], [2, 1], [3, 4], [5, 6]]);
// Console.WriteLine(result);

var longestUnequal = new LongestUnequalAdjacentGroupSubsequence();
var result = longestUnequal.GetLongestSubsequence(["a","b","c","d"], [1,0,1,1]);
foreach (var item in result)
    Console.Write(item + " ");
Console.WriteLine();
