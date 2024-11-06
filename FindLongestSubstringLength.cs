// Problem: Find Longest Substring Length
// Input: ABABCDEFA Output:6, Input: ABCDAB Output:4, Input: AAA Output:1
// Note: Below program is case sensitive

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try Find Longest Substring Length Program");
        Console.Write ("Enter a string:");
        string inputText = Console.ReadLine();
        int result = FindLongestSubstringLength(inputText);
        Console.WriteLine($"Longest substring length: {result.ToString()}");
    }
    
    public static int FindLongestSubstringLength(string text)
    {
        int result = 0;
        char[] chars = text.ToCharArray();
        //Console.WriteLine(chars.Length.ToString());
        List<char> charList = new List<char>();
        int index=0;
        int longestSS = 0;
                
        for(int i=0;i<chars.Length;i++)
        {
            index = i;
        while(index<chars.Length && !charList.Contains(chars[index]))
        {
            //Console.WriteLine(chars[index]);
            charList.Add(chars[index]);
            result++;
            if(index<=chars.Length)
                index++;
            //Console.WriteLine(result.ToString());
            //Console.WriteLine(index.ToString());
        }
        charList.Clear();
        
        longestSS = result>longestSS ? result: longestSS;
        result=0;
        }
        
        return longestSS;
    }
}