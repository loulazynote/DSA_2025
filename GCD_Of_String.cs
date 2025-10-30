/*
For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).
Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

Example 1:
Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"

Example 2:
Input: str1 = "ABABAB", str2 = "ABAB"
Output: "AB"

Example 3:
Input: str1 = "LEET", str2 = "CODE"
Output: ""

Constraints:
1 <= str1.length, str2.length <= 1000
str1 and str2 consist of English uppercase letters.

*/
public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)                     // 1 + 1 + 1
            return "";                                      // 1

        int gcdLen = GCD(str1.Length, str2.Length);         // 1 + T(n)
        return str1.Substring(0, gcdLen);                   // 1 + 1
    }

    private int GCD(int a, int b)
    {
        while (b != 0)                       // 1 + n
        {
            int temp = b;                    // (1 + 1)n
            b = a % b;                       // (1 + 1)n
            a = temp;                        // n
        }
        return a;                            // 1
    }
}


/*
    GCD:
    let n present the length of loop iterations
    T(n) = 1 + n+ (1 + 1)n+ (1 + 1)n+ n+ 1
         = 2 + n + 2n + 2n + n
         = 2 + 6n
         = O(n)


    GcdOfStrings:
    let n present the length of str1
    let m present the length of str2
    T(n) = 1 + 1 + 1 + 1 + T(n) + 1 + 1
         = 6 + T(n)
         = 6 + 2 + 6k
         = 8 + 6k
         = O(k)
    S(n) = 1 + 1 + 1 + 1 + 1
         = 5
         = O(1)

　　 Additional:
    string is immutable in C#, so O(k) will be O(m + n)
*/