using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {

    int[] arr = new int[s.Length];
    int valley_count = 0;
    int progress = 0;
    bool in_valley = false;

    for(var i = 0; i < s.Length; i++)
    {
      arr[i] = s[i] == 'D' ? -1 : 1;
    }

    for(var i = 0; i < s.Length; i++)
    {
      progress += arr[i];
      if (progress < 0 && !in_valley)
      {
        valley_count++;
        in_valley = true;
      } else if(progress >= 0)
      {
        in_valley = false;
      }
    }
    return valley_count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
