using ItsLeet.Sorting;
using System.Diagnostics;


GroupAnagramSolution GroupAnagram = new GroupAnagramSolution();
IList<IList<string>> results = GroupAnagram.GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" });
//IList<IList<string>> results = GroupAnagram.GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" });
//IList<IList<string>> results = GroupAnagram.GroupAnagrams(new[] { "a" });

foreach (var result in results)
{
    Console.Write('[');
    foreach (string r in result)
    {
        Console.Write(r + ',');
    }
    Console.Write("], ");
}

Console.ReadLine();
