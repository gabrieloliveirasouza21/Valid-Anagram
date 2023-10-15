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

        bool IsAnagram(string s, string t) {
            char[] SChars = s.ToCharArray();
            char[] TChars = t.ToCharArray();
            int cont = 0;
            //Constraint: 

            //1) Mesmas letras 

            for (int i = 0; i < SChars.Length; i++) {
                char c = SChars[i];
                for (int j = 0; j < TChars.Length; j++) {
                    if (c.Equals(TChars[j])) {
                        cont++;
                        if (cont.Equals(TChars.Length)) {
                            return true;
                        }
                    }
                }
            }
            return false;

        }

        Console.WriteLine(IsAnagram("amor", "roma"));

    }

    
}