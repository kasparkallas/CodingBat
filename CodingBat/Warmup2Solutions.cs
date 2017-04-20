using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    public class Warmup2Solutions
    {
        //public String stringTimes(String str, int n)
        //{
        //    String result = "";
        //    for (int i = 0; i < n; i++)
        //    {
        //        result = result + str;  // could use += here
        //    }
        //    return result;
        //}




        //int countXX(String str)
        //{
        //    int count = 0;
        //    for (int i = 0; i < str.length() - 1; i++)
        //    {
        //        if (str.substring(i, i + 2).equals("xx")) count++;
        //    }
        //    return count;
        //}
        //// Solution notes: the loop is shortened to end at str.length()-1
        //// so we can pull out a length 2 substring without going out of bounds.
        //// Remember to use equals() to compare strings, not ==.


        //public String frontTimes(String str, int n)
        //{
        //    int frontLen = 3;
        //    if (frontLen > str.length())
        //    {
        //        frontLen = str.length();
        //    }
        //    String front = str.substring(0, frontLen);

        //    String result = "";
        //    for (int i = 0; i < n; i++)
        //    {
        //        result = result + front;
        //    }
        //    return result;
        //}



        //boolean doubleX(String str)
        //{
        //    int i = str.indexOf("x");
        //    if (i == -1) return false; // no "x" at all

        //    // Is char at i+1 also an "x"?
        //    if (i + 1 >= str.length()) return false; // check i+1 in bounds?
        //    return str.substring(i + 1, i + 2).equals("x");

        //    // Another approach -- .startsWith() simplifies the logic
        //    // String x = str.substring(i);
        //    // return x.startsWith("xx");
        //}

        // Test-test-test


        //public String stringBits(String str)
        //{
        //    String result = "";
        //    // Note: the loop increments i by 2
        //    for (int i = 0; i < str.length(); i += 2)
        //    {
        //        result = result + str.substring(i, i + 1);
        //        // Alternately could use str.charAt(i)
        //    }
        //    return result;
        //}



        //public String stringSplosion(String str)
        //{
        //    String result = "";
        //    // On each iteration, add the substring of the chars 0..i
        //    for (int i = 0; i < str.length(); i++)
        //    {
        //        result = result + str.substring(0, i + 1);
        //    }
        //    return result;
        //}



        //public int last2(String str)
        //{
        //    // Screen out too-short string case.
        //    if (str.length() < 2) return 0;

        //    String end = str.substring(str.length() - 2);
        //    // Note: substring() with 1 value goes through the end of the string
        //    int count = 0;

        //    // Check each substring length 2 starting at i
        //    for (int i = 0; i < str.length() - 2; i++)
        //    {
        //        String sub = str.substring(i, i + 2);
        //        if (sub.equals(end))
        //        {  // Use .equals() with strings
        //            count++;
        //        }
        //    }

        //    return count;
        //}



        //public int arrayCount9(int[] nums)
        //{
        //    int count = 0;
        //    for (int i = 0; i < nums.length; i++)
        //    {
        //        if (nums[i] == 9)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}



        //public boolean arrayFront9(int[] nums)
        //{
        //    // First figure the end for the loop
        //    int end = nums.length;
        //    if (end > 4) end = 4;

        //    for (int i = 0; i < end; i++)
        //    {
        //        if (nums[i] == 9) return true;
        //    }

        //    return false;
        //}



        //public int stringMatch(String a, String b)
        //{
        //    // Figure which string is shorter.
        //    int len = Math.min(a.length(), b.length());
        //    int count = 0;

        //    // Look at both substrings starting at i
        //    for (int i = 0; i < len - 1; i++)
        //    {
        //        String aSub = a.substring(i, i + 2);
        //        String bSub = b.substring(i, i + 2);
        //        if (aSub.equals(bSub))
        //        {  // Use .equals() with strings
        //            count++;
        //        }
        //    }

        //    return count;
        //}



        //public int stringMatch(String a, String b)
        //{
        //    // Figure which string is shorter.
        //    int len = Math.min(a.length(), b.length());
        //    int count = 0;

        //    // Look at both substrings starting at i
        //    for (int i = 0; i < len - 1; i++)
        //    {
        //        String aSub = a.substring(i, i + 2);
        //        String bSub = b.substring(i, i + 2);
        //        if (aSub.equals(bSub))
        //        {  // Use .equals() with strings
        //            count++;
        //        }
        //    }

        //    return count;
        //}



        //public String stringX(String str)
        //{
        //    String result = "";
        //    for (int i = 0; i < str.length(); i++)
        //    {
        //        // Only append the char if it is not the "x" case
        //        if (!(i > 0 && i < (str.length() - 1) && str.substring(i, i + 1).equals("x")))
        //        {
        //            result = result + str.substring(i, i + 1); // Could use str.charAt(i) here
        //        }
        //    }
        //    return result;
        //}



        //public String altPairs(String str)
        //{
        //    String result = "";

        //    // Run i by 4 to hit 0, 4, 8, ...
        //    for (int i = 0; i < str.length(); i += 4)
        //    {
        //        // Append the chars between i and i+2
        //        int end = i + 2;
        //        if (end > str.length())
        //        {
        //            end = str.length();
        //        }
        //        result = result + str.substring(i, end);
        //    }

        //    return result;
        //}



        //public String stringYak(String str)
        //{
        //    String result = "";

        //    for (int i = 0; i < str.length(); i++)
        //    {
        //        // Look for i starting a "yak" -- advance i in that case
        //        if (i + 2 < str.length() && str.charAt(i) == 'y' && str.charAt(i + 2) == 'k')
        //        {
        //            i = i + 2;
        //        }
        //        else
        //        { // Otherwise do the normal append
        //            result = result + str.charAt(i);
        //        }
        //    }

        //    return result;
        //}



        //public int array667(int[] nums)
        //{
        //    int count = 0;
        //    // Note: iterate to length-1, so can use i+1 in the loop
        //    for (int i = 0; i < (nums.length - 1); i++)
        //    {
        //        if (nums[i] == 6)
        //        {
        //            if (nums[i + 1] == 6 || nums[i + 1] == 7)
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    return count;
        //}



        //public boolean noTriples(int[] nums)
        //{
        //    // Iterate < length-2, so can use i+1 and i+2 in the loop.
        //    // Return false immediately if every seeing a triple.
        //    for (int i = 0; i < (nums.length - 2); i++)
        //    {
        //        int first = nums[i];
        //        if (nums[i + 1] == first && nums[i + 2] == first) return false;
        //    }

        //    // If we get here ... no triples.
        //    return true;
        //}



        //public boolean has271(int[] nums)
        //{
        //    // Iterate < length-2, so can use i+1 and i+2 in the loop.
        //    // Return true immediately when seeing 271.
        //    for (int i = 0; i < (nums.length - 2); i++)
        //    {
        //        int val = nums[i];
        //        if (nums[i + 1] == (val + 5) &&              // the "7" check
        //          Math.abs(nums[i + 2] - (val - 1)) <= 2)
        //        {  // the "1" check
        //            return true;
        //        }
        //    }

        //    // If we get here ... none found.
        //    return false;
        //}
    }
}
