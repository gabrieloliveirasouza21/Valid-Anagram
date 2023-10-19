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

            char[] chars = s.ToCharArray();
            char[] chart = t.ToCharArray();
            Dictionary<char, int> DicS = new Dictionary<char, int>();
            Dictionary<char, int> DicT= new Dictionary<char, int>();
            

            for (int i = 0; i < chars.Length; i++) {
                int cont = 0;
                char aux = chars[i];
                for (int j = 0; j < chars.Length; j++) {
                    if (aux.Equals(chars[j])) {
                        cont++;
                    }
                }
                if (DicS.ContainsKey(aux)) {
                    continue;
                }

                DicS.Add(aux, cont);
            }

            for (int i = 0; i < chart.Length; i++) {
                int cont = 0;
                char aux = chart[i];
                for (int j = 0; j < chart.Length; j++) {
                    if (aux.Equals(chart[j])) {
                        cont++;
                    }
                }
                if (DicT.ContainsKey(aux)) {
                    continue;
                }
                DicT.Add(aux, cont);
            }

            int contador = 0;
            foreach (var i in DicS) {
                char aux = i.Key;
                foreach (var j in DicT) {
                    if (i.Key.Equals(j.Key) && i.Value.Equals(j.Value)) {
                        contador++;
                    }
                }
                
            }
            if (contador.Equals(DicT.Count) && contador.Equals(DicS.Count)) {
                return true;
            }

            return false;
           


            //for (int i = 0; i < chars.Length - 1; i++) {
            //    for (int j = 0; j < chars.Length - i -1; j++) {
            //        if (chars[j] > chars[j+1]) {
            //            char aux = chars[j];
            //            chars[j] = chars[j+1];
            //            chars[j+1] = aux;
            //        }
            //    }
            //}

            //for (int i = 0; i < chart.Length - 1; i++) {
            //    for (int j = 0; j < chart.Length - i - 1; j++) {
            //        if (chart[j] > chart[j+1]) {
            //            char aux = chart[j];
            //            chart[j] = chart[j+1];
            //            chart[j+1] = aux;
            //        }
            //    }
            //}

            //int cont = 0;
            //for (int i = 0; i < chars.Length; i++) {
            //    if (chars[i] != chart[i]) {
            //        break;
            //    }
            //    cont++;
            //}

            //if (cont.Equals(chars.Length)) {
            //    Console.WriteLine("deu bom");
            //    return true;
            //}

            //return false;

        }

        Console.WriteLine(IsAnagram("ab", "a"));
        

    }

    
}