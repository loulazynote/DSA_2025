/// <summary>
/// We are given two strings word1 and word2.
/// Our task is to merge the strings by adding letters in alternating order, starting with word1. If one string is longer than the other, the additional letters must be appended to the end of the merged string.
/// We must return the merged string that has been formed.
/// </summary> 
public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int m = word1.Length;          // m
        int n = word2.Length;          // n
        int i = 0, j = 0;              // 1 + 1
        string result = string.Empty;  // 1

        while (i < m || j < n)         // 1 + 1 + 1 
        {
            if (i < m)                 // (m + n) * 1
            {
                result += word1[i];    // string in C# is immutable,  (1 + 1 + 1) * (m + n)[1 + (m + n)]/2
                i++;                   // (m + n) * 1
            }

            if (j < n)                 // (m + n) * 1
            {
                result += word2[j];    // (1 + 1 + 1) * (m + n)[1 + (m + n)]/2
                j++;                   // (m + n) * 1
            }
        }


        return result;                // 1
    }

    /*
        let m present the length of word1
        let n present the length of word2
        T(n) = m + n + 1 + 1 + 1 + 1 + 1 + 1 + (m + n) + (1 + 1 + 1) * (m + n)[1 + (m + n)]/2 + (m + n) * 1 + (m + n) * 1 + (1 + 1 + 1) * (m + n)[1 + (m + n)]/2 + (m + n) * 1 + 1
             = m + n + 6 + (m + n) + 3[(m + n) + (m + n)^2]/2 + (m + n) + (m + n) + 3[(m + n) + (m + n)^2]/2 + (m + n) + 1
             = 7 + m + n + 4(m + n) + 6[(m + n) + (m + n)^2]/2
             = 7 + 5(m + n) + 3(m + n) + 3(m + n)^2
             = 7 + 8(m + n) + 3(m + n)^2
             = O((m + n)^2)
        S(n) = 1 + 1 + 1 + 1 + (m + n)
             = 4 + (m + n)
             = O(m + n)
    */


    public string MergeAlternately2(string word1, string word2)
    {
        int m = word1.Length, n = word2.Length;             // m, n
        var sb = new System.Text.StringBuilder(m + n);      // 1
        int i = 0, j = 0;                                   // 1, 1

        while (i < m || j < n)                              // 1 + 1 + 1
        {
            if (i < m)                                      // 1 * (m + n)
            {
                sb.Append(word1[i]);                        // 1 + 1 * (m + n)
                i++;                                        // 1
            }

            if (j < n)                                      // 1 * (m + n)
            {
                sb.Append(word2[j]);                        // 1 + 1 * (m + n)
                j++;                                        // 1
            }
        }

        return sb.ToString();                               // 1
    }
}


/*
    let m present the length of word1
    let n present the length of word2
    T(n) = m + n + 1 + 1 + 1 + 1 + 1 + 1 + (m + n) + 1 + 1 * (m + n) + 1 + (m + n) + 1 + 1 * (m + n) + 1 + 1
         = m + n + 11 + 4(m + n)
         = 11 + 5(m + n)
         = O(m + n)
    S(n) = 1 + 1 + 1 + 1 + (m + n)
         = 4 + (m + n)
         = O(m + n)
*/
