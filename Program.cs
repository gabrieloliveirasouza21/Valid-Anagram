using System.Data;

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