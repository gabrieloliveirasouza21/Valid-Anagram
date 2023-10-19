using System.Data;


//Given two strings s and t, return true if t is an anagram of s, and false otherwise.

//An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

//Example 1:

//Input: s = "anagram", t = "nagaram"
//Output: true
//Example 2:

//Input: s = "rat", t = "car"
//Output: false

internal class Program {
    private static void Main(string[] args) {

        bool IsAnagram (string s, string t) {

            if (s.Length != t.Length) {
                return false;
            }

            Dictionary<char, int> dic = new Dictionary<char, int>(); 

            foreach (char c in s) {
                if (dic.ContainsKey(c)) {
                    dic[c]++;
                }
                else {
                    dic[c] = 1;
                }
            }

            foreach (char c in t) {
                if (dic.ContainsKey(c)) {
                    dic[c]--;
                    if (dic[c].Equals(0)) {
                        dic.Remove(c);
                    }
                }
                else {
                    return false;
                }
            }
            return dic.Count == 0;
        }

        Console.WriteLine(IsAnagram("a", "ab"));
        

    }

    
}