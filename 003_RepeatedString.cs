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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
char find_char = 'a';
    bool persist = true;
    long count = 0;

    persist = !String.IsNullOrEmpty(s);
    persist = persist && n > 0;

    if(persist)
    {

      long repeat = n / s.Length;
      long remain = n - (repeat * s.Length);
      long char_count = 0;
      long char_count_in_remain = 0;

      for (var i = 0; i < s.Length; i++)
      {
        if(s[i] == find_char)
        {
          char_count++;
          if(i + 1 <= remain)
          {
            char_count_in_remain++;
          }
        }
      }

      count = (char_count * repeat) + char_count_in_remain;

    }

    return count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
