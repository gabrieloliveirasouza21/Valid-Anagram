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

            char[] chars = s.ToCharArray();
            char[] chart = t.ToCharArray();

            for (int i = 0; i < chars.Length - 1; i++) {
                for (int j = 0; j < chars.Length - i -1; j++) {
                    if (chars[j] > chars[j+1]) {
                        char aux = chars[j];
                        chars[j] = chars[j+1];
                        chars[j+1] = aux;
                    }
                }
            }

            for (int i = 0; i < chart.Length - 1; i++) {
                for (int j = 0; j < chart.Length - i - 1; j++) {
                    if (chart[j] > chart[j+1]) {
                        char aux = chart[j];
                        chart[j] = chart[j+1];
                        chart[j+1] = aux;
                    }

                }

            }

            int cont = 0;
            for (int i = 0; i < chars.Length; i++) {
                if (chars[i] != chart[i]) {
                    break;
                }
                cont++;
            }

            if (cont.Equals(chars.Length)) {
                Console.WriteLine("A palavra é anagrama");
                return true;
            }



            //foreach (char c in chars) {
            //    Console.WriteLine(c);
            //}

            //Console.WriteLine(" ");

            //foreach (char c in chart) {
            //    Console.WriteLine(c);
            //}

            return false;

        }


        Console.WriteLine("Escreva uma palvra, para verificar se e anagrama :");
        string palavra1 = Console.ReadLine();
        Console.WriteLine("Escreva outra palavra : ");
        string palavra2 = Console.ReadLine();
        IsAnagram(palavra1, palavra2);

    }

    
}