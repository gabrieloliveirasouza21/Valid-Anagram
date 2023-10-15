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
            
            Dictionary<string, int> sLetters = new Dictionary<string, int>();
            Dictionary<string, int> tLetters = new Dictionary<string, int>();
            char[] charS = s.ToCharArray();
            char[] charT = t.ToCharArray();
           
            
            
            for (int i = 0; i < charS.Length; i++) {
                char atual = charS[i];
                int cont = 0;
                
                if (sLetters.ContainsKey(atual.ToString())) {
                    continue;
                }

                for (int j = 0; j < charS.Length; j++) {
                    if (atual.Equals(charS[j])) {
                        cont++;
                    }
                }
                sLetters.Add(atual.ToString(),cont);
            }

            for (int i = 0; i < charT.Length; i++) {
                char atual = charT[i];
                int cont = 0;

                if (tLetters.ContainsKey(atual.ToString())) {
                    continue;
                }

                for (int j = 0; j < charT.Length; j++) {
                    if (atual.Equals(charT[j])) {
                        cont++;
                    }
                }
                tLetters.Add(atual.ToString(), cont);
            }

            foreach (var item in sLetters) {
                foreach (var itemT in tLetters) {
                    if(item.Equals(itemT)) {
                        continue;
                    }
                }
                return true;
            }
            return false;
        }

        Console.WriteLine(IsAnagram("anagram", "nagajam"));

    }

    
}